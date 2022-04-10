using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            stack.push(493);
            stack.display();
            stack.pop();
            queue.enque(56);
            queue.enque(30);
            queue.enque(70);
            queue.display();

        }
    }

}