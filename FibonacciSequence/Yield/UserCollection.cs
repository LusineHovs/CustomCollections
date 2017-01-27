using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    class UserCollection
    {
        public static IEnumerable PowerofYield()
        {
            string s = "Hello world";
            char[] a = s.ToArray();
            foreach (var item in a)
            {
                yield return item;
            }
        }
    }
}
