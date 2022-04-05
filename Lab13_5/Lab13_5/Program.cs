using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Lab13_5
{
    class Program
    {

        private static int leftBound = -100, rightBound = 100;
        private static double precision = .0001;

        private static List<Vector2> pointsList = new List<Vector2>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PointFinder();
        }

        private static void PointFinder()
        {
            for (int funcRow = 0; funcRow < 2; funcRow++)
            {
                int k = 0;
                for (double x = leftBound; x < rightBound; x += precision)
                {
                    SavePoint(new Vector2((float)Func(x, funcRow, k), (float)x));

                    k++;
                }
            }

            Draw();
        }
        private static void SavePoint(Vector2 pointToSave)
        {
            pointsList.Add(pointToSave);
        }

        #region Function and Stuff
        // The function.
        private static double Func(double argument, int funcNum, int K)
        {
            switch (funcNum)
            {
                case 0:
                    return Math.Sin(argument + .5f) - 1;
                case 1:
                    return 2 * Math.PI * K + Math.Pow(Math.Cos(-argument),-1) - 2;
                default:
                    Console.WriteLine("Eror: index of func is out of the bounds");
                    return 0;
            }
        }

        // The function's derivative.
      /*  private static double Derivative(double[] x, int funcNum)
        {
            switch (funcNum)
            {
                case 0:
                    return Math.Cos(x[0] + .5f) - 1;
                case 1:
                    return -Math.Sin(x[1] - 2) + 1;
                default:
                    Console.WriteLine("Eror: index of func is out of the bounds");
                    return 0;
            }
        }*/
        #endregion

        #region GraphDraw
        public static void DrawToBitmap(Bitmap image)
        {
            if (pointsList.Count == 0) return;

            double xMax = (double)pointsList.Max(p => p.X);
            double yMax = (double)pointsList.Max(p => p.Y);
            double xMin = (double)pointsList.Min(p => p.X);
            double yMin = (double)pointsList.Min(p => p.Y);

            double width = xMax - xMin;
            double height = yMax - yMin;

            double scaleX = (image.Width - 20) / width;
            double scaleY = (image.Height - 20) / height;
            double scale = Math.Min(scaleX, scaleY);
            foreach (var pixel in pointsList)
            {
                double x = ((double)pixel.X - xMin - width / 2) * scale + image.Width / 2.0;
                double y = ((double)pixel.Y - yMin - height / 2) * scale + image.Height / 2.0;
                image.SetPixel((int)x, (int)y, Color.LightSeaGreen);
            }
        }

        private static void Draw()
        {
            Bitmap image = new Bitmap(800, 800, PixelFormat.Format24bppRgb);
            using (var g = Graphics.FromImage(image))
            {
                g.Clear(Color.DarkSeaGreen);
            }

             DrawToBitmap(image);

             ShowImageInWindow(image);
        }

        private static void ShowImageInWindow(Bitmap image)
        {
            Form form = new Form
            {
                Text = "GRAPH",
                ClientSize = image.Size
            };

            form.Controls.Add(new PictureBox
            {
                Image = image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage
            });
            form.ShowDialog();
        }
    }
    #endregion
}

