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
