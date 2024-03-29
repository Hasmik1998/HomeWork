using System;

namespace HW1
{
    public class QueueArray
    {
        private int[] arr; 
        private int top; 
        private int maxsize; 
        public QueueArray(int size) 
        { 
            arr = new int[size]; 
            top = -1; 
            maxsize = size; 
        } 
  
        public void push(int item) 
        { 
            if (top == maxsize - 1) { 
                Console.WriteLine("Queue Overflow"); 
                return; 
            } 
            else { 
                arr[++top] = item; 
            } 
        } 
  
        public int pop() 
        { 
            if (top == -1) { 
                Console.WriteLine("Queue is Empty"); 
                return -1; 
            } 
            else {
                return arr[top--]; 
            } 
        } 
  
        public int peek() 
        { 
            if (top == -1) { 
                Console.WriteLine("Queue is Empty"); 
                return -1; 
            } 
            else {
                return arr[top]; 
            } 
        } 
  
        public void printQueue() 
        { 
            if (top == -1) { 
                Console.WriteLine("Queue is Empty"); 
                return; 
            } 
            else { 
                for (int i = 0; i < maxsize ; i++) { 
                    Console.WriteLine( arr[i]); 
                } 
            } 
        }

        public void Reverse()
        {
            int tmp = 0;
            int lastIndex = maxsize - 1;
            for (int i = 0; i <maxsize / 2; ++i)
            {
                tmp = arr[i];
                arr[i] = arr[lastIndex];
                arr[lastIndex] = tmp;
                lastIndex--;
            }
        }
    }
    
}