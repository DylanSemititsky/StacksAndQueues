using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node temp = new Node(data);

            if (top == null)
            {
                top = temp;
                return;
            }
            temp.next = top;
            top = temp;
        }

        public int Pop()
        {
            if (top == null)
                throw new System.InvalidOperationException("Stack Underflow");

            int info = top.info;
            top = top.next;

            return info;
        }

        public int Peek()
        {
            if (top == null)
                return 0;
            //throw new System.InvalidOperationException("Stack Underflow");
            else
                return top.info;
        }

        public void DisplayStack()
        {
            if (top == null) // If stack is empty
            {
                //throw new System.InvalidOperationException("Stack Underflow");
                Console.WriteLine("Stack Underflow, nothing to display");
                return;
            }

            Console.WriteLine("Current Stack: ");

            if (top.next == null) // If stack has only one node
            {
                Console.WriteLine(top.info);
                return;
            }

            Node p;
            p = top;

            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.next;
            }
        }

    }
}
