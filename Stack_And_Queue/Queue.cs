using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queue
{
    internal class Queue
    {
        Node top = null;

        public void Enqueue(int data)
        {
            Node node = new Node(data);

            if (top == null)
                top = node;
            else
            {
                Node temp = top;

                while (temp.next != null)
                    temp = temp.next;
                
                temp.next = node;
            }
            Console.WriteLine("{0} is added to queue", node.data);
        }

        public void Dequeue()
        {
            while (top != null)
            {
                Node temp = top.next;
                Console.WriteLine($"Deleting element: {top.data}");
                top = top.next;
                Display();
            }
        }

        public void Display()
        {
            Node temp = top;

            if (top == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }

            Console.WriteLine("\nDisplaying queue elements");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}
