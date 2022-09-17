using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scattering_Experiment
{
    class saveSpectrum
    {
        public string python = "C:/Users/abhisek/AppData/Local/Programs/Python/Python310/python.exe";
        public saveSpectrum(string pythonPath)
        {
            python = pythonPath;
        }
        public saveSpectrum()
        {
        }
        public void runPythonScript(string scriptName, string saveName)
        {
            var cmd = scriptName;// "E:/python/Spectrometer/sample.py";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = python,
                    Arguments = string.Format("{0} {1}", cmd, saveName),
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = true
                },

            };

            process.Start();
            process.WaitForExit();
        }
    }
}
