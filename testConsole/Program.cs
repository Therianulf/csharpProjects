using System;
using System.Runtime.InteropServices;

namespace CACSProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            Console.WriteLine("Hello World! what is your name?");
            myEmployee.Name = Console.ReadLine();
            Console.WriteLine("Hello World! how old are you?");
            myEmployee.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.UserName);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            XmlSerialization.WriteToXmlFile<Employee>("/Users/ben.larson/employee.txt", myEmployee);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            XmlSerialization.WriteToXmlFile<Employee>("C:/Users/benl/employee.txt", myEmployee);
            Console.WriteLine("thank you! we have written that info to file.");
        }
    }


    public class Employee {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; }


    }



}
