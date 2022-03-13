using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOOP_Lab4
{
    public class Node
    {
        public Figure Data { get; set; }
        public Node Next { get; set; }
        public Node(Figure data) 
        {
            Data = data;
        }
    }
}
