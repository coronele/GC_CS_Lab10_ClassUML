using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CS_Lab10_ClassUML
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public Student () { }

        public Student(string _name, string _address, string _program, int _year, double _fee)
        {
            base.Name = _name;
            base.Address = _address;
            program = _program;
            year = _year;
            fee = _fee;
        }

        public override string ToString()
        {
            return ($"Student[Person[name = {Name}, address = {Address}], program={Program}, year={Year}, fee={Fee}]");
        }

    }
}
