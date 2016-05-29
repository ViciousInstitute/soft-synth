using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth2504
{
    class Program
    {
        static void Main(string[] args)
        {

            //Wave wave = new Wave(Wave.Sine);
            //WaveMemoryStream waveStream = new WaveMemoryStream();


            //wave.Frequency = Note.A7;
            //wave.Duration = 5;

            //double[] waveData = wave.GenerateSample();
            //waveStream.SaveIntoStream(waveData, (long)(wave.SampleRate * wave.Duration), wave.SampleRate);
            //int i = 0;
            //while(!Console.KeyAvailable)
            //{
            //    Console.WriteLine(wave.GetNext(i));

            //    i++;
            //}
            MixerTest();
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
    }
}
