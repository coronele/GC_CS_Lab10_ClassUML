using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab10_ClassUML
{
    abstract class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    public override string ToString()
        {
            return ($"Person[name = {Name}, address = {Address}]");
        }

    }
}
