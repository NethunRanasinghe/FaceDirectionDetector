using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceDirectionDetector
{
    internal class Detect
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("./Cascades/haarcascade_frontalface1.xml");

        public Bitmap DetectFaces(Image Selected_Img)
        {
            Bitmap bitmap = new Bitmap(Selected_Img);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.3, 2);
            foreach (Rectangle rect in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 5))
                    {
                        graphics.DrawRectangle(pen, rect);
                    }
                }
            }

            return bitmap;
        }
    }


}
