using System;
using System.Collections.Generic;

namespace GC_CS_Lab10_ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueProg = "y";
            List<Person> peopleList = new List<Person>();

            BuildAList(peopleList);
            PrintPersonList(peopleList);

            do
            {
                AddPersonToList(peopleList);
                PrintPersonList(peopleList);
            }
            while (continueProg == "y");
        }

        public static void AddPersonToList(List<Person> thePersonList)
        {
            int userOption = -1;

            Console.WriteLine("1)\t Add a student");
            Console.WriteLine("2)\t Add a staff member");
            
            while (!(int.TryParse(GetUserInput("Enter an option"), out userOption)))
            {
                if ((userOption != 1) || (userOption != 2))
                {
                    AddPersonToList(thePersonList);
                }
            }
            if (userOption == 1)
            {
                Student student = new Student(GetUserInput("Please enter student's name"), GetUserInput("Please enter student's address"),
                                    GetUserInput("Please enter student's program"), int.Parse(GetUserInput("Please enter students' year of graduation")),
                                    double.Parse(GetUserInput("Please enter student's fee")));
                thePersonList.Add(student);
            }
            else
            {
                
                Staff staff = new Staff(GetUserInput("Please enter staff member's name"), GetUserInput("Please enter staff member's address"),
                    GetUserInput("Please enter staff member's school"), double.Parse(GetUserInput("Please enter staff member's rate of pay")));
                thePersonList.Add(staff);
            }
        }

        public static void PrintPersonList(List<Person> thePersonList)
        {
            foreach (Person peeps in thePersonList)
            {
                Console.WriteLine(peeps.ToString());
            }
        }

        public static void BuildAList(List<Person> thePersonList)
        {
            Student Jack = new Student("Jack", "123 Sesame Street", "C#", 2020, 25.23);
            Staff Jeff = new Staff("Jeff","1570 Woodward Ave","Grand Circus",22.14);
            Student Suzie = new Student("Suzie", "35906 Gratiot", "Javascript", 2023, 18.73);
            Student Max = new Student("Max", "27345 Telegraph Rd", "Front-end", 2021, 23.10);
            Staff Jessica = new Staff("Jessica", "2456 Little Mack", "After Hours C#", 35.99);
            thePersonList.Add(Jack);
            thePersonList.Add(Jeff);
            thePersonList.Add(Suzie);
            thePersonList.Add(Max);
            thePersonList.Add(Jessica);
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
