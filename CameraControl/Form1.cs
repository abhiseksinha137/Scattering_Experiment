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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            spinView cam = new spinView();
            string imagePath = "E:/VB.NEt/Scattering_Experiment/Acquisition_CSharp/Images/AutoImage.bmp";
            int result=cam.RunSingleCamera(imagePath);
            if (result == 1){
                pictureBox1.Image = cam.currentImage;
            }
        }
    }
}
