using System;

namespace testConsole
{
    class Program
    {

        static int tickCount = 0;
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.Age = 32;
            myEmployee.Name = "Ben";
            Console.WriteLine("Hello World! I am "+myEmployee.Age+" years old TickCount = " + tickCount.ToString());
            tickCount++;
            Console.WriteLine("Hello World! its me "+ myEmployee.Name +". TickCount = " + tickCount.ToString());
            XmlSerialization.WriteToXmlFile<Employee>("/Users/ben.larson/employee.txt", myEmployee);
        }
    }


    public class Employee {
        public string Name { get; set; }
        public int Age { get; set; }
    }



}
