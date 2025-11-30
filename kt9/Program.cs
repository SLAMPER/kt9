/*

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

            Console.WriteLine("stack1 " + stack1.GetType());

            Stack<string> stack2 = new Stack<string>();

            stack2.Push("apple");
            stack2.Push("zebra");
            stack2.Push("banana");
            stack2.Push("cherry");

            Console.WriteLine("stack2 " + stack2.GetType());

            Console.WriteLine("\nstack operations:");
            Console.WriteLine("peek: " + stack1.Peek());
            Console.WriteLine("pop: " + stack1.Pop());
            Console.WriteLine("max after pop: " + stack1.Max());

            Console.ReadLine();
        }
    }
}

*/

/*
 
using System;

namespace kt9
{
    public class Pair<T, U> where T : class where U : class
    {
        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public void Swap()
        {
            T temp = First;
            First = (T)(object)Second;
            Second = (U)(object)temp;
        }

        public void Print()
        {
            Console.WriteLine($"first {First}, second {Second}");
        }
    }

    class Program
    {
        static void Main()
        {
            Pair<string, string> pair1 = new Pair<string, string>("Hello", "World");
            Console.WriteLine("before swap:");
            pair1.Print();

            pair1.Swap();
            Console.WriteLine("after swap:");
            pair1.Print();

            Console.WriteLine();

            Pair<object, object> pair2 = new Pair<object, object>(100, "Text");
            Console.WriteLine("before swap:");
            pair2.Print();

            pair2.Swap();
            Console.WriteLine("after swap:");
            pair2.Print();

            Console.ReadLine();
        }
    }
}

*/

using System;

namespace kt9
{
    public class Calculator<T> where T : new()
    {
        public static T Add(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx + dy;
        }

        public T Zero()
        {
            return new T();
        }
    }

    public class MyNumber
    {
        public int Value { get; set; }

        public MyNumber()
        {
            Value = 0;
        }

        public MyNumber(int value)
        {
            Value = value;
        }

        public static MyNumber operator +(MyNumber a, MyNumber b)
        {
            return new MyNumber(a.Value + b.Value);
        }

        public override string ToString()
        {
            return $"MyNumber: {Value}";
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator<int> calc1 = new Calculator<int>();
            Console.WriteLine($"Add(5, 3): {Calculator<int>.Add(5, 3)}");
            Console.WriteLine($"Zero(): {calc1.Zero()}");

            Console.WriteLine();

            Calculator<double> calc2 = new Calculator<double>();
            Console.WriteLine($"Add(2.5, 3.7): {Calculator<double>.Add(2.5, 3.7)}");
            Console.WriteLine($"Zero(): {calc2.Zero()}");

            Console.WriteLine();

            Calculator<MyNumber> calc3 = new Calculator<MyNumber>();
            MyNumber num1 = new MyNumber(10);
            MyNumber num2 = new MyNumber(20);

            Console.WriteLine($"Add: {Calculator<MyNumber>.Add(num1, num2)}");
            Console.WriteLine($"Zero: {calc3.Zero()}");

            Console.ReadLine();
        }
    }
}