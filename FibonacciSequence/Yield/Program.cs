using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in UserCollection.PowerofYield())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
