using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_And_Queue
{
    internal class Stack
    {
        public Node top;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is added into stack", newNode.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is added into stack", newNode.data);
            }
        }

        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                Console.WriteLine("{0} node is topmost element", top.data);
                return top.data;
            }
        }

        public void Pop()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                int delData = Peek();
                top = top.next;
                Console.WriteLine("{0} is deleted\n", delData);
            }
        }

        public void IsEmpty()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");

            while (top != null)
                Pop();
        }

        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                Node temp = top;
                Console.WriteLine("\nDisplaying stack elements");

                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.Write("\n");
            }
        }
    }
}
