using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scattering_Experiment
{
    public partial class contCam : Form
    {
        public contCam()
        {
            InitializeComponent();
        }

        private void contCam_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            spinView cam = new spinView("19060459");//new spinView("22175210"); //"17197493"
            cam.initializeCamera();
            while (true)
            {
                cam.RunSingleCamera();
                Bitmap img = cam.currentImage;
                ThreadHelperClass_PicBox.SetImg(this, this.pictureBox1, img);
                if (backgroundWorker1.CancellationPending)
                {
                    cam.closeAcquisition();
                    break;
                }
                System.Threading.Thread.Sleep(150);
            }
        }

        private void btnInitilize_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                MessageBox.Show(backgroundWorker1.CancellationPending.ToString());
            }
        }
    }
}
