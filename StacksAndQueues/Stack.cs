using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    class Stack
    {
        private int[] array;
        private int top;
        private int size;

        public Stack(int size)
        {
            array = new int[size];
            top = -1;
            this.size = size;
        }

        public void Push(int data)
        {
            if ((IsFull()))
            {
                Console.WriteLine("Stack Overflow, cannot add new data");
                return;
            }
            top += 1;
            array[top] = data;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            int data = 0;
            data = array[top];
            Console.WriteLine("Retrieved: " + array[top]);

            top -= 1;

            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            else
                return array[top];
        }

        public void DisplayStack()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");

            int counter = 0;
            Console.Write("Current Stack: ");
            while (counter <= top)
            {
                Console.Write(array[counter] + " ");
                counter += 1;
            }
        }

        public int DisplayStackSize()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return size;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top + 1 == size);
        }
    }
}
