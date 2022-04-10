using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();    
        }
    }

}