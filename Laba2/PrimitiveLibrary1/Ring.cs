using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveLibrary1
{
    public class Ring
    {
        private Circle circleMin, circleMax;

        public Ring()
        {
            this.circleMax = new Circle();
            this.circleMin = new Circle(circleMax.point.X, circleMax.point.Y, circleMax.r - 3);
        }

        public Ring(int x, int y, int rmin, int rmax, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.circleMax = new Circle(x, y, rmax, visibility, redcolor, greencolor, bluecolor);
            this.circleMin = new Circle(x, y, rmin, visibility, 255, 255, 255);

        }

        public void Show(PictureBox pictureBox1)
        {
            this.circleMax.Show(pictureBox1);
            this.circleMin.Show(pictureBox1);
        }

        public void Move(int x, int y)
        {
            this.circleMax.Move(x, y);
            if (circleMax.mflag == false)
                this.circleMin.Move(x, y);
        }
        public void RandomMove()
        {
            this.circleMax.RandomMove();
            if (circleMax.rmflag == false)
            {
                this.circleMin.point.X = circleMax.point.X;
                this.circleMin.point.Y = circleMax.point.Y;
            }
        }

        public void Visibility()
        {
            this.circleMax.Visibility();
            this.circleMin.Visibility();
        }
    }
}
