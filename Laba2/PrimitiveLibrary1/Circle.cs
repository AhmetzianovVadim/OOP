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
        public Point point { get; }
        public int r { get; set; }
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }

        private bool visibility, rflag = false;
        public bool mflag { get; set; } = false;
        public bool rmflag { get; set; } = false;
        private static Random rnd = new Random(); 
        public Circle()
        {
            point = new Point();
            this.r = rnd.Next(15, 75);
            CheckRadius();
            if (rflag == true)
            {
                //MessageBox.Show("Радиус был автоматически уменьшен");
                rflag = false;
            }
            this.visibility = true;
            this.redcolor = rnd.Next(0, 256);
            this.greencolor = rnd.Next(0, 256);
            this.bluecolor = rnd.Next(0, 256);
            //MessageBox.Show("Окружность со случайными параметрами создана");
        }
        public Circle(int x, int y, int r)
        {
            point = new Point(x, y);
            this.r = r;
            this.visibility = true;
            this.redcolor = 255;
            this.greencolor = 255;
            this.bluecolor = 255;
            //MessageBox.Show("Внутренняя окружность для кольца создана");
        }
        public Circle(int x, int y, int r, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            point = new Point(x, y);
            this.r = r;
            CheckRadius();
            if (rflag == true)
            {
                //MessageBox.Show("Радиус был автоматически уменьшен");
                rflag = false;
            }
            this.visibility = visibility;
            this.redcolor = redcolor;
            this.greencolor = greencolor;
            this.bluecolor = bluecolor;
            //MessageBox.Show("Окружность по заданным параметрам создана");
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
                    g.FillEllipse(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), point.X - r, point.Y - r, 2 * r, 2 * r);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        g.DrawEllipse(new Pen(Color.White), point.X - r, point.Y - r, 2 * r, 2 * r);
                    }
                    else
                    {
                        g.DrawEllipse(new Pen(Color.Black), point.X - r, point.Y - r, 2 * r, 2 * r);
                    }
                }
                pictureBox1.Invalidate();
            }
        }
        public void Move(int x, int y) 
        {
            if (this.point.X + x + r >= 828 || this.point.X + x - r <= 0 || this.point.Y + y + r >= 684 || this.point.Y + y - r <= 0)
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
            if (this.point.X + ax + r >= 828 || this.point.X + ax - r <= 0 || this.point.Y + ay + r >= 684 || this.point.Y + ay - r <= 0)
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
        private void CheckRadius()
        {
            if ((point.X - this.r <= 0 || point.Y - this.r <= 0 || point.X + this.r >= 828 || point.Y + this.r >= 684) && this.r > 4)
            {
                this.r--;
                rflag = true;
                CheckRadius();
            }
            else
            {
                rflag = false;
            }
        }
    }
}
