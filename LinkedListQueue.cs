using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class LinkedListQueue
    {
        private Node last;
        private Node first;
        public LinkedListQueue()
        {
            last = null;
            first = null;
        }
        public void enque(int data)
        {
            Node newNode = new Node(data);
            if (last == null && first == null)
            {
                last = newNode;
                first = newNode;
            }
            else
            {
                last.next = newNode;
                last=newNode;
            }
        }
        public void display()
        {
            Console.WriteLine("\nDisplaying added nodes");
            Node temp = this.first;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("" + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
