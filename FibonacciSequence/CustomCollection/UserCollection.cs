using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    class UserCollection : IEnumerable, IEnumerator
    {
        Element[] elementsArray = null;
        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 10, 15);
            elementsArray[1] = new Element("B", 11, 16);
            elementsArray[2] = new Element("C", 12, 17);
            elementsArray[3] = new Element("D", 13, 17);

        }


        //  Collectionin apahov dostup e apahovum
        int position = -1;

        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                return elementsArray[position];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
