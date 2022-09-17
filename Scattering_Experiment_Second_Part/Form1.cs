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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Scattering_Experiment
{

    
    public partial class acquireFrm : Form
    {
        string stageData = "";
        string basePath="";
        Color pnlColor;
        bool ismoving = true;
        public acquireFrm()
        {
            InitializeComponent();

        }
        void moveStage(int steps)
        { 
            commStage.sendSerial(steps.ToString());
            int currentPos= int.Parse(Properties.Settings.Default.pos) + steps;
            Properties.Settings.Default.pos = currentPos.ToString();
            txtBxCurrent.Text = Properties.Settings.Default.pos;
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


        // ****************************************** Capture *****************************
        public void captureImage(string imageName)
        {
            //spinView cam = new spinView("22175210");
            spinView cam = new spinView("17197493");
            MessageBox.Show(cam.camSerialNum);
            string imagePath = imageName;
            int result = cam.RunSingleCamera(imagePath);
            picBx1.Image = cam.currentImage;
            picBx1.Refresh();
            resizePicBox(picBx1);
            
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
                //moveStage(x.ToString());
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

        private void acquireFrm_Load(object sender, EventArgs e)
        {
            commStage.baudrate = 9600;
            txtBxCurrent.Text = Properties.Settings.Default.pos;
            picBx1.ContextMenuStrip = cntxMnPic1;
        }

       

        private void btnGo_Click(object sender, EventArgs e)
        {
            int target = int.Parse(txtBxTarget.Text);
            int current = int.Parse(txtBxCurrent.Text);
            int steps = target - current;
            moveStage(steps);
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
            int current = int.Parse(txtBxCurrent.Text);
            int rel = int.Parse(txtBxMoveRel.Text);
            moveStage(rel);

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
            //label8.Text = ismoving.ToString();
        }

        private void btnTare_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pos = "0";
            txtBxCurrent.Text = Properties.Settings.Default.pos;
        }

        private void cntxMnPic1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captureImage("E:/VB.NEt/Scattering_Experiment/Scattering_Experiment_Second_Part/Images/img1.bmp");
        }

        void captureImg1()
        {

        }

        private void picBx1_Click(object sender, EventArgs e)
        {

        }

        private void picBx1_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }

        public void resizePicBox(PictureBox p)
        {
            //Image imgOriginal = p.Image;
            //Image dummy = imgOriginal;
            //int ho = imgOriginal.Height;
            //int wo = imgOriginal.Width;

            //int hp = picBx1.Height;
            //int wp = picBx1.Width;

            //double r = (double)wp / (double)wo;
            //double newh = ho * r;
            //double neww = wo * r;
            //Size s = new Size((int)newh, (int)neww);
            //dummy = (Image)(new Bitmap(dummy, s));
            //p.Image = dummy;
            //p.Refresh();
            //MessageBox.Show(r.ToString());
        }


        // Image Contol


    }

}
