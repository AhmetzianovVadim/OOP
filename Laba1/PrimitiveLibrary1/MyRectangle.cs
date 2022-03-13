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
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }
        private static Random rnd = new Random();
        private bool visibility;
        public MyRectangle()
        {
            this.x = rnd.Next(0, 828);
            this.y = rnd.Next(0, 682);
            this.w = rnd.Next(0, 150);
            this.h = rnd.Next(0, 150);
            this.visibility = true;
            this.redcolor = rnd.Next(0, 256);
            this.greencolor = rnd.Next(0, 256);
            this.bluecolor = rnd.Next(0, 256);
        }

        public MyRectangle(int x, int y, int w, int h, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
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
                    g.FillRectangle(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), x, y, w, h);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        g.DrawRectangle(new Pen(Color.White), x, y, w, h);
                    }
                    else
                    {
                        g.DrawRectangle(new Pen(Color.Black), x, y, w, h);
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
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
            this.x += rnd.Next(-50, 50);
            this.y += rnd.Next(-50, 50);
        }
    }
}
