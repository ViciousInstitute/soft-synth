using System.IO;
using NAudio.Wave;


namespace Synth2504
{
    class WaveMemoryStream
    {
        /// <summary>
        /// Converts a double array into a wave byte stream
        /// </summary>
        /// <param name="sampleData"></param>
        /// <param name="sampleCount"></param>
        /// <param name="samplesPerSecond"></param>
        public void SaveIntoStream(double[] sampleData, int sampleCount, int samplesPerSecond)
        {
            // Export
            MemoryStream stream = new MemoryStream();
            MemoryStream bufferStream = new MemoryStream();
            double sample_l;
            short sl;
            for (int i = 0; i < sampleCount; i++)
            {
                sample_l = sampleData[i] * 30000.0;
                if (sample_l < -32767.0f)
                {
                    sample_l = -32767.0f;
                }
                if (sample_l > 32767.0f)
                {
                    sample_l = 32767.0f;
                }

                sl = (short)sample_l;
                stream.WriteByte((byte)(sl & 0xff)); //Channel 1, wave audio interleaves channels.
                stream.WriteByte((byte)(sl >> 8));
                stream.WriteByte((byte)(sl & 0xff)); //Channel 2
                stream.WriteByte((byte)(sl >> 8));
            }

            
            stream.Seek(0, SeekOrigin.Begin);
            //stream.CopyTo(bufferStream, 256);
            //stream.Seek(0, SeekOrigin.Begin);
            //bufferStream.Seek(0, SeekOrigin.Begin);

            IWaveProvider provider = new RawSourceWaveStream(
                         stream, new WaveFormat(samplesPerSecond, 2));

            IWavePlayer player = new WaveOut(/*WaveCallbackInfo.FunctionCallback()/**/);
            player.Init(provider);
            player.Play();
            
        }

        //this works, splits floats into a byte stream (2 channel wave format)
        static public byte[] ByteConverter(double sample)
        {
            double sample_l;
            short sl;
            sample_l = sample * 30000.0;
            if (sample_l < -32767.0f)
            {
                sample_l = -32767.0f;
            }
            if (sample_l > 32767.0f)
            {
                sample_l = 32767.0f;
            }

            sl = (short)sample_l;
            byte[] buffer = new byte[4];
            buffer[0] = (byte)(sl & 0xff);
            buffer[1] = (byte)(sl >> 8);
            buffer[2] = (byte)(sl & 0xff);
            buffer[3] = (byte)(sl >> 8);
           return buffer;
        }
    }
}
