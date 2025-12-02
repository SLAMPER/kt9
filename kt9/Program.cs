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
            Console.WriteLine($"add(5, 3): {Calculator<int>.Add(5, 3)}");
            Console.WriteLine($"zero(): {calc1.Zero()}");

            Console.WriteLine();

            Calculator<double> calc2 = new Calculator<double>();
            Console.WriteLine($"add(2.5, 3.7): {Calculator<double>.Add(2.5, 3.7)}");
            Console.WriteLine($"zero(): {calc2.Zero()}");

            Console.WriteLine();

            Calculator<MyNumber> calc3 = new Calculator<MyNumber>();
            MyNumber num1 = new MyNumber(10);
            MyNumber num2 = new MyNumber(20);

            Console.WriteLine($"add: {Calculator<MyNumber>.Add(num1, num2)}");
            Console.WriteLine($"zero: {calc3.Zero()}");

            Console.ReadLine();
        }
    }
}
}
