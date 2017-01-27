using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();
            foreach (Element element in myCollection)
            {
                Console.WriteLine($"{element.Name}, {element.Field1}, {element.Field2}");
            }
            // myCollection.Reset();

            // HOW DOES WORK FOREACH!!!

            //UserCollection myElementsCollection = new UserCollection();
            //IEnumerable enumerable = myElementsCollection as IEnumerable;
            //IEnumerator enumerator = enumerable.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Element element = enumerator.Current as Element;
            //    Console.WriteLine($"{ element.Name}, { element.Field1}, { element.Field2}");
            //}
            //enumerator.Reset();
        }
    }
}
