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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cntxMnPic2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.captureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBxconexTarget = new System.Windows.Forms.TextBox();
            this.txtBxconexRelative = new System.Windows.Forms.TextBox();
            this.btnConexMoveAbs = new System.Windows.Forms.Button();
            this.btnConexMoveRel = new System.Windows.Forms.Button();
            this.txtBxconexCurrentPos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkBxAcqureStage = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBxAcqConex = new System.Windows.Forms.CheckBox();
            this.txtBxConexTo = new System.Windows.Forms.TextBox();
            this.txtBxConexFrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBxConexStep = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.cntxMnPic1.SuspendLayout();
            this.cntxMnPic2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartAcq
            // 
            this.btnStartAcq.Location = new System.Drawing.Point(149, 223);
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
            this.txtBxTarget.Location = new System.Drawing.Point(72, 16);
            this.txtBxTarget.Name = "txtBxTarget";
            this.txtBxTarget.Size = new System.Drawing.Size(75, 20);
            this.txtBxTarget.TabIndex = 3;
            this.txtBxTarget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTarget_KeyDown);
            this.txtBxTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxTarget_KeyPress);
            // 
            // txtBxCurrent
            // 
            this.txtBxCurrent.Enabled = false;
            this.txtBxCurrent.Location = new System.Drawing.Point(259, 18);
            this.txtBxCurrent.Name = "txtBxCurrent";
            this.txtBxCurrent.Size = new System.Drawing.Size(75, 20);
            this.txtBxCurrent.TabIndex = 4;
            this.txtBxCurrent.TextChanged += new System.EventHandler(this.txtBxCurrent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(153, 12);
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
            this.txtBxFrom.Location = new System.Drawing.Point(54, 18);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.Size = new System.Drawing.Size(75, 20);
            this.txtBxFrom.TabIndex = 9;
            // 
            // txtBxTo
            // 
            this.txtBxTo.Location = new System.Drawing.Point(168, 18);
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(75, 20);
            this.txtBxTo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label13);
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
            this.panel1.Location = new System.Drawing.Point(6, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 80);
            this.panel1.TabIndex = 13;
            // 
            // btnTare
            // 
            this.btnTare.Location = new System.Drawing.Point(259, 47);
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
            this.pnlMotionIndicator.Location = new System.Drawing.Point(377, 53);
            this.pnlMotionIndicator.Name = "pnlMotionIndicator";
            this.pnlMotionIndicator.Size = new System.Drawing.Size(17, 16);
            this.pnlMotionIndicator.TabIndex = 17;
            this.pnlMotionIndicator.BackColorChanged += new System.EventHandler(this.pnlMotionIndicator_BackColorChanged);
            // 
            // btnMoveRel
            // 
            this.btnMoveRel.Location = new System.Drawing.Point(155, 43);
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
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Relative";
            // 
            // txtBxMoveRel
            // 
            this.txtBxMoveRel.Location = new System.Drawing.Point(72, 47);
            this.txtBxMoveRel.Name = "txtBxMoveRel";
            this.txtBxMoveRel.Size = new System.Drawing.Size(75, 20);
            this.txtBxMoveRel.TabIndex = 8;
            this.txtBxMoveRel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxMoveRel_KeyDown);
            // 
            // txtBxStep
            // 
            this.txtBxStep.Location = new System.Drawing.Point(304, 18);
            this.txtBxStep.Name = "txtBxStep";
            this.txtBxStep.Size = new System.Drawing.Size(75, 20);
            this.txtBxStep.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 21);
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
            this.picBx1.Location = new System.Drawing.Point(462, 19);
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
            this.picBx2.Location = new System.Drawing.Point(431, 314);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(480, 372);
            this.picBx2.TabIndex = 18;
            this.picBx2.TabStop = false;
            this.picBx2.Click += new System.EventHandler(this.picBx2_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(6, 495);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(419, 191);
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
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "CAM1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(409, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "CAM2";
            // 
            // cntxMnPic2
            // 
            this.cntxMnPic2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem1});
            this.cntxMnPic2.Name = "cntxMnPic2";
            this.cntxMnPic2.Size = new System.Drawing.Size(117, 26);
            // 
            // captureToolStripMenuItem1
            // 
            this.captureToolStripMenuItem1.Name = "captureToolStripMenuItem1";
            this.captureToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.captureToolStripMenuItem1.Text = "Capture";
            this.captureToolStripMenuItem1.Click += new System.EventHandler(this.captureToolStripMenuItem1_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(350, 498);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 24;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(316, 230);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.txtBxconexCurrentPos);
            this.groupBox1.Controls.Add(this.btnConexMoveRel);
            this.groupBox1.Controls.Add(this.btnConexMoveAbs);
            this.groupBox1.Controls.Add(this.txtBxconexRelative);
            this.groupBox1.Controls.Add(this.txtBxconexTarget);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 104);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WavePlate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Target";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Relative";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(259, 77);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Current";
            // 
            // txtBxconexTarget
            // 
            this.txtBxconexTarget.Location = new System.Drawing.Point(72, 41);
            this.txtBxconexTarget.Name = "txtBxconexTarget";
            this.txtBxconexTarget.Size = new System.Drawing.Size(75, 20);
            this.txtBxconexTarget.TabIndex = 19;
            // 
            // txtBxconexRelative
            // 
            this.txtBxconexRelative.Location = new System.Drawing.Point(72, 74);
            this.txtBxconexRelative.Name = "txtBxconexRelative";
            this.txtBxconexRelative.Size = new System.Drawing.Size(75, 20);
            this.txtBxconexRelative.TabIndex = 20;
            // 
            // btnConexMoveAbs
            // 
            this.btnConexMoveAbs.Location = new System.Drawing.Point(155, 37);
            this.btnConexMoveAbs.Name = "btnConexMoveAbs";
            this.btnConexMoveAbs.Size = new System.Drawing.Size(45, 26);
            this.btnConexMoveAbs.TabIndex = 19;
            this.btnConexMoveAbs.Text = "Go";
            this.btnConexMoveAbs.UseVisualStyleBackColor = true;
            this.btnConexMoveAbs.Click += new System.EventHandler(this.btnConexMoveAbs_Click);
            // 
            // btnConexMoveRel
            // 
            this.btnConexMoveRel.Location = new System.Drawing.Point(155, 70);
            this.btnConexMoveRel.Name = "btnConexMoveRel";
            this.btnConexMoveRel.Size = new System.Drawing.Size(45, 26);
            this.btnConexMoveRel.TabIndex = 21;
            this.btnConexMoveRel.Text = "Move";
            this.btnConexMoveRel.UseVisualStyleBackColor = true;
            this.btnConexMoveRel.Click += new System.EventHandler(this.btnConexMoveRel_Click);
            // 
            // txtBxconexCurrentPos
            // 
            this.txtBxconexCurrentPos.Enabled = false;
            this.txtBxconexCurrentPos.Location = new System.Drawing.Point(259, 41);
            this.txtBxconexCurrentPos.Name = "txtBxconexCurrentPos";
            this.txtBxconexCurrentPos.Size = new System.Drawing.Size(75, 20);
            this.txtBxconexCurrentPos.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBxAcqureStage);
            this.groupBox2.Controls.Add(this.txtBxTo);
            this.groupBox2.Controls.Add(this.txtBxFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBxStep);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 44);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, -3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Stage";
            // 
            // chkBxAcqureStage
            // 
            this.chkBxAcqureStage.AutoSize = true;
            this.chkBxAcqureStage.Location = new System.Drawing.Point(65, 0);
            this.chkBxAcqureStage.Name = "chkBxAcqureStage";
            this.chkBxAcqureStage.Size = new System.Drawing.Size(15, 14);
            this.chkBxAcqureStage.TabIndex = 16;
            this.chkBxAcqureStage.UseVisualStyleBackColor = true;
            this.chkBxAcqureStage.CheckedChanged += new System.EventHandler(this.chkBxAcqureStage_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBxAcqConex);
            this.groupBox3.Controls.Add(this.txtBxConexTo);
            this.groupBox3.Controls.Add(this.txtBxConexFrom);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtBxConexStep);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 44);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WavePlate";
            // 
            // chkBxAcqConex
            // 
            this.chkBxAcqConex.AutoSize = true;
            this.chkBxAcqConex.Location = new System.Drawing.Point(65, 0);
            this.chkBxAcqConex.Name = "chkBxAcqConex";
            this.chkBxAcqConex.Size = new System.Drawing.Size(15, 14);
            this.chkBxAcqConex.TabIndex = 16;
            this.chkBxAcqConex.UseVisualStyleBackColor = true;
            // 
            // txtBxConexTo
            // 
            this.txtBxConexTo.Location = new System.Drawing.Point(168, 18);
            this.txtBxConexTo.Name = "txtBxConexTo";
            this.txtBxConexTo.Size = new System.Drawing.Size(75, 20);
            this.txtBxConexTo.TabIndex = 10;
            // 
            // txtBxConexFrom
            // 
            this.txtBxConexFrom.Location = new System.Drawing.Point(54, 18);
            this.txtBxConexFrom.Name = "txtBxConexFrom";
            this.txtBxConexFrom.Size = new System.Drawing.Size(75, 20);
            this.txtBxConexFrom.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "From";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "To";
            // 
            // txtBxConexStep
            // 
            this.txtBxConexStep.Location = new System.Drawing.Point(304, 18);
            this.txtBxConexStep.Name = "txtBxConexStep";
            this.txtBxConexStep.Size = new System.Drawing.Size(75, 20);
            this.txtBxConexStep.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Step";
            // 
            // acquireFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.picBx2);
            this.Controls.Add(this.picBx1);
            this.Controls.Add(this.commStage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxsavePath);
            this.Controls.Add(this.btnStartAcq);
            this.Name = "acquireFrm";
            this.Text = "Acquire Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.acquireFrm_FormClosing);
            this.Load += new System.EventHandler(this.acquireFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.cntxMnPic1.ResumeLayout(false);
            this.cntxMnPic2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip cntxMnPic2;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem1;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxconexCurrentPos;
        private System.Windows.Forms.Button btnConexMoveRel;
        private System.Windows.Forms.Button btnConexMoveAbs;
        private System.Windows.Forms.TextBox txtBxconexRelative;
        private System.Windows.Forms.TextBox txtBxconexTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkBxAcqureStage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkBxAcqConex;
        private System.Windows.Forms.TextBox txtBxConexTo;
        private System.Windows.Forms.TextBox txtBxConexFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBxConexStep;
        private System.Windows.Forms.Label label16;
    }
}

