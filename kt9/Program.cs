using System;
using System.Collections.Generic;

namespace kt9
{
    public class Stack<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("stack is empty");

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("stack is empty");

            return items[items.Count - 1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public T Max()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("stack is empty");

            T max = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
    }

    class Program
    {
        static void Main()
        {
            Stack<int> stack1 = new Stack<int>();

            stack1.Push(10);
            stack1.Push(25);
            stack1.Push(5);
            stack1.Push(40);
            stack1.Push(15);

            Console.WriteLine("stack1 max: " + stack1.Max());

            Stack<string> stack2 = new Stack<string>();

            stack2.Push("apple");
            stack2.Push("zebra");
            stack2.Push("banana");
            stack2.Push("cherry");

            Console.WriteLine("stack2 max: " + stack2.Max());

            Console.WriteLine("\nstack operations:");
            Console.WriteLine("peek: " + stack1.Peek());
            Console.WriteLine("pop: " + stack1.Pop());
            Console.WriteLine("max after pop: " + stack1.Max());

            Console.ReadLine();
        }
    }
}