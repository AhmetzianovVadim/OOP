using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveLibrary1
{
    public class Frame
    {
        private MyRectangle frameMin, frameMax;

        public Frame()
        {
            this.frameMax = new MyRectangle();
            this.frameMin = new MyRectangle(this.frameMax.point.X, this.frameMax.point.Y, this.frameMax.w-3 , this.frameMax.h-3 );
        }

        public Frame(int x, int y, int wmin, int hmin, int wmax, int hmax, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.frameMax = new MyRectangle(x, y, wmax, hmax, visibility, redcolor, greencolor, bluecolor);
            this.frameMin = new MyRectangle(x, y, wmin, hmin, visibility, 255, 255, 255);

        }

        public void Show(PictureBox pictureBox1)
        {
            this.frameMax.Show(pictureBox1);
            this.frameMin.Show(pictureBox1);
        }

        public void Move(int x, int y)
        {
            this.frameMax.Move(x, y);
            if (frameMax.mflag == false)
                this.frameMin.Move(x, y);
        }

        public void Visibility()
        {
            frameMax.Visibility();
            frameMin.Visibility();
        }
        public void RandomMove()
        {
            this.frameMax.RandomMove();
            if (frameMax.rmflag == false)
            {
                this.frameMin.point.X = frameMax.point.X;
                this.frameMin.point.Y = frameMax.point.Y;
            }
        }
    }
}

