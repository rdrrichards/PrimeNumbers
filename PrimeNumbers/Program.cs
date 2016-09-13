using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2, how_many_have = -16, how_many_want = 10001, final_number = 0;
            //const bool DEBUG = false;
            DateTime start = DateTime.Now, end;

            while (how_many_have <= how_many_want)
            {
                if (IsPrime(num))
                {
                    //if (DEBUG) Console.WriteLine($"Prime #{how_many_have}: {num}");
                    final_number = num;
                    how_many_have++;
                }
                num++;
            }
            end = DateTime.Now;
            TimeSpan dur = end - start;
            Console.WriteLine($"Final Prime: {final_number}");
            Console.WriteLine($"Elapsed time: {dur}");
            //Console.ReadLine();
        }

        private static bool IsPrime(int num)
        {
            int c = 0, n = (num + 1) / 8;
            for (int i = 2; i < n; i++)
            {
                c++;
                if (num % i == 0) { //Console.WriteLine($"Looped: {c} times on {num}");
                    return false; };
            }
            //Console.WriteLine($"Looped: {c} times on {num}");
            return true;
        }
    }
}
