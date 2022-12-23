using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customControl;
using System.Threading;
using System.Diagnostics;

namespace Scattering_Experiment
{

    
    public partial class acquireFrm : Form
    {
        string stageData = "";
        string basePath="";
        string currentVal = "1234567890";
        Color pnlColor;
        bool ismoving = true;
        public acquireFrm()
        {
            InitializeComponent();
        }

       
        public void saveTheSpectrum(string dataName)
        {
            //saveSpectrum spectrometer = new saveSpectrum();
            //spectrometer.runPythonScript("E:/python/Spectrometer/Final/spectroRead.py", "E:/python/Spectrometer/Final/new.csv");
            var cmd = "E:/python/Spectrometer/Final/spectroRead.py";// "E:/python/Spectrometer/sample.py";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:/Users/abhisek/AppData/Local/Programs/Python/Python310/python.exe",
                    Arguments = string.Format("{0} {1}", cmd, dataName),
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = true
                },

            };

            process.Start();
            process.WaitForExit();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            basePath = folderBrowserDialog1.SelectedPath.ToString();
            basePath=basePath.Replace("\\", "/");
            txtBxsavePath.Text = basePath;
        }

        private void btnStartAcq_Click(object sender, EventArgs e)
        {
            acquireData();
            MessageBox.Show("Done");
        }

        public void captureImage(string imageName)
        {
            spinView cam = new spinView();
            string imagePath = imageName;
            int result = cam.RunSingleCamera(imagePath);
            
        }
        
        void sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }
        public void acquireData()
        {
            int x0 = int.Parse(txtBxFrom.Text);
            int xf = int.Parse(txtBxTo.Text);
            int dx = int.Parse(txtBxStep.Text);

            int x = x0;
            while(x>= xf)
            {
                Application.DoEvents();
                moveStage(x.ToString());
                sleep(1000);
                //while (Math.Abs(int.Parse(txtBxCurrent.Text) - x) > 200)
                //{
                //    lblStatus.Text = "Looping";
                //    Application.DoEvents();
                //    continue;
                //}
                while (ismoving && (Math.Abs(int.Parse(txtBxCurrent.Text) - x) > 100))
                {
                    Application.DoEvents();
                    continue;
                }
                sleep(5000);
                Application.DoEvents();

                string pos = txtBxCurrent.Text;
                string savepath = txtBxsavePath.Text+"/";

                string spectrumName = savepath + x.ToString() + ".csv";
                saveTheSpectrum(spectrumName);


                string imageName = savepath + x.ToString() + ".bmp";
                captureImage(imageName);


                x = x + dx;
            }

        }
        public void moveStage(string Target)
        {
            commStage.sendSerial(Target);
        }

        private void acquireFrm_Load(object sender, EventArgs e)
        {
            commStage.baudrate = 115200;
            commStage.DataReceived += new customControl.ComboSerialComm(commStage_DataReceived);
        }

        private void commStage_DataReceived()
        {
            string temp = commStage.ReadData();
            if (String.Equals(temp, stageData))
            {
                pnlColor = Color.Lime;
            }
            else
            {
                pnlColor = Color.Red;
            }

            Thread pnlThread = new Thread(new ThreadStart(this.ThreadProcSafeUpdate_IndicatorPanel));
            pnlThread.Start();

            stageData = temp;
            Thread demoThread = new Thread(new ThreadStart(this.ThreadProcSafeUpdateGeiger));
            demoThread.Start();
        }

        private void ThreadProcSafeUpdateGeiger()
        {
            ThreadHelperClass.SetText(this, txtBxCurrent, stageData);
        }

        private void ThreadProcSafeUpdate_IndicatorPanel()
        {
            ThreadHelperClass.SetColor(this, pnlMotionIndicator, pnlColor);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string target = txtBxTarget.Text;
            commStage.sendSerial(target);
        }

        private void txtBxTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBxTarget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
        }

        private void btnMoveRel_Click(object sender, EventArgs e)
        {
            long current = long.Parse(txtBxCurrent.Text);
            long rel = long.Parse(txtBxMoveRel.Text);
            long target = current + rel;

            commStage.sendSerial(target.ToString());

        }

        private void txtBxMoveRel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMoveRel.PerformClick();
            }
        }

        private void txtBxCurrent_TextChanged(object sender, EventArgs e)
        {
            //    string val = txtBxCurrent.Text;
            //    if (String.Equals(currentVal, val))
            //    {
            //        ismoving = false;
            //        pnlMotionIndicator.BackColor = Color.Lime;
            //    }
            //    else
            //    {
            //        ismoving = true;
            //        pnlMotionIndicator.BackColor = Color.Red;
            //    }
            //    currentVal = val;
        }

        private void pnlMotionIndicator_BackColorChanged(object sender, EventArgs e)
        {
            if (pnlMotionIndicator.BackColor == Color.Red)
            {
                ismoving = true;
                
            }
            else
            {
                ismoving = false;
            }
            label8.Text = ismoving.ToString();
        }

        private void pnlMotionIndicator_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
