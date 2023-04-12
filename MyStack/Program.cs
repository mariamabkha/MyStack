using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine("stack elements:");
        stack.PrintStack();

        // Pop and print 
        Console.WriteLine("\nPop elements from the stack:");
        while (stack.Count > 0)
        {
            int item = stack.Pop();
            Console.WriteLine("Popped : " + item);
        }

        // Try to peek at the top element when the stack is empty - throws exception
        try
        {
            int peekItem = stack.Peek();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("\nException: " + ex.Message);
        }

        // Try to pop - throws exception
        try
        {
            int popItem = stack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        // Clear and print the remaining elements
        stack.Clear();
        Console.WriteLine("\nStack elements after clearing:");
        stack.PrintStack();

        // Push new elements onto the stack
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);

        Console.WriteLine("\nnew stack elements:");
        stack.PrintStack();

        // Peek at the top element without popping it
        int topItem = stack.Peek();
        Console.WriteLine("\nPeeked item: " + topItem);

        // Print the final count of elements in the stack
        Console.WriteLine("\nFinal count of elements in the stack: " + stack.Count);

    }
}



