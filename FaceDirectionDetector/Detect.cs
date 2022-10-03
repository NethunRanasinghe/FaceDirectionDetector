using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Face;
using Emgu.CV.Util;

namespace FaceDirectionDetector
{
    internal class Detect
    {
        #region Variables
        //Load cascade files
        static readonly CascadeClassifier cascadeClassifier_Face = new CascadeClassifier("./Cascades/haarcascade_frontalface1.xml");
        static readonly FacemarkLBFParams facemarkLBF = new FacemarkLBFParams();
        static readonly FacemarkLBF facemark = new FacemarkLBF(facemarkLBF);

        //No fo faces detected - for debuuging
        public int No_Faces_Detected = 0;

        //Main image and the selected faces
        public List<Bitmap> Images_B = new List<Bitmap>();

        //Top Left
        public List<int> Rect_X = new List<int>();
        public List<int> Rect_Y = new List<int>();

        public List<int> Rect_Width = new List<int>();
        public List<int> Rect_Height = new List<int>();

        //Direction
        public List<string> Face_Direction = new List<string>();
        #endregion

        //This function will detect faces in the image
        public List<Bitmap> DetectFaces(Image Selected_Img)
        {
            Bitmap bitmap = new Bitmap(Selected_Img);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);

            Rectangle[] rectangles_face = cascadeClassifier_Face.DetectMultiScale(grayImage, 1.3, 5);

            facemark.LoadModel("lbfmodel.yaml");
            VectorOfVectorOfPointF landmark = new VectorOfVectorOfPointF();
            VectorOfRect Face_rect = new VectorOfRect(rectangles_face);
            bool result = facemark.Fit(grayImage, Face_rect, landmark);

            

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

            //Detect Nose Mid position
            if (result)
            {
                for (int i = 0; i < rectangles_face.Length; i++)
                {
                    var Nose_Mid = landmark[i][33];

                    #region Debug_Nose_Mid
                    /*using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 5))
                        {
                            graphics.DrawRectangle(pen, Nose_Mid.X, Nose_Mid.Y, 2, 2);
                        }
                    }*/
                    #endregion

                    Face_Direction.Add(Direction(Rect_X[i], Rect_Y[i], Rect_Width[i], Nose_Mid.X, Nose_Mid.Y,bitmap));
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
            Images_B.Add(Cropped);

        }

        private string Direction(float Face_X, float Face_Y, float Face_Width, float Nose_X, float Nose_Y,Bitmap bitmap)
        {
            float Face_Sqaure_X_mid = (Face_X + (Face_X + Face_Width) ) / 2;

            #region Debug_Face_Sqaure_Mid
            /*using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(Color.Blue, 5))
                {
                    graphics.DrawRectangle(pen, Face_Sqaure_X_mid, Face_Y, 2, 2);
                }
            }*/
            #endregion

            if (Nose_X > Face_Sqaure_X_mid)
            {
                return "Looking Right";
            }
            
            if(Nose_X < Face_Sqaure_X_mid)
            {
                return "Looking Left";
            }

            return "Looking straight";
        }

    }


}
