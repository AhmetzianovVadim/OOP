using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PrimitiveLibrary1
{
    public class Circle
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }

        private bool visibility;
        private static Random rnd = new Random(); 
        public Circle()
        {
            this.x = rnd.Next(0, 828);
            this.y = rnd.Next(0, 682);
            this.r = rnd.Next(5, 50);
            this.visibility = true;
            this.redcolor = rnd.Next(0, 256);
            this.greencolor = rnd.Next(0, 256);
            this.bluecolor = rnd.Next(0, 256);
        }
        public Circle(int x, int y, int r, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.visibility = visibility;
            this.redcolor = redcolor;
            this.greencolor = greencolor;
            this.bluecolor = bluecolor;
        }
        public void Show(PictureBox pictureBox1)
        {
            if (visibility)
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
                    g.FillEllipse(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), x - r, y - r, 2 * r, 2 * r);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        g.DrawEllipse(new Pen(Color.White), x - r, y - r, 2 * r, 2 * r);
                    }
                    else
                    {
                        g.DrawEllipse(new Pen(Color.Black), x - r, y - r, 2 * r, 2 * r);
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
