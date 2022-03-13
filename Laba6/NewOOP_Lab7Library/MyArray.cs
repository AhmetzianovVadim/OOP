using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public class MyArray : IEnumerable
    {
        private Figure[] figures;
        private int count;
        
        public int Capacity 
        { 
            get { return figures.Length; } 
            set 
            { 
                if (value > figures.Length)
                {
                    Array.Resize(ref figures, value);
                }
            } 
        }
        public MyArray() 
        {
            figures = new Figure[1];
        }

        public void Add(Figure figure)
        {
            if (count == Capacity)
                Capacity = count + 1;
            figures[count++] = figure;
        }
        public void Delete()
        {
            count = 0;
            figures = null;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return figures[i];
            }
        }
    }
}
