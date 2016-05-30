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

            Wave wave = new Wave(Wave.Sine);
            //WaveMemoryStream waveStream = new WaveMemoryStream();


            wave.Frequency = 1;
            wave.Duration = 1;

            double[] waveData = wave.GenerateSample();
            //waveStream.SaveIntoStream(waveData, (long)(wave.SampleRate * wave.Duration), wave.SampleRate);
            //int i = 0;
            //while(!Console.KeyAvailable)
            //{
            //    Console.WriteLine(wave.GetNext(i));

            //    i++;
            //}
            //MixerTest();
            //foreach (double x in waveData)
            //{
            //    DoubleToFloatTest(x);
            //}

            AlternateWaveGenTest();
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
            SineWaveProvider32 sineWaveProvider = new SineWaveProvider32();
            WaveOut waveOut;
            sineWaveProvider.SetWaveFormat(96000, 2);
            sineWaveProvider.Frequency = 1000f;
            sineWaveProvider.Amplitude = 1.0f;
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
    }
}
