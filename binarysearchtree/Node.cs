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
        public Node linkright;
        public Node linkleft;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
