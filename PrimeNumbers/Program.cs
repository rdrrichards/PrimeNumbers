using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int in_val = ParseArgs(args);
            GetPrime(in_val > 0 ? in_val : 10001);
        }

        /// <summary>
        /// This function parses any passed in arguments
        /// this application only accepts one arg
        /// </summary>
        /// <param name="args"></param>
        /// <returns>int</returns>
        private static int ParseArgs(string[] args)
        {
            int arg1;
            if (args.Length == 1)
            {
                if (int.TryParse(args[0], out arg1))
                    return arg1;
            }
            return 0;
        }

        /// <summary>
        /// This starts the work of getting the desired prime number
        /// </summary>
        /// <param name="which_one"></param>
        private static void GetPrime(int which_one)
        {
            int num = 2, how_many_have = -16, how_many_want = which_one, final_number = 0;
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

        /// <summary>
        /// This validates that the num passed in is a prime number
        /// Prime numbers are only divisible by 1 and themselves
        /// This does some short cutting for performance. We avoid looping when we don't need to.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>true if prime number, otherwise false</returns>
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
