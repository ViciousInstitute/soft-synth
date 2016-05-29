using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth2504
{
    public partial class Wave
    {


        private const double _tau = Math.PI * 2;
        private double _phase;
        private double _frequency;
        private int _sampleRate;
        private double _duration;
        private double _amplitude;
        private WaveFunction _waveFunction;

        public delegate double WaveFunction(double x);

        public static WaveFunction Clock = new WaveFunction(ClockOutput);
        public static WaveFunction Sine = new WaveFunction(SineWave);
        public static WaveFunction Sawtooth = new WaveFunction(SawtoothWave);
        public static WaveFunction Square = new WaveFunction(SquareWave);
        public static WaveFunction PSquare = new WaveFunction(PseudoSquareWave);

        


        /// <summary>
        /// This is the repeating input fed into the various functions to generate 
        /// the desired waveforms. It generates _sampleRate number of steps
        /// from between 0 and 1. This is fed into the various equations to 
        /// generate desired waveforms.
        /// </summary>

        public Wave(WaveFunction f)
        {
            _waveFunction = f;
            _duration = 1;
            _sampleRate = 96000;
            _frequency = 1;
            _phase = 0;
            _amplitude = 1;
        }

        //Properties
       
        public double Phase
        {
            get { return _phase; }
            set { _phase = value; }
        }
        public double Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        public double Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public int SampleRate
        {
            get { return _sampleRate; }
            set { _sampleRate = value; }
        }
       

        public double Amplitude
        {
            get { return _amplitude; }
            set { _amplitude = value; }
        }




        public double GetNext(long sampleIndex)
        {
            double samplesPerCycle = (_sampleRate / _frequency);
            double phase = (_phase / 360) * samplesPerCycle;
            double cycleIndex = (sampleIndex + phase) % samplesPerCycle;
            double depthIntoCycle = cycleIndex / samplesPerCycle;
            double nextSample = _waveFunction(depthIntoCycle);
            return nextSample * _amplitude;
        }

        public double[] GenerateSample()
        {
            List<double> data = new List<double>();
            for (int i = 0; i < _sampleRate * _duration; i++)
            {
                data.Add(GetNext(i));
            }
            double[] waveBuffer = data.ToArray();
            return waveBuffer;
        }

        public void SetFunction(WaveFunction f)
        {
            _waveFunction = f;
        }


        #region Wave Functions
        public static double ClockOutput(double x)
        {
            return x;
        }
        public static double SineWave(double x)
        {

            return Math.Sin(x * _tau);
        }
        public static double SquareWave(double x)
        {

            if (x > 0.5)
            {
                return 1;

            }
            else if (x < 0.5)
            {
                return -1;

            }
            else
                return 0;
        }
        public static double SawtoothWave(double x)
        {
            x =  (2 * x) - 1;
            return x;

        }
        public static double PseudoSquareWave(double x)
        {
            double result = Math.Sin(x * _tau);
            if (x > 0.5)
            {

                result += 0.5;
            }
            else
            {

                result -= 0.5;
            }

            return result * 2;
        }
        #endregion


    }
}
