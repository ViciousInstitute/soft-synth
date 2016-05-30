using System;
using System.Windows.Forms;
using NAudio.Wave;
using Synth2504;

namespace SynthInterface
{
    public partial class Form1 : Form
    {
       static public Wave waveOne;
       static public SineWaveProvider32 sineWaveProvider;
       private WaveOut waveOut;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waveOne = new Wave(Wave.Sine);
            sineWaveProvider = new SineWaveProvider32();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            while(checkBox1.Checked)
            {
                richTextBox1.AppendText(String.Concat(waveOne.GetNext(i).ToString(), "\n"));
                richTextBox1.ScrollToCaret();
                
                i++;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
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
            sineWaveProvider.Frequency = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void StartStopSineWave()
        {
            if (waveOut == null)
            {

                sineWaveProvider.SetWaveFormat(96000, 2);
                sineWaveProvider.Frequency = trackBar1.Value;
                sineWaveProvider.Amplitude = 1.0f;
                waveOut = new WaveOut();
                waveOut.Init(sineWaveProvider);
                waveOut.Play();
            }
            else
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

     
    }

}
