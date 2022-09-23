namespace tryConex
{
    partial class tryConex_Form1
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
            this.btnGetID = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHomeSearch = new System.Windows.Forms.Button();
            this.btnMoveAbs = new System.Windows.Forms.Button();
            this.txtBxMove = new System.Windows.Forms.TextBox();
            this.btnGetPos = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetID
            // 
            this.btnGetID.Location = new System.Drawing.Point(107, 29);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(75, 23);
            this.btnGetID.TabIndex = 2;
            this.btnGetID.Text = "get ID";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 173);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 219);
            this.textBox1.TabIndex = 3;
            // 
            // btnHomeSearch
            // 
            this.btnHomeSearch.Location = new System.Drawing.Point(387, 29);
            this.btnHomeSearch.Name = "btnHomeSearch";
            this.btnHomeSearch.Size = new System.Drawing.Size(100, 23);
            this.btnHomeSearch.TabIndex = 4;
            this.btnHomeSearch.Text = "Home Search";
            this.btnHomeSearch.UseVisualStyleBackColor = true;
            this.btnHomeSearch.Click += new System.EventHandler(this.btnHomeSearch_Click);
            // 
            // btnMoveAbs
            // 
            this.btnMoveAbs.Location = new System.Drawing.Point(107, 68);
            this.btnMoveAbs.Name = "btnMoveAbs";
            this.btnMoveAbs.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAbs.TabIndex = 5;
            this.btnMoveAbs.Text = "Move Abs";
            this.btnMoveAbs.UseVisualStyleBackColor = true;
            this.btnMoveAbs.Click += new System.EventHandler(this.btnMoveAbs_Click);
            // 
            // txtBxMove
            // 
            this.txtBxMove.Location = new System.Drawing.Point(188, 70);
            this.txtBxMove.Name = "txtBxMove";
            this.txtBxMove.Size = new System.Drawing.Size(44, 20);
            this.txtBxMove.TabIndex = 6;
            // 
            // btnGetPos
            // 
            this.btnGetPos.Location = new System.Drawing.Point(107, 110);
            this.btnGetPos.Name = "btnGetPos";
            this.btnGetPos.Size = new System.Drawing.Size(75, 23);
            this.btnGetPos.TabIndex = 7;
            this.btnGetPos.Text = "Get Position";
            this.btnGetPos.UseVisualStyleBackColor = true;
            this.btnGetPos.Click += new System.EventHandler(this.btnGetPos_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 404);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGetPos);
            this.Controls.Add(this.txtBxMove);
            this.Controls.Add(this.btnMoveAbs);
            this.Controls.Add(this.btnHomeSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHomeSearch;
        private System.Windows.Forms.Button btnMoveAbs;
        private System.Windows.Forms.TextBox txtBxMove;
        private System.Windows.Forms.Button btnGetPos;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

