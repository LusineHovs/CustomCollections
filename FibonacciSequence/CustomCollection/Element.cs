using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    class Element
    {
        private string name;
        private int field1;
        private int field2;
        public Element(string s, int a, int b)
        {
            name = s;
            field1 = a;
            field2 = b;
        }
        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }
        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
