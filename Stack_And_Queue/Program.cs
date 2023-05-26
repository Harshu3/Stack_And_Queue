using System;
using System.Diagnostics;

namespace Stack_And_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program!");
            Console.WriteLine("Program to create a Simple Stack!\n");
            Stack st = new Stack();
            st.Push(70);
            st.Push(30);
            st.Push(56);
            st.Display();
        }
    }
}