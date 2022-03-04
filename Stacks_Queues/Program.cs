   // Ability to peak pop from stack
using System;

namespace Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Push(70);
            queue.Push(30);
            queue.Push(56);
            queue.Peak_Pop();
            queue.DisplayQueue();
        }
    }
}