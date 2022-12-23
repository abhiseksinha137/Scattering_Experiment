namespace Scattering_Experiment
{
    partial class contCam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAcquire = new System.Windows.Forms.Button();
            this.btnInitilize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(186, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAcquire
            // 
            this.btnAcquire.Location = new System.Drawing.Point(105, 7);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(75, 23);
            this.btnAcquire.TabIndex = 6;
            this.btnAcquire.Text = "Acquire";
            this.btnAcquire.UseVisualStyleBackColor = true;
            // 
            // btnInitilize
            // 
            this.btnInitilize.Location = new System.Drawing.Point(12, 7);
            this.btnInitilize.Name = "btnInitilize";
            this.btnInitilize.Size = new System.Drawing.Size(75, 23);
            this.btnInitilize.TabIndex = 5;
            this.btnInitilize.Text = "Initilize";
            this.btnInitilize.UseVisualStyleBackColor = true;
            this.btnInitilize.Click += new System.EventHandler(this.btnInitilize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 333);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // contCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 392);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAcquire);
            this.Controls.Add(this.btnInitilize);
            this.Controls.Add(this.pictureBox1);
            this.Name = "contCam";
            this.Text = "contCam";
            this.Load += new System.EventHandler(this.contCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAcquire;
        private System.Windows.Forms.Button btnInitilize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}