using System;
using System.Runtime.InteropServices;

namespace CACSproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            Console.WriteLine("what is your name?");
            myEmployee.Name = Console.ReadLine();
            Console.WriteLine("how old are you?");
            myEmployee.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your title?");
            myEmployee.Title = Console.ReadLine();
            Console.WriteLine("What is your salary?");
            myEmployee.Salary = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("give pay raise?");
            bool increase = Convert.ToBoolean(Console.ReadLine());
            if (increase)
                myEmployee.IncreaseSalary();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                XmlSerialization.WriteToXmlFile<Employee>("/Users/" + Environment.UserName + "/employee.txt", myEmployee);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                XmlSerialization.WriteToXmlFile<Employee>("C:/Users/" + Environment.UserName + "/employee.txt", myEmployee);
            Console.WriteLine("thank you! we have written that info to file.");
        }
    }
}
