using _01Bakends;
using System;
using System.Timers;

namespace _01Frontend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Time t1 = new Time(23, 58, 34, 666);
                Time t2 = new Time(1, 5, 30, 500);

                Time result = t1.Add(t2);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}