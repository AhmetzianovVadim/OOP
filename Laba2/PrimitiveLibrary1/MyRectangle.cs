using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PrimitiveLibrary1
{
    public class MyRectangle
    {
        public Point point { get; }
        public int w { get; set; }
        public int h { get; set; }
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }
        public bool mflag { get; set; } = false;
        public bool rmflag { get; set; } = false;
        public bool rflag { get; set; } = false;
        private static Random rnd = new Random();
        private bool visibility;
        public MyRectangle()
        {
            point = new Point();
            this.w = rnd.Next(5, 150);
            this.h = rnd.Next(5, 150);
            CheckWidthHeight();
            this.visibility = true;
            this.redcolor = rnd.Next(0, 256);
            this.greencolor = rnd.Next(0, 256);
            this.bluecolor = rnd.Next(0, 256);
        }
        public MyRectangle(int x, int y, int w, int h)
        {
            point = new Point(x, y);
            this.w = w;
            this.h = h;
            this.visibility = true;
            this.redcolor = 255;
            this.greencolor = 255;
            this.bluecolor = 255;
        }
        public MyRectangle(int x, int y, int w, int h, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            point = new Point(x, y);
            this.w = w;
            this.h = h;
            CheckWidthHeight();
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
                    g.FillRectangle(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), point.X - w, point.Y - h, 2*w, 2*h);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        g.DrawRectangle(new Pen(Color.White), point.X - w, point.Y - h, 2 * w, 2 * h);
                    }
                    else
                    {
                        g.DrawRectangle(new Pen(Color.Black), point.X - w, point.Y - h, 2 * w, 2 * h);
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public void Move(int x, int y)
        {
            if (this.point.X + x + this.w>= 828 || this.point.X + x - this.w <= 0 || this.point.Y + y + this.h>= 684 || this.point.Y + y - this.h <= 0)
            {
                //MessageBox.Show("Перемещение не возможно");
                mflag = true;
            }
            else
            {
                this.point.X += x;
                this.point.Y += y;
                mflag = false;
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
            if (this.point.X + ax + this.w >= 828 || this.point.X + ax - this.w <= 0 || this.point.Y + ay + this.h >= 684 || this.point.Y + ay - this.h <= 0)
            {
                //MessageBox.Show("Перемещение не возможно");
                rmflag = true;
            }
            else
            {
                rmflag = false;
                this.point.X += ax;
                this.point.Y += ay;
            }
        }
        private void CheckWidthHeight()
        {
            if ((point.X + this.w >= 828 || point.X - this.w <= 0) && this.w > 4)
            {
                this.w--;
                rflag = true;
                CheckWidthHeight();
            }
            else if ((point.Y + this.h >= 682 || point.Y - this.h <= 0) && this.h > 4)
            {
                this.h--;
                rflag = true;
                CheckWidthHeight();
            }
            else
            {
                rflag = false;
            }
        }
    }
}
