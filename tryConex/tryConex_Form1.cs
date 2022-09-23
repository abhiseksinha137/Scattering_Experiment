using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tryConex
{
    public partial class tryConex_Form1 : Form
    {
        Newport.ConexAGPCmdLib.ConexAGPCmds conex;
        public tryConex_Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             conex = new Newport.ConexAGPCmdLib.ConexAGPCmds();
        }

        private void btnGetDevices_Click(object sender, EventArgs e)
        {
            string[] devices = conex.GetDevices();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conex.CloseInstrument();
        }

        private void btnGetID_Click(object sender, EventArgs e)
        {
            string ret = "";
            string err="";
            try
            {
                conex.ID_Get(1, out ret, out err);
                addText(ret);
            }
            catch (Exception)
            {

                addText(err);
            }

            
        }
        public void addText(string text)
        {
            textBox1.Text= textBox1.Text + text + Environment.NewLine;
        }

        private void btnHomeSearch_Click(object sender, EventArgs e)
        {
            homeSearch();
        }
        

        public void homeSearch()
        {
            string err = "";
            try
            {
                conex.OR(1, out err);
            }
            catch (Exception)
            {
                addText(err);
            }
        }

        private void btnMoveAbs_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtBxMove.Text);
            moveAbs(pos);
        }
        public void moveAbs(int target)
        {
            string err = "";
            try
            {
                conex.PA_Set(1, target, out err);
            }
            catch (Exception)
            {
                addText(err);
            }
        }

        public void moveRelative(int target)
        {
            
        }


        private void btnGetPos_Click(object sender, EventArgs e)
        {
            getPosition();
        }
        public void getPosition()
        {
            string err = "";
            double pos = 0;
            try
            {
                conex.TP(1, out pos, out err);
                addText(pos.ToString());
            }
            catch (Exception)
            {
                addText(err);
                throw;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            try
            {
                conex.CloseInstrument();
                conex.OpenInstrument(item);
            }
            catch (Exception)
            {

            }
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string[]devices=conex.GetDevices();
            comboBox1.Items.Clear();
            foreach (string element in devices)
            {
                comboBox1.Items.Add(element);
            }
        }

        
    }


}