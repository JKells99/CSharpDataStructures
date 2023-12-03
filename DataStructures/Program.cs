using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using DataStructures;
// using System.Collections.Generic;
// using System.Globalization;

// class Example
// {

//     public static void Main()
//     {
//         Stack<string> numbers = new Stack<string>();

//         numbers.Push("One");
//         numbers.Push("Two");
//         numbers.Push("Three");
//         numbers.Push("Four");
//         numbers.Push("Five");

//         foreach(string number in numbers)
//         {
//             Console.WriteLine(number);

//         }

//         Console.WriteLine("\nPopping '{0}'",numbers.Pop());
//         Console.WriteLine("Peek at next item to destack: {0}",
//         numbers.Peek());

//         Console.WriteLine("Popping '{0}'", numbers.Pop());

//         Stack<string> stack2 = new Stack<string>(numbers.ToArray());
//         Console.WriteLine("\nContents of the first copy:");
//         foreach(string number in stack2)
//         {
//             Console.WriteLine(number);
//         }

//        string[]array2 = new string[numbers.Count * 2];
//        numbers.CopyTo(array2,numbers.Count);

//        Stack<string> stack3 = new Stack<string>(array2);

//        Console.WriteLine("\nContents of the second copy with dupes");

//        foreach(string number in stack3)
//        {
//         Console.WriteLine(number);
//        }

//        Console.WriteLine("\nstack2.Contains(\"Four\") = {0}",stack2.Contains("Four"));

//        Console.WriteLine("stack2.Clear()");
//     //    stack2.Clear();

//        Console.WriteLine("stack2.Count = {0}", stack2.Count);




//     }

// }

// Custom Stack Implementation

namespace StackImplementation
{
    internal class Stack
    {
        static readonly int MAX = 1000;

        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }

        public Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;

            }
        }

        internal int Pop()
        {
             if (top < 0) 
            { 
                Console.WriteLine("Stack Underflow"); 
                return 0; 
            } 
            else
            { 
                int value = stack[top--]; 
                return value; 
            } 
        }


        internal void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow Error");
                return;
            }

            else
                Console.WriteLine("The Top Element is ", stack[top]);
        }

        internal void printStack()
        {

            if (top < 0) 
            { 
                Console.WriteLine("Stack Underflow"); 
                return; 
            }
            else
            {
                Console.WriteLine("Items In The Stack Are: ");

                for (int i = top; i >= 0; i--)
                {

                    Console.WriteLine(stack[i]);
                    
                }

            }

        }
    }


namespace DataStructures
{

     class Program
    {
        static void Main(string[] args)
        {
            // Stack myStack = new Stack();

            // myStack.Push(10);
            // myStack.Push(20);
            // myStack.Push(30);
            // myStack.Push(40);
            // myStack.Push(50);

            // myStack.printStack();

            // Book book1 = new Book();

            // book1.sayHello();

            LinkedList linkedList = new LinkedList();
            

            linkedList.AddAtLast("1");
            linkedList.AddAtLast("2");
            linkedList.AddAtLast("3");
            linkedList.AddAtLast("4");
            linkedList.AddAtLast("5");
            linkedList.AddAtLast("6");

            linkedList.PrintAllNodes();


            

        

        }
    }

}
   

    

   
}
