using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data;

            Stack stack = new Stack();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1. Push new data to the stack");
                Console.WriteLine("2. Pop data from the stack");
                Console.WriteLine("3. Display the top element of the stack");
                Console.WriteLine("4. Display the stack elements");
                Console.WriteLine("5. Display the stack size");
                Console.WriteLine("0. Quit");


                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the data to be added to the stack: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        break;
                    case 2:
                        Console.WriteLine("Retrieved " + stack.Pop() + " from the stack");
                        break;
                    case 3:
                        Console.WriteLine(stack.Peek());
                        break;
                    case 4:
                        stack.DisplayStack();
                        break;
                    case 5:
                        //Console.WriteLine("Stack size is: " + stack.DisplayStackSize());
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
