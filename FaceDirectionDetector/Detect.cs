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
        //Load cascade files
        static readonly CascadeClassifier cascadeClassifier_Face = new CascadeClassifier("./Cascades/haarcascade_frontalface1.xml");
        static readonly CascadeClassifier cascadeClassifier_LEye = new CascadeClassifier("./Cascades/haarcascade_lefteye_2splits.xml");
        static readonly CascadeClassifier cascadeClassifier_REye = new CascadeClassifier("./Cascades/haarcascade_righteye_2splits.xml");

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

            Rectangle[] rectangles_face = cascadeClassifier_Face.DetectMultiScale(grayImage, 1.3, 5);

            foreach (Rectangle rect in rectangles_face)
            {
                //Set Coordinate values
                Rect_X.Add(rect.X);
                Rect_Y.Add(rect.Y);
             
                Rect_Width.Add(rect.Width);
                Rect_Height.Add(rect.Height);

                //Set no of faces detected
                No_Faces_Detected = rectangles_face.Length;

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
        
        //This function will crop detected faces and will search for other facial characters
        private void CropFaces(Bitmap Image, Rectangle Face)
        {
            Bitmap Cropped = new Bitmap(Face.Width, Face.Height);
            using (Graphics objgraphics = Graphics.FromImage(Cropped))
            {
                objgraphics.DrawImage(Image, -Face.X, -Face.Y);
            }

            /*Image<Bgr, byte> grayImage_Cropped = new Image<Bgr, byte>(Cropped);
            Rectangle[] rectangles_Leye = cascadeClassifier_LEye.DetectMultiScale(grayImage_Cropped, 1.3, 5);
            Rectangle[] rectangles_Reye = cascadeClassifier_REye.DetectMultiScale(grayImage_Cropped, 1.3, 5);

            foreach (Rectangle rectL in rectangles_Leye)
            {
                using (Graphics graphics = Graphics.FromImage(Cropped))
                {
                    using (Pen pen = new Pen(Color.Red, 5))
                    {
                        graphics.DrawRectangle(pen, rectL);
                    }
                }
            }*/

            /*foreach (Rectangle rectR in rectangles_Reye)
            {
                using (Graphics graphics = Graphics.FromImage(Cropped))
                {
                    using (Pen pen = new Pen(Color.Red, 5))
                    {
                        graphics.DrawRectangle(pen, rectR);
                    }
                }
            }*/


            Images_B.Add(Cropped);

        }


    }


}
