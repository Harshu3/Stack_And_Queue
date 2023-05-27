using System;
using System.Diagnostics;

namespace Stack_And_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program!");
            Console.WriteLine("Program to Dequeue elements from Queue!\n");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
        }
    }
}