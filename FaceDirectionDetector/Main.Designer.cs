namespace FaceDirectionDetector
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.BtnChooseImg = new System.Windows.Forms.Button();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.PicFF = new System.Windows.Forms.PictureBox();
            this.PicFS = new System.Windows.Forms.PictureBox();
            this.LblDF = new System.Windows.Forms.Label();
            this.LblDS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PicExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicImg
            // 
            this.PicImg.BackColor = System.Drawing.Color.Transparent;
            this.PicImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicImg.Location = new System.Drawing.Point(12, 47);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(668, 406);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImg.TabIndex = 0;
            this.PicImg.TabStop = false;
            // 
            // BtnChooseImg
            // 
            this.BtnChooseImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BtnChooseImg.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChooseImg.Location = new System.Drawing.Point(142, 474);
            this.BtnChooseImg.Name = "BtnChooseImg";
            this.BtnChooseImg.Size = new System.Drawing.Size(124, 45);
            this.BtnChooseImg.TabIndex = 1;
            this.BtnChooseImg.Text = "Choose Image";
            this.BtnChooseImg.UseVisualStyleBackColor = false;
            this.BtnChooseImg.Click += new System.EventHandler(this.BtnChooseImg_Click);
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BtnAnalyze.Enabled = false;
            this.BtnAnalyze.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalyze.Location = new System.Drawing.Point(556, 474);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(124, 45);
            this.BtnAnalyze.TabIndex = 1;
            this.BtnAnalyze.Text = "Analyze";
            this.BtnAnalyze.UseVisualStyleBackColor = false;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BtnReset.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(12, 474);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(124, 45);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // PicFF
            // 
            this.PicFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicFF.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PicFF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicFF.Location = new System.Drawing.Point(9, 82);
            this.PicFF.Name = "PicFF";
            this.PicFF.Size = new System.Drawing.Size(100, 80);
            this.PicFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFF.TabIndex = 2;
            this.PicFF.TabStop = false;
            // 
            // PicFS
            // 
            this.PicFS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicFS.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PicFS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicFS.Location = new System.Drawing.Point(9, 255);
            this.PicFS.Name = "PicFS";
            this.PicFS.Size = new System.Drawing.Size(100, 80);
            this.PicFS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFS.TabIndex = 3;
            this.PicFS.TabStop = false;
            // 
            // LblDF
            // 
            this.LblDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDF.AutoSize = true;
            this.LblDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDF.Location = new System.Drawing.Point(115, 107);
            this.LblDF.Name = "LblDF";
            this.LblDF.Size = new System.Drawing.Size(67, 18);
            this.LblDF.TabIndex = 4;
            this.LblDF.Text = "Direction";
            this.LblDF.Click += new System.EventHandler(this.LblDF_Click);
            // 
            // LblDS
            // 
            this.LblDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDS.AutoSize = true;
            this.LblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDS.Location = new System.Drawing.Point(115, 284);
            this.LblDS.Name = "LblDS";
            this.LblDS.Size = new System.Drawing.Size(67, 18);
            this.LblDS.TabIndex = 5;
            this.LblDS.Text = "Direction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 24);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.PicMin);
            this.panel4.Location = new System.Drawing.Point(843, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 24);
            this.panel4.TabIndex = 1;
            // 
            // PicMin
            // 
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicMin.Image = global::FaceDirectionDetector.Properties.Resources.Minus;
            this.PicMin.Location = new System.Drawing.Point(0, 0);
            this.PicMin.Name = "PicMin";
            this.PicMin.Size = new System.Drawing.Size(24, 24);
            this.PicMin.TabIndex = 0;
            this.PicMin.TabStop = false;
            this.PicMin.Click += new System.EventHandler(this.PicMin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PicExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(874, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 24);
            this.panel3.TabIndex = 0;
            // 
            // PicExit
            // 
            this.PicExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicExit.Image = global::FaceDirectionDetector.Properties.Resources.Close;
            this.PicExit.Location = new System.Drawing.Point(0, 0);
            this.PicExit.Name = "PicExit";
            this.PicExit.Size = new System.Drawing.Size(24, 24);
            this.PicExit.TabIndex = 0;
            this.PicExit.TabStop = false;
            this.PicExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.LblDS);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PicFF);
            this.panel2.Controls.Add(this.LblDF);
            this.panel2.Controls.Add(this.PicFS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(686, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 504);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Face -2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Face - 1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(898, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.BtnChooseImg);
            this.Controls.Add(this.PicImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Direction Detector";
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.Button BtnChooseImg;
        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.PictureBox PicFF;
        private System.Windows.Forms.PictureBox PicFS;
        private System.Windows.Forms.Label LblDF;
        private System.Windows.Forms.Label LblDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PicExit;
    }
}

