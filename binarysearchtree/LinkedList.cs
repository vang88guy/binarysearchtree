using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    class LinkedList
    {
        Node start;
        
        public LinkedList()
        {

        }

        public void InsertAtEnd(int data)
        {
            Node node = new Node(data);
            if (start == null)
            {
                start = node;
                return;
            }
            Node temp = start;
           
            while (true)
            {
                if (data <= temp.data)
                {
                    if (temp.linkleft == null)
                    {
                        temp.linkleft = node;
                        break;
                    }
                    else
                    {
                        temp = temp.linkleft;
                    }
                }
                
                if (data > temp.data)
                {
                    if (temp.linkright == null)
                    {
                        temp.linkright = node;
                        break;
                    }
                    else
                    {
                        temp = temp.linkright;
                    }
                }               
            }
            
        }

        public void Search(int data) 
        {
            Node temp = start;
            
            while (true)
            {
              
                if (data < temp.data && temp.linkleft !=null)
                {
                    temp = temp.linkleft;
                }

                else if (data > temp.data && temp.linkright != null)
                {
                    temp = temp.linkright;
                }
                else if (data == temp.data)
                {
                    Console.WriteLine("Found "+ temp.data);
                    break;                   
                }
                else 
                {
                    Console.WriteLine("Not Found");
                    break;
                }
                
            }
        }
    }
}
