using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList LL = new LinkedList();
            LL.InsertAtEnd(50);
            LL.InsertAtEnd(60);
            LL.InsertAtEnd(100);
            LL.InsertAtEnd(25);
            LL.InsertAtEnd(75);
            LL.Search(75);
            Console.WriteLine();
           
        }
    }
}
