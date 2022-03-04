   // Ability to peak pop from stack
using System;

namespace Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListStack linkListStack = new LinkListStack();
            linkListStack.Push(70);
            linkListStack.Push(30);
            linkListStack.Push(56);
            linkListStack.Peak_Pop();
            linkListStack.Display();
        }
    }
}