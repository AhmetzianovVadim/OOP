using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveLibrary1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        private static Random rnd = new Random();
        public Point()
        {
            this.X = rnd.Next(1, 826);
            this.Y = rnd.Next(1, 682);
            //MessageBox.Show("Точка со случайными параметрами создана");
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
            //MessageBox.Show("Точка с заданными параметрами создана");
        }
    }
}
