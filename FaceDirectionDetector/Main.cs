using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDirectionDetector
{
    public partial class Main : Form
    {
        Detect objDetect = new Detect();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog objopenfile = new OpenFileDialog();
            objopenfile.Multiselect = false;
            objopenfile.Filter = "Image file (*.bmp,*.png,*.jpg,*.jpeg) | *.bmp; *.png; *.jpg; *.jpeg";
            if (DialogResult.OK == objopenfile.ShowDialog())
            {
                this.PicImg.Image = new Bitmap(objopenfile.FileName);
            }
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            PicImg.Image = objDetect.DetectFaces(PicImg.Image);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PicImg.Image = null;
        }
    }
}
