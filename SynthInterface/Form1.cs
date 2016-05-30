using System;
using System.Windows.Forms;
using NAudio.Wave;
using Synth2504;

namespace SynthInterface
{
    public partial class Form1 : Form
    {
       static public Wave waveOne;
       static public Wave sineWaveProvider;
       private WaveOut waveOut;
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void StartStopSineWave()
        {
            if (waveOut == null)
            {
                waveOne.Frequency = trackBar1.Value;
                waveOut = new WaveOut();
                waveOut.Init(waveOne);
                waveOut.Play();
            }
            else
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waveOne = new Wave(Wave.Sine);
           
            waveOne.Frequency = 1;
            waveOne.Duration = 1;
        
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            waveOne.SetFunction(Wave.Sine);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            waveOne.SetFunction(Wave.Sawtooth);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            waveOne.SetFunction(Wave.Square);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            waveOne.SetFunction(Wave.PSquare);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartStopSineWave();
          
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            waveOne.Frequency = trackBar1.Value;
        }

       
    }

}
