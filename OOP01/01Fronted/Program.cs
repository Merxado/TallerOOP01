using _01Bakends;
using System;

namespace _01Frontend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Time t = new Time(23, 58, 34, 666);
                Console.WriteLine(t);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}