using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    class Node
    {
        public int data;
        Node link;
        public Node linkright;
        public Node linkleft;

        public Node(int data)
        {
            this.data = data;
        }
        //public int item;
        //public Node leftc;
        //public Node rightc;
        //public void display()
        //{
        //    Console.Write("[");
        //    Console.Write(item);
        //    Console.Write("]");
        //}
    }
}
