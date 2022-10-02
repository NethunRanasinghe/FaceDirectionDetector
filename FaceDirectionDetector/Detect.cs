using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDirectionDetector
{
    internal class Detect
    {
        #region Variables
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("./Cascades/haarcascade_frontalface1.xml");

        //No fo faces detected - for debuuging
        public int No_Faces_Detected = 0;

        //Main image and the selected faces
        public List<Bitmap> Images_B = new List<Bitmap>();

        //Top Left
        public List<int> Rect_X = new List<int>();
        public List<int> Rect_Y = new List<int>();

        public List<int> Rect_Width = new List<int>();
        public List<int> Rect_Height = new List<int>();
        #endregion

        //This function will detect faces in the image
        public List<Bitmap> DetectFaces(Image Selected_Img)
        {
            Bitmap bitmap = new Bitmap(Selected_Img);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.3, 5);

            foreach (Rectangle rect in rectangles)
            {
                //Set Coordinate values
                Rect_X.Add(rect.X);
                Rect_Y.Add(rect.Y);
             
                Rect_Width.Add(rect.Width);
                Rect_Height.Add(rect.Height);

                //Set no of faces detected
                No_Faces_Detected = rectangles.Length;

                //Send bitmap to crop faces
                CropFaces(bitmap,rect);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 5))
                    {
                        graphics.DrawRectangle(pen, rect);
                    }
                }
            }

            Images_B.Add(bitmap);

            return Images_B;
        }
        
        private void CropFaces(Bitmap Image, Rectangle Face)
        {
            Bitmap Cropped = new Bitmap(Face.Width, Face.Height);
            using (Graphics objgraphics = Graphics.FromImage(Cropped))
            {
                objgraphics.DrawImage(Image, -Face.X, -Face.Y);
                Images_B.Add(Cropped);
            }
        }
    }


}
