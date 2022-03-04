using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    internal class Queue
    {
        public Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);

            newNode.data = data;
            newNode.next = null;
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                Node temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Peak_Pop()
        {
            while (top != null)
            {
                Console.WriteLine($"peek: {top.data}");
                top = top.next;
            }
        }

        public void DisplayQueue()
        {
            if (top == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}