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
using System.IO;

namespace Scattering_Experiment
{

    
    public partial class acquireFrm : Form
    {
        string stageData = "";
        string basePath="";
        Color pnlColor;
        bool ismoving = true;
        bool acquire = true;
        string err = "";

        Newport.ConexAGPCmdLib.ConexAGPCmds conex;
        public acquireFrm()
        {
            InitializeComponent();

        }
        void moveStage(int steps)
        { 
            commStage.sendSerial(steps.ToString());
            int currentPos= int.Parse(Properties.Settings.Default.pos) + steps;
            Properties.Settings.Default.pos = currentPos.ToString();
            Properties.Settings.Default.Save();
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

            // Plot
            PlotChart(dataName);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            //basePath = folderBrowserDialog1.SelectedPath.ToString();
            basePath = getFolderName();
            basePath = basePath.Replace("\\", "/");
            txtBxsavePath.Text = basePath;
        }

        private void btnStartAcq_Click(object sender, EventArgs e)
        {
            acquireData();
            Application.DoEvents();
            MessageBox.Show("Done");
        }


        // ****************************************** Capture *****************************
        public void captureImage(String camName, string imageName)
        {
            if (camName.Equals("CAM1")){
                spinView cam = new spinView("22175210");
                string imagePath = imageName;
                int result = cam.RunSingleCamera(imagePath);
                picBx1.Image = cam.currentImage;
                picBx1.Refresh();
                resizePicBox(picBx1);
            }
            if (camName.Equals("CAM2"))
            {
                spinView cam = new spinView("17197493");
                string imagePath = imageName;
                int result = cam.RunSingleCamera(imagePath);
                picBx2.Image = cam.currentImage;
                picBx2.Refresh();
                resizePicBox(picBx2);
            }

            //spinView cam = new spinView("22175210");
            //spinView cam = new spinView("17197493");
            
            
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

            

            int N = 0;

            acquire = true;

            dx = Math.Abs(dx);
            if (dx > 0)
                N = Math.Abs(xf - x0) / dx;
            else
                N = 0;

            if ((xf - x0) > 0)
                dx = -dx;

            


            int n = 0;
            while(n<=N)
            {
                Application.DoEvents();
                int x = x0 - n * dx;

                // Move Stage
                moveTo(x);
                sleep(2000);

                string pos = "";
                string savepathBase = "";
                string savePathSpectrum = "";
                string spectrumName = "";
                string savePathCam1 = "";
                string imageName1 = "";
                string savePathCam2 = "";
                string imageName2 = "";

                if (chkBxAcqConex.CheckState == CheckState.Checked)
                {
                    double theta0 = double.Parse(txtBxConexFrom.Text);
                    double thetaf = double.Parse(txtBxConexTo.Text);
                    double dtheta = double.Parse(txtBxConexStep.Text);

                    if (thetaf < theta0)
                        dtheta = -1 * Math.Abs(dtheta);
                    else
                        dtheta = Math.Abs(dtheta);
                    if (dtheta < 0)
                    {
                        MessageBox.Show("Ensure theta step > 0");
                        break;
                    }
                    else
                    {
                        double theta = theta0;
                        while (theta <= thetaf)
                        {
                            Application.DoEvents();
                            conexMoveAbs(theta);

                            pos = txtBxCurrent.Text;
                            savepathBase = txtBxsavePath.Text + "/";


                            savePathSpectrum = savepathBase + "Spectrum/";
                            if (!Directory.Exists(savePathSpectrum))
                                Directory.CreateDirectory(savePathSpectrum);
                            spectrumName = savePathSpectrum + "Pos" +x.ToString() +"_Pol"+ theta.ToString()+".csv";
                            saveTheSpectrum(spectrumName);


                            savePathCam1 = savepathBase + "Cam1/";
                            if (!Directory.Exists(savePathCam1))
                                Directory.CreateDirectory(savePathCam1);
                            imageName1 = savePathCam1 + "Pos"  + x.ToString()+ "_Pol" + theta.ToString()+"_CAM1.bmp";
                            captureImage("CAM1", imageName1);


                            savePathCam2 = savepathBase + "Cam2/";
                            if (!Directory.Exists(savePathCam2))
                                Directory.CreateDirectory(savePathCam2);
                            imageName2 = savePathCam2 + "Pos" + x.ToString() + "_Pol" + theta.ToString()+ "_CAM2.bmp";
                            captureImage("CAM2", imageName2);


                            theta = theta + dtheta;
                            if (!acquire)
                                break;
                        }
                    }
                }
                else
                {

                    pos = txtBxCurrent.Text;
                    savepathBase = txtBxsavePath.Text + "/";


                    savePathSpectrum = savepathBase + "Spectrum/";
                    if (!Directory.Exists(savePathSpectrum))
                        Directory.CreateDirectory(savePathSpectrum);
                    spectrumName = savePathSpectrum + x.ToString() + ".csv";
                    saveTheSpectrum(spectrumName);


                    savePathCam1 = savepathBase + "Cam1/";
                    if (!Directory.Exists(savePathCam1))
                        Directory.CreateDirectory(savePathCam1);
                    imageName1 = savePathCam1 + x.ToString() + "_CAM1.bmp";
                    captureImage("CAM1", imageName1);


                    savePathCam2 = savepathBase + "Cam2/";
                    if (!Directory.Exists(savePathCam2))
                        Directory.CreateDirectory(savePathCam2);
                    imageName2 = savePathCam2 + x.ToString() + "_CAM2.bmp";
                    captureImage("CAM2", imageName2);

                }
                n = n + 1;
                Application.DoEvents();
                if (acquire == false)
                    break;
            }

        }

        private void acquireFrm_Load(object sender, EventArgs e)
        {
            commStage.baudrate = 9600;
            txtBxCurrent.Text = Properties.Settings.Default.pos;
            picBx1.ContextMenuStrip = cntxMnPic1;
            picBx2.ContextMenuStrip = cntxMnPic2;

            // Initalize the conex
            conex = new Newport.ConexAGPCmdLib.ConexAGPCmds();
            string[] conexDevices = conex.GetDevices();
            if (conexDevices.Length == 1)
            {
                conex.OpenInstrument(conexDevices[0]);
                // Now home-search
                if (MessageBox.Show("Do you want to Search Home?", "Home Seach", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conexHomeSearch();
                }
                // Update the postion
                txtBxconexCurrentPos.Text = conexGetPosition().ToString();
            }
            else
            {
                MessageBox.Show("No Conex Stage Found!");
                conex.OpenInstrument("COM7");
            }

            // CheckBoxes
            chechChkBoxStage();
        }
        //***************************************************************************************
        //************************ Conex Functions ***********************************************
        //****************************************************************************************

        public void conexHomeSearch()
        {
            string err = "";
            try
            {
                conex.OR(1, out err);
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        public void conexMoveAbs(double target)
        {
            string err = "";
            try
            {
                conex.PA_Set(1, target, out err);
                while (!conexOnTarget())
                {
                    txtBxconexCurrentPos.Text = conexGetPosition().ToString();
                    Application.DoEvents();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }


        public void conexMoveRel(double degrees)
        {
            double current = conexGetPosition();

            double target = current + degrees;
            
            if (target < 0)
            {
                MessageBox.Show("Negative Position Not Allowed");
            }
            else
            {
                conexMoveAbs(target);
            }
        }



        public double conexGetPosition()
        {
            string err = "";
            double pos = 0;
            try
            {
                conex.TP(1, out pos, out err);
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
            return pos;
        }

        public bool conexOnTarget()
        {
            string err = "";
            bool ret = false;

            double target;
            conex.PA_Get(1, out target, out err);

            double current = conexGetPosition();

            if (Math.Abs(current - target) < 0.001)
            {
                ret = true;
            }
            return ret;
        }




        // ********************************************************************************************
        // ***************************** STAGE ******************************************************
        // ********************************************************************************************
        private void btnGo_Click(object sender, EventArgs e)
        {
            int target = int.Parse(txtBxTarget.Text);
            moveTo(target);
        }
        private void moveTo(int target)
        {
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
            captureImage("CAM1", "E:/VB.NEt/Scattering_Experiment/Scattering_Experiment_Second_Part/Images/img_CAM1.bmp");
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
            Bitmap imgOriginal = (Bitmap)p.Image;
            Bitmap bitmap = new Bitmap(imgOriginal, p.Size);
            p.Image = bitmap;
            p.Refresh();
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

        private void picBx2_Click(object sender, EventArgs e)
        {

        }

        private void captureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            captureImage("CAM2", "E:/VB.NEt/Scattering_Experiment/Scattering_Experiment_Second_Part/Images/img_CAM2.bmp");
        }




        // Plotting

        List<Read> rrList = new List<Read>();

        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        public void PlotChart(string filePath)
        {
            Read rr;
            ComboBox xBox = new ComboBox();
            ComboBox yBox = new ComboBox();

            rrList.Clear();
            rr = new Read(filePath);
            rrList.Add(rr);

            if (rrList.Count > 0)
            {
                string[] header = rrList[0].header; //header of first file
                xBox.DataSource = header;
                yBox.DataSource = header.Clone(); //without Clone the 2 comboboxes link together!
            }
            if (yBox.Items.Count > 1) yBox.SelectedIndex = 1; //select second item

            Plot.Draw(rrList, xBox, yBox, chart1);
        }
        private void btnPlot_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ff = new OpenFileDialog();
            //Read rr;

            //ff.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //"C:\\";
            //ff.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            //ff.Multiselect = true;
            //ff.FilterIndex = 1;
            //ff.RestoreDirectory = true;
            //ComboBox xBox = new ComboBox();
            //ComboBox yBox = new ComboBox();
            //if (ff.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        rrList.Clear();
            //        foreach (String file in ff.FileNames) //if ((myStream = ff.OpenFile()) != null)
            //        {
            //            rr = new Read(file);
            //            rrList.Add(rr);
            //        }

            //        //Populate the ComboBoxes
            //        if (rrList.Count > 0)
            //        {
            //            string[] header = rrList[0].header; //header of first file
            //            xBox.DataSource = header;
            //            yBox.DataSource = header.Clone(); //without Clone the 2 comboboxes link together!
            //        }
            //        if (yBox.Items.Count > 1) yBox.SelectedIndex = 1; //select second item
            //    }
            //    catch (Exception err)
            //    {
            //        //Inform the user if we can't read the file
            //        MessageBox.Show(err.Message);
            //    }
            //}
            //Plot.Draw(rrList, xBox, yBox, chart1);
            PlotChart("E:/VB.NEt/Scattering_Experiment/Scattering_Experiment_Second_Part/Images/-4500.csv");
        }


        public string getFolderName()
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            string folderPath = txtBxsavePath.Text;
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                    folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    // ...
            }
            return folderPath;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            acquire = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            conexHomeSearch();
        }

        private void btnConexMoveAbs_Click(object sender, EventArgs e)
        {
            double target = double.Parse(txtBxconexTarget.Text);
            conexMoveAbs(target);
        }

        private void acquireFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conex.CloseInstrument();
            }
            catch (Exception)
            {
            }
        }

        private void btnConexMoveRel_Click(object sender, EventArgs e)
        {
            double degrees = double.Parse(txtBxconexRelative.Text);
            conexMoveRel(degrees);
        }

        private void chkBxAcqureStage_CheckedChanged(object sender, EventArgs e)
        {
            chechChkBoxStage();
        }
        private void chechChkBoxStage()
        {
            if (chkBxAcqureStage.CheckState == CheckState.Unchecked)
            {
                txtBxStep.Text = "0";
                txtBxStep.Enabled = false;
            }
            else
                txtBxStep.Enabled = true;
        }

    }

}
