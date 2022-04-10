using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class LinkedListStack
    {
        //private Node first;
        private Node last;
        public LinkedListStack()
        {
            last = null;
        }
        public void push(int data)
        {
            Node newNode = new Node(data);
            if(last == null)
            {
                last = newNode;
            }
            else
            {
                newNode.next = last;
                last=newNode;
            }
        }
        public void display()
        {
            Console.WriteLine("\nDisplaying added nodes");
            Node temp = this.last;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
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
