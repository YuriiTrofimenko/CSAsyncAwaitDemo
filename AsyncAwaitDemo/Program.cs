using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 43; i++)
            {
                long resultLong = GetFib(i).Result;
                Console.WriteLine(resultLong);
            }
        }

        static long Fib(long n) {

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        async static Task<long> GetFib(long n) {

            return Fib(n);
        }
    }
}
