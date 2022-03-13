using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PrimitiveLibrary1
{
    public class Line
    {
        public Point point1 { get; }
        public Point point2 { get; }
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }
        private static Random rnd = new Random();
        private bool visibility;
        public Line()
        {
            point1 = new Point();
            point2 = new Point();
            this.visibility = true;
            this.redcolor = rnd.Next(0, 255);
            this.greencolor = rnd.Next(0, 255);
            this.bluecolor = rnd.Next(0, 255);
        }
        public Line(int x1, int y1, int x2, int y2, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            point1 = new Point(x1, y1);
            point2 = new Point(x2, y2);
            this.visibility = visibility;
            this.redcolor = redcolor;
            this.greencolor = greencolor;
            this.bluecolor = bluecolor;
        }
        public void Show(PictureBox pictureBox1)
        {
            if (visibility == true)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.White);
                    }
                    pictureBox1.Image = bmp;
                }
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(new Pen(Color.FromArgb(redcolor, greencolor, bluecolor), 5), point1.X, point1.Y, point2.X, point2.Y);
                }
                pictureBox1.Invalidate();
            }
        }

        public void Move(int x1, int y1)
        {
            if (this.point1.X + x1 >= 828 || this.point1.X + x1 <= 0 || this.point1.Y + y1 >= 684 || this.point1.Y + y1 <= 0 || this.point2.X + x1 >= 828 || this.point2.X + x1 <= 0 || this.point2.Y + y1 >= 684 || this.point2.Y + y1 <= 0)
            {
                //MessageBox.Show("Перемещение не возможно");
            }
            else
            {
                this.point1.X += x1;
                this.point1.Y += y1;
                this.point2.X += x1;
                this.point2.Y += y1;
            }
        }
        public void Visibility()
        {
            if (this.visibility == false)
            {
                this.visibility = true;
            }
            else
            {
                this.visibility = false;
            }
        }
        public void RandomMove()
        {
            int ax, ay;
            ax = rnd.Next(-50, 50);
            ay = rnd.Next(-50, 50);
            if (this.point1.X + ax >= 828 || this.point1.X + ax <= 0 || this.point1.Y + ay >= 684 || this.point1.Y + ay <= 0 || this.point2.X + ax >= 828 || this.point2.X + ax <= 0 || this.point2.Y + ay >= 684 || this.point2.Y + ay <= 0)
            {
                //MessageBox.Show("Перемещение не возможно");
            }
            else
            {
                this.point1.X += ax;
                this.point1.Y += ay;
                this.point2.X += ax;
                this.point2.Y += ay;
            }
        }
    }
}
