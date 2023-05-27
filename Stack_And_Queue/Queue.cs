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

        public void Display()
        {
            Node temp = top;

            if (temp == null)
                Console.WriteLine("Queue is empty");

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
