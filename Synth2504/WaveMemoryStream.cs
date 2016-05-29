using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio.Wave;
using NAudio;
using NAudio.Dsp;


namespace Synth2504
{
    class WaveMemoryStream
    {
        public void SaveIntoStream(double[] sampleData, long sampleCount, int samplesPerSecond)
        {
            // Export
            MemoryStream stream = new MemoryStream();
            MemoryStream bufferStream = new MemoryStream();
            double sample_l;
            short sl;
            for (int i = 0; i < sampleCount; i++)
            {
                sample_l = sampleData[i] * 30000.0;
                if (sample_l < -32767.0f) { sample_l = -32767.0f; }
                if (sample_l > 32767.0f) { sample_l = 32767.0f; }
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

        public void BufferedPlay(double[] sampleData, long sampleCount, int samplesPerSecond)
        {
            MemoryStream stream = new MemoryStream();
            MemoryStream bufferStream = new MemoryStream();
            double sample_l;
            short sl;
            for (int i = 0; i < sampleCount; i++)
            {
                sample_l = sampleData[i] * 30000.0;
                if (sample_l < -32767.0f) { sample_l = -32767.0f; }
                if (sample_l > 32767.0f) { sample_l = 32767.0f; }
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

        public void ProcessingBuffer()
        {
            
        }
    }
}
