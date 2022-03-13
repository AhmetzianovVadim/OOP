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
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }
        private static Random rnd = new Random();
        private bool visibility;
        public Line()
        {
            this.x1 = rnd.Next(0, 828);
            this.y1 = rnd.Next(0, 682);
            this.x2 = rnd.Next(0, 828);
            this.y2 = rnd.Next(0, 682);
            this.visibility = true;
            this.redcolor = rnd.Next(0, 255);
            this.greencolor = rnd.Next(0, 255);
            this.bluecolor = rnd.Next(0, 255);
        }
        public Line(int x1, int y1, int x2, int y2, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
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
                    g.DrawLine(new Pen(Color.FromArgb(redcolor, greencolor, bluecolor), 5), x1, y1, x2, y2);
                }
                pictureBox1.Invalidate();
            }
        }

        public void Move(int x1, int y1)
        {
            this.x1 += x1;
            this.y1 += y1;
            this.x2 += x1;
            this.y2 += y1;
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
            this.x1 += rnd.Next(-50, 50);
            this.y1 += rnd.Next(-50, 50);
            this.x2 += rnd.Next(-50, 50);
            this.y2 += rnd.Next(-50, 50);
        }
    }
}
