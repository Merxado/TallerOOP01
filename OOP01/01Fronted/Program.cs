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
                Time t = new Time(1, 1, 0, 0);
                Console.WriteLine(t.ToSeconds());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}