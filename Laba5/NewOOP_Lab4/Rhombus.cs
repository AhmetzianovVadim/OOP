using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewOOP_Lab4
{
    public class Rhombus : Square
    {
        private static Random randomint = new Random();
        private int h;
        public Rhombus() 
        {
            this.h = randomint.Next(20, 130);
        }
        public Rhombus(int x, int y, int w, int h, bool visibility, int redcolor, int greencolor, int bluecolor) : base(x, y, w, visibility, redcolor, greencolor, bluecolor)
        {
            this.h = h;
        }
        public override void Show(PictureBox pictureBox1)
        {
            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();
            Point point4 = new Point();
            point1.X = x + w/2;
            point1.Y = y;
            point2.X = x;
            point2.Y = y - h/2;
            point3.X = x + w / 2;
            point3.Y = y - h;
            point4.X = x + w;
            point4.Y = y - h / 2;
            if (visibility == true)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap newbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics gr = Graphics.FromImage(newbmp))
                    {
                        gr.Clear(Color.White);
                    }
                    pictureBox1.Image = newbmp;
                }
                using (Graphics gr = Graphics.FromImage(pictureBox1.Image))
                {
                    gr.FillPolygon(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), new[] { point1, point2, point3, point4 });
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawPolygon(new Pen(Color.White), new[] { point1, point2, point3, point4 });
                    }
                    else
                    {
                        gr.DrawPolygon(new Pen(Color.Black), new[] { point1, point2, point3, point4 });
                    }
                }
                pictureBox1.Invalidate();
            }
            
        }
    }
}
