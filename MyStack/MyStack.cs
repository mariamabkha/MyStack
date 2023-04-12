public class MyStack<T>
{
    private List<T> list;    // Private field to store the elements of the stack using a List<T> 

    public MyStack()
    {
        list = new List<T>();   
    }

    // Property to get count of elements in stack
    public int Count
    {
        get { return list.Count; } // Uses the Count property of List<T> to get the number of elements
    }

    // push an item onto the top of the stack
    public void Push(T item)
    {
        list.Add(item);       // Adds the item to the end of the List<T> using the Add() method
    }

    // Method to pop the top item from the stack and return it
    public T Pop()
    {
        if (list.Count > 0)   // Checks if the stack is not empty
        {
            T obj = list[list.Count - 1];   // Retrieves the top element from the List<T> using the last index
            list.RemoveAt(list.Count - 1);  // Removes top element from the List<T>
            return obj;                     // Returns popped element
        }
        else
        {
            throw new InvalidOperationException("Stack is empty");  //  if stack is empty it throws exception
        }
    }

    // clear all elements from the stack
    public void Clear()
    {
        list.Clear();   
    }

    // peek at the top element in the stack without removing it
    public T Peek()
    {
        if (list.Count > 0)   
        {
            return list[list.Count - 1];   // Retrieves the top element from the List<T> using the last index
        }
        else
        {
            throw new InvalidOperationException("Stack is empty");  // Throws an exception if the stack is empty
        }
    }

    // print the stack elements and the number of elements in the stack
    public void PrintStack()
    {
        Console.WriteLine("\nStack elements:");
        foreach (T item in list)
        {
            Console.WriteLine(item);    // Prints each element in the stack
        }
        Console.WriteLine("Number of elements in the stack: " + Count);  // Prints the count of elements in the stack
    }
}

