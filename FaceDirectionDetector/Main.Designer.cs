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
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.BtnChooseImg = new System.Windows.Forms.Button();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.SuspendLayout();
            // 
            // PicImg
            // 
            this.PicImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicImg.Location = new System.Drawing.Point(12, 12);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(836, 513);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImg.TabIndex = 0;
            this.PicImg.TabStop = false;
            // 
            // BtnChooseImg
            // 
            this.BtnChooseImg.Location = new System.Drawing.Point(854, 12);
            this.BtnChooseImg.Name = "BtnChooseImg";
            this.BtnChooseImg.Size = new System.Drawing.Size(124, 45);
            this.BtnChooseImg.TabIndex = 1;
            this.BtnChooseImg.Text = "Choose Image";
            this.BtnChooseImg.UseVisualStyleBackColor = true;
            this.BtnChooseImg.Click += new System.EventHandler(this.BtnChooseImg_Click);
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Location = new System.Drawing.Point(854, 63);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(124, 45);
            this.BtnAnalyze.TabIndex = 1;
            this.BtnAnalyze.Text = "Analyze";
            this.BtnAnalyze.UseVisualStyleBackColor = true;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(854, 480);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(124, 45);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnOptions
            // 
            this.BtnOptions.Location = new System.Drawing.Point(854, 429);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(124, 45);
            this.BtnOptions.TabIndex = 1;
            this.BtnOptions.Text = "Options";
            this.BtnOptions.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 537);
            this.Controls.Add(this.BtnOptions);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.BtnChooseImg);
            this.Controls.Add(this.PicImg);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Direction Detector";
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicImg;
        private System.Windows.Forms.Button BtnChooseImg;
        private System.Windows.Forms.Button BtnAnalyze;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnOptions;
    }
}

