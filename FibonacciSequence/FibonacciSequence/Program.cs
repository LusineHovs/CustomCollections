using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        public static IEnumerable<int> GetFibonacciNumber()
        {
            int previous = 0;
            int current = 1;

            yield return current;

            for (int i = 0; i < 45; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
                yield return next;
            }
        }
        static void Main(string[] args)
        {
            foreach (var item in GetFibonacciNumber().Take(10))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
