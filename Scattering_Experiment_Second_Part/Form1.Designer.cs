namespace Scattering_Experiment
{
    partial class acquireFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStartAcq = new System.Windows.Forms.Button();
            this.txtBxsavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxTarget = new System.Windows.Forms.TextBox();
            this.txtBxCurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBxFrom = new System.Windows.Forms.TextBox();
            this.txtBxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTare = new System.Windows.Forms.Button();
            this.pnlMotionIndicator = new System.Windows.Forms.Panel();
            this.btnMoveRel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxMoveRel = new System.Windows.Forms.TextBox();
            this.txtBxStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.commStage = new customControl.comboSerial();
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.picBx2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cntxMnPic1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.cntxMnPic1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartAcq
            // 
            this.btnStartAcq.Location = new System.Drawing.Point(147, 140);
            this.btnStartAcq.Name = "btnStartAcq";
            this.btnStartAcq.Size = new System.Drawing.Size(133, 37);
            this.btnStartAcq.TabIndex = 0;
            this.btnStartAcq.Text = "Start Acquisition";
            this.btnStartAcq.UseVisualStyleBackColor = true;
            this.btnStartAcq.Click += new System.EventHandler(this.btnStartAcq_Click);
            // 
            // txtBxsavePath
            // 
            this.txtBxsavePath.Location = new System.Drawing.Point(66, 77);
            this.txtBxsavePath.Name = "txtBxsavePath";
            this.txtBxsavePath.Size = new System.Drawing.Size(274, 20);
            this.txtBxsavePath.TabIndex = 1;
            this.txtBxsavePath.Text = "E:/ScatteringExpt/20220912/Tip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save Path";
            // 
            // txtBxTarget
            // 
            this.txtBxTarget.Location = new System.Drawing.Point(72, 8);
            this.txtBxTarget.Name = "txtBxTarget";
            this.txtBxTarget.Size = new System.Drawing.Size(75, 20);
            this.txtBxTarget.TabIndex = 3;
            this.txtBxTarget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTarget_KeyDown);
            this.txtBxTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxTarget_KeyPress);
            // 
            // txtBxCurrent
            // 
            this.txtBxCurrent.Enabled = false;
            this.txtBxCurrent.Location = new System.Drawing.Point(259, 10);
            this.txtBxCurrent.Name = "txtBxCurrent";
            this.txtBxCurrent.Size = new System.Drawing.Size(75, 20);
            this.txtBxCurrent.TabIndex = 4;
            this.txtBxCurrent.TextChanged += new System.EventHandler(this.txtBxCurrent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(153, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 26);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(343, 74);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 24);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBxFrom
            // 
            this.txtBxFrom.Location = new System.Drawing.Point(67, 103);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.Size = new System.Drawing.Size(75, 20);
            this.txtBxFrom.TabIndex = 9;
            // 
            // txtBxTo
            // 
            this.txtBxTo.Location = new System.Drawing.Point(181, 103);
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(75, 20);
            this.txtBxTo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnTare);
            this.panel1.Controls.Add(this.pnlMotionIndicator);
            this.panel1.Controls.Add(this.btnMoveRel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBxMoveRel);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.txtBxTarget);
            this.panel1.Controls.Add(this.txtBxCurrent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(6, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 64);
            this.panel1.TabIndex = 13;
            // 
            // btnTare
            // 
            this.btnTare.Location = new System.Drawing.Point(259, 39);
            this.btnTare.Name = "btnTare";
            this.btnTare.Size = new System.Drawing.Size(75, 23);
            this.btnTare.TabIndex = 18;
            this.btnTare.Text = "Tare";
            this.btnTare.UseVisualStyleBackColor = true;
            this.btnTare.Click += new System.EventHandler(this.btnTare_Click);
            // 
            // pnlMotionIndicator
            // 
            this.pnlMotionIndicator.BackColor = System.Drawing.Color.Lime;
            this.pnlMotionIndicator.Location = new System.Drawing.Point(377, 45);
            this.pnlMotionIndicator.Name = "pnlMotionIndicator";
            this.pnlMotionIndicator.Size = new System.Drawing.Size(17, 16);
            this.pnlMotionIndicator.TabIndex = 17;
            this.pnlMotionIndicator.BackColorChanged += new System.EventHandler(this.pnlMotionIndicator_BackColorChanged);
            // 
            // btnMoveRel
            // 
            this.btnMoveRel.Location = new System.Drawing.Point(155, 35);
            this.btnMoveRel.Name = "btnMoveRel";
            this.btnMoveRel.Size = new System.Drawing.Size(45, 26);
            this.btnMoveRel.TabIndex = 10;
            this.btnMoveRel.Text = "Move";
            this.btnMoveRel.UseVisualStyleBackColor = true;
            this.btnMoveRel.Click += new System.EventHandler(this.btnMoveRel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Relative";
            // 
            // txtBxMoveRel
            // 
            this.txtBxMoveRel.Location = new System.Drawing.Point(72, 39);
            this.txtBxMoveRel.Name = "txtBxMoveRel";
            this.txtBxMoveRel.Size = new System.Drawing.Size(75, 20);
            this.txtBxMoveRel.TabIndex = 8;
            this.txtBxMoveRel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxMoveRel_KeyDown);
            // 
            // txtBxStep
            // 
            this.txtBxStep.Location = new System.Drawing.Point(317, 103);
            this.txtBxStep.Name = "txtBxStep";
            this.txtBxStep.Size = new System.Drawing.Size(75, 20);
            this.txtBxStep.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Step";
            // 
            // commStage
            // 
            this.commStage.Location = new System.Drawing.Point(6, 5);
            this.commStage.Name = "commStage";
            this.commStage.Size = new System.Drawing.Size(102, 72);
            this.commStage.TabIndex = 16;
            // 
            // picBx1
            // 
            this.picBx1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picBx1.Location = new System.Drawing.Point(431, 5);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(410, 268);
            this.picBx1.TabIndex = 17;
            this.picBx1.TabStop = false;
            this.picBx1.BackgroundImageChanged += new System.EventHandler(this.picBx1_BackgroundImageChanged);
            this.picBx1.Click += new System.EventHandler(this.picBx1_Click);
            // 
            // picBx2
            // 
            this.picBx2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picBx2.Location = new System.Drawing.Point(431, 279);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(410, 242);
            this.picBx2.TabIndex = 18;
            this.picBx2.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 279);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(419, 242);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // cntxMnPic1
            // 
            this.cntxMnPic1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem});
            this.cntxMnPic1.Name = "cntxMnPic1";
            this.cntxMnPic1.Size = new System.Drawing.Size(117, 26);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
            // 
            // acquireFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 533);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.picBx2);
            this.Controls.Add(this.picBx1);
            this.Controls.Add(this.commStage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxStep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxTo);
            this.Controls.Add(this.txtBxFrom);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxsavePath);
            this.Controls.Add(this.btnStartAcq);
            this.Name = "acquireFrm";
            this.Text = "Acquire Data";
            this.Load += new System.EventHandler(this.acquireFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.cntxMnPic1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartAcq;
        private System.Windows.Forms.TextBox txtBxsavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxTarget;
        private System.Windows.Forms.TextBox txtBxCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBxFrom;
        private System.Windows.Forms.TextBox txtBxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBxStep;
        private System.Windows.Forms.Label label6;
        private customControl.comboSerial commStage;
        private System.Windows.Forms.Button btnMoveRel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxMoveRel;
        private System.Windows.Forms.Panel pnlMotionIndicator;
        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.PictureBox picBx2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnTare;
        private System.Windows.Forms.ContextMenuStrip cntxMnPic1;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
    }
}

