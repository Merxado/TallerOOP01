using _01Bakends;
using System;

namespace _01Frontend
{
    internal class Main
    {
        static void Main(string[] args)
        {
            try
            {
                Time t1 = new Time();
                Time t2 = new Time(10);
                Time t3 = new Time(23, 58, 34, 666);
                Time t4 = new Time(5, 10, 20, 300);
                Time t5 = new Time(12, 30, 15);

                Console.WriteLine("Horas originales:");
                Console.WriteLine($"t1: {t1}");
                Console.WriteLine($"t2: {t2}");
                Console.WriteLine($"t3: {t3}");
                Console.WriteLine($"t4: {t4}");
                Console.WriteLine($"t5: {t5}");

                Console.WriteLine("\nSumando cada hora con t3:");

                Time[] times = { t1, t2, t3, t4, t5 };

                foreach (Time t in times)
                {
                    Time result = t.Add(t3);
                    Console.WriteLine($"{t} + {t3} = {result}");
                }

                Console.WriteLine("\nVerificando si pasa al siguiente día con t4:");

                foreach (Time t in times)
                {
                    bool otherDay = t.IsOtherDay(t4);
                    Console.WriteLine($"{t} + {t4} pasa al otro día? {otherDay}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}