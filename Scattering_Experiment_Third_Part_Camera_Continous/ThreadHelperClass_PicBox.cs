using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scattering_Experiment
{
    class ThreadHelperClass_PicBox
    {
        delegate void SetTextCallback(Form f, PictureBox ctrl, Bitmap img );
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetImg(Form form, PictureBox ctrl, Bitmap img)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetImg);
                form.Invoke(d, new object[] { form, ctrl, img });
            }
            else
            {
                ctrl.Image = img;
            }
        }
    }
}
