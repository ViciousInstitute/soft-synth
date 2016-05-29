#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Synth2504
{
    class DataFileOutput
    {
        /// <summary>
        /// Started: 3 MAY 2016
        /// Intended for use in other projects.
        /// Can write strings to txt or csv.
        /// </summary>
        protected string _filePath;
        protected string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public DataFileOutput()
        {
            string _projectDirectory = System.IO.Directory.GetCurrentDirectory();
            string _logDirectory = _projectDirectory + "\\Logs\\";
            if (!System.IO.Directory.Exists(_logDirectory))
            {
                System.IO.Directory.CreateDirectory(_logDirectory);
                _filePath = _logDirectory;
#if DEBUG
                Console.WriteLine("{0} successfully created.", _logDirectory);
#endif

            }
            else
            {
                _filePath = _logDirectory;
            }
        }
        public DataFileOutput(string fileName)
        {

            _fileName = fileName;
            string _projectDirectory = System.IO.Directory.GetCurrentDirectory();
            string _logDirectory = _projectDirectory + "\\Logs\\";
            if (!System.IO.Directory.Exists(_logDirectory))
            {
                System.IO.Directory.CreateDirectory(_logDirectory);
                _filePath = _logDirectory;
#if DEBUG
                Console.WriteLine("{0} successfully created.", _logDirectory);
#endif

            }
            else
            {
                _filePath = _logDirectory;
                //#if DEBUG
                //                Console.WriteLine("{0} already exists.", _logDirectory);

                //#endif
            }
        }       //constructor 

        public void OutputCSV(double[] waveOneData, string fileName)
        {
            StringBuilder csv = new StringBuilder();
            _fileName = fileName;
            foreach (double sample in waveOneData)
            {
                string dataPoint = sample.ToString();
                string newLine = string.Format("{0},", dataPoint);
                csv.AppendLine(newLine);
            }
            try
            {
                File.WriteAllText(_filePath + _fileName + ".csv", csv.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void OutputCSV(double[] waveOneData, string fileName, bool textOutput)
        {
            StringBuilder csv = new StringBuilder();
            _fileName = fileName;
            foreach (double sample in waveOneData)
            {
                string dataPoint = sample.ToString();
                string newLine = string.Format("{0},", dataPoint);
                csv.AppendLine(newLine);
            }
            try
            {
                if (!textOutput)
                    File.WriteAllText(_filePath + _fileName + ".csv", csv.ToString());
                else
                    File.WriteAllText(_filePath + _fileName + ".txt", csv.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void OutputCSV(double[] waveOneData, double[] waveTwoData, string fileName)
        {
            StringBuilder csv = new StringBuilder();
            _fileName = fileName;
            for (int i = 0; i < waveOneData.Length; i++)
            {
                string newLine = string.Format("{0},{1}", waveOneData[i].ToString(), waveTwoData[i].ToString());
                csv.AppendLine(newLine);
            }
            try
            {
                File.WriteAllText(_filePath + _fileName + ".csv", csv.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void OutputCSV(double[] waveOneData, double[] waveTwoData, double[] waveThreeData, string fileName)
        {
            StringBuilder csv = new StringBuilder();
            _fileName = fileName;
            for (int i = 0; i < waveOneData.Length; i++)
            {
                string newLine = string.Format("{0},{1},{2}", waveOneData[i].ToString(), waveTwoData[i].ToString(),
                    waveThreeData[i].ToString());
                csv.AppendLine(newLine);
            }
            try
            {
                File.WriteAllText(_filePath + _fileName + ".csv", csv.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void OutputCSV(int[] dataTable, string fileName)
        {
            StringBuilder csv = new StringBuilder();
            _fileName = fileName;
            foreach (double sample in dataTable)
            {
                string dataPoint = sample.ToString();
                string newLine = string.Format("{0},", dataPoint);
                csv.AppendLine(newLine);
            }
            try
            {
                File.WriteAllText(_filePath + _fileName + ".csv", csv.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void OutputCSV(double[] waveOneData, int[] dataTableTwo, string fileName)
        {
            StringBuilder csv = new StringBuilder();
            _fileName = fileName;
            for (int i = 0; i < waveOneData.Length; i++)
            {
                string newLine = string.Format("{0},{1}", waveOneData[i].ToString(), dataTableTwo[i].ToString());
                csv.AppendLine(newLine);
            }
            try
            {
                File.WriteAllText(_filePath + _fileName + ".csv", csv.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
