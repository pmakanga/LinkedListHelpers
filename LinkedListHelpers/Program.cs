using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHelpers
{

    class Program
    {
        public class Node
        {
            public string data;
            public Node next;
            public Node(string i)
            {
                data = i;
                next = null;
            }

            public void Print()
            {
                Console.Write("|" + data + "|->");
                if (next != null)
                {
                    next.Print();
                }
            }
        }
        public class MyList
        {
            public Node headNode;

            public MyList()
            {
                headNode = null;
            }

            public void AddToEnd(string data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
            }

            public void DeleteNode(string data)
            {
                
            }
            public void Print()
            {
                if (headNode == null)
                {
                    headNode.Print();
                }
            }
        }
        static void Main(string[] args)
        {
            Node myNode = new Node("E");
            myNode.next = new Node("B");
            myNode.next.next = new Node("E");
            myNode.next.next.next = new Node("B");
            myNode.next.next.next.next = new Node("A");
            myNode.Print();
        }
    }
}
