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
            //int sampleRate = 96000;
            //int duration = 1;

            //DataFileOutput logger1 = new DataFileOutput();

            //Wave wave = new Wave(Wave.Sine);
            //wave.Frequency = 1;

            //List<double> waveBuffer = new List<double>();

            //for (int i = 0; i < (wave.Duration / 2) * wave.SampleRate; i++)
            //{
            //   waveBuffer.Add(wave.GetNext(i));
            //}
            //wave.SetFunction(Wave.Sawtooth);
            ////9wave.Phase = 180;

            //for (int i = 0; i < (wave.Duration / 2) * wave.SampleRate; i++)
            //{
            //    waveBuffer.Add(wave.GetNext(i));
            //}


            ////double[] wave1Data = wave.GenerateSample();
            ////wave.SetFunction(Wave.PSquare);
            ////wave.Phase = 180;
            ////double[] wave2Data = wave.GenerateSample();
            ////logger1.OutputCSV(wave1Data, wave2Data, "PhaseData");
            //double[] WaveformChangeTest = waveBuffer.ToArray();
            //logger1.OutputCSV(WaveformChangeTest, "WaveformChangeData");


            Wave wave = new Wave(Wave.Square);
            wave.Frequency = 440;
            int i = 0;
            while(!Console.KeyAvailable)
            {
                Console.WriteLine(wave.GetNext(i));
                
                i++;
            }

            Console.ReadLine();

        }
    }
}
