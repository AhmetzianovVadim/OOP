using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public class LinkedList : IEnumerable
    {
        private Node head;
        private Node tail;
        public LinkedList()
        {
            head = null;
            tail = null;
            
        }
        public void Add(Figure data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;

            tail = node;
            
        }
        public void Clear()
        {
            head = null;
            tail = null;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
