using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab10_ClassUML
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        public Staff() { }
        
        public Staff(string _name, string _address, string _school, double _pay)
        {
            base.Name = _name;
            base.Address = _address;
            school = _school;
            pay = _pay;
        }

        public override string ToString()
        {
            return ($"Student[Person[name = {Name}, address = {Address}], school={School}, pay={Pay}]");
        }


    }
}
