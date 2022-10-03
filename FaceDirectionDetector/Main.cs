using Emgu.CV.Structure;
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
            Reset_Everything();

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
            var Images =  objDetect.DetectFaces(PicImg.Image);
            this.PicImg.Image = Images.Last();

            if (Images.Count  == 2)
            {
                this.PicFF.Image = Images[0];
            }
            else if(Images.Count >  2)
            {
                
                this.PicFF.Image = Images[0];
                this.PicFS.Image = Images[1];
            }

            
            if (Images.Count == 2)
            {
                this.LblDF.Text = objDetect.Face_Direction[0];
            }
            else if (Images.Count > 2)
            {

                this.LblDF.Text = objDetect.Face_Direction[0];
                this.LblDS.Text = objDetect.Face_Direction[1];
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset_Everything();
        }

        private void Reset_Everything()
        {
            PicImg.Image = null;
            PicFF.Image = null;
            PicFS.Image = null;

            objDetect.Rect_X.Clear();
            objDetect.Rect_Y.Clear();
            objDetect.Rect_Width.Clear();
            objDetect.Rect_Height.Clear();
            objDetect.Images_B.Clear();
            objDetect.Face_Direction.Clear();

            LblDF.Text = "Direction";
            LblDS.Text = "Direction";
            LblDF.Location = new Point(111, 107);
            LblDS.Location = new Point(111, 284);
        }

        #region Debug
        private void Face_Coordinates()
        {
            for (int x = 0; x < objDetect.No_Faces_Detected; x++)
            {
                MessageBox.Show("Face - " + (x + 1) + " :- " +
                    " \nX :" + objDetect.Rect_X[x] +
                    " \nY :" + objDetect.Rect_Y[x] +
                    " \nWidth :" + objDetect.Rect_Width[x] +
                    " \nHeight :" + objDetect.Rect_Height[x]);
            }
        }
        #endregion

        private void LblDF_Click(object sender, EventArgs e)
        {

        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
