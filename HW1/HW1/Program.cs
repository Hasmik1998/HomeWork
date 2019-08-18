using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray stack = new StackArray(4);
            stack.push(1);
            stack.push(2); 
            stack.push(3);
            stack.push(4);
            stack.Reverse();
            stack.printStack();
        }
    }
}