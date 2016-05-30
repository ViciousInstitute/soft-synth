using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Synth2504
{
    class Program
    {
        static void Main(string[] args)
        {

 
            AlternateWaveGenTest();
            //FloatDataArray();
            Console.WriteLine("Program complete. Press enter.");
            Console.ReadLine();

        }


        public static void MixerTest()
        {
            DataFileOutput mixLogger = new DataFileOutput();
            Wave waveOne = new Wave(Wave.Square);
            waveOne.Duration = 5;
            waveOne.Frequency = Note.D2;
            Wave waveTwo = new Wave(Wave.Square);
            //waveTwo.Phase = 17;
            waveTwo.Duration = 5;
            waveTwo.Frequency = Note.Fsharp2;
            Wave waveThree = new Wave(Wave.Square);
            waveThree.Duration = 5;
            waveThree.Frequency = Note.A3;
            //Wave waveFour = new Wave(Wave.Sawtooth);
            //waveFour.Duration = 5;
            //waveFour.Frequency = Note.A5;
            //Wave waveFive = new Wave(Wave.Sawtooth);
            //waveFive.Duration = 5;
            //waveFive.Frequency = Note.A6;
            double[] waveOneData = waveOne.GenerateSample();
            double[] waveTwoData = waveTwo.GenerateSample();
            double[] waveThreeData = waveThree.GenerateSample();
            //double[] waveFourData = waveFour.GenerateSample();
            //double[] waveFiveData = waveFive.GenerateSample();
            Mixer mixer = new Mixer();
            double[] mixData = mixer.Mix(waveOneData, waveTwoData, waveThreeData/*, waveFourData, waveFiveData*/);
            mixLogger.OutputCSV(mixData, "mixData");
            WaveMemoryStream mixStream = new WaveMemoryStream();
            mixStream.SaveIntoStream(mixData, mixData.Length, 96000);

        }

        public static void DoubleToByteTest(double d)
        {
           byte[] buffer =  WaveMemoryStream.ByteConverter(d);
            foreach (byte x in buffer)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public static void AlternateWaveGenTest()
        {
            Wave sineWaveProvider = new Wave(Wave.Sine);
            WaveOut waveOut;
            waveOut = new WaveOut();
            waveOut.Init(sineWaveProvider);
            while (!Console.KeyAvailable)
            {
                waveOut.Play();
            }
            waveOut.Stop();
            waveOut.Dispose();
            waveOut = null;

        }

        public static void FloatDataArray()
        {
            Wave wave = new Wave(Wave.Sine);
            DataFileOutput logger = new DataFileOutput();
            wave.Frequency = 1;
            wave.Duration = 1;
            float[] dataArray = new float[wave.SampleRate];
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = wave.GetNext32(i);
            }
            logger.OutputCSV(dataArray, "FloatOutput");
        }
    }
}
