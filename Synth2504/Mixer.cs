using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synth2504
{
    class Mixer
    {
        public double[] Mix(double[] waveOneData, double[] waveTwoData)
        {
            double[] mixBuffer = new double[waveOneData.Length];
            for (int i = 0; i < waveOneData.Length; i++)
            {
                mixBuffer[i] = (waveOneData[i] + waveTwoData[i]) / 2;
            }

            return mixBuffer;
        }
        public double[] Mix(double[] waveOneData, double[] waveTwoData, double[] waveThreeData)
        {
            double[] mixBuffer = new double[waveOneData.Length];
            for (int i = 0; i < waveOneData.Length; i++)
            {
                mixBuffer[i] = (waveOneData[i] + waveTwoData[i] + waveThreeData[i]) / 3;
            }

            return mixBuffer;
        }
        public double[] Mix(double[] waveOneData, double[] waveTwoData, double[] waveThreeData, double[] waveFourData)
        {
            double[] mixBuffer = new double[waveOneData.Length];
            for (int i = 0; i < waveOneData.Length; i++)
            {
                mixBuffer[i] = (waveOneData[i] + waveTwoData[i] + waveThreeData[i] + waveFourData[i]) / 4;
            }

            return mixBuffer;
        }
        public double[] Mix(double[] waveOneData, double[] waveTwoData, double[] waveThreeData, double[] waveFourData, double[] waveFiveData)
        {
            double[] mixBuffer = new double[waveOneData.Length];
            for (int i = 0; i < waveOneData.Length; i++)
            {
                mixBuffer[i] = (waveOneData[i] + waveTwoData[i] + waveThreeData[i] + waveFourData[i] + waveFiveData[i]) / 5;
            }

            return mixBuffer;
        }
       
    }
}
