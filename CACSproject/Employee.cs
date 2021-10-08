using System;
using System.Collections.Generic;
using System.Text;

namespace CACSproject
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public float Salary { get; set; }
        public void IncreaseSalary()
        {
            Salary = Salary + Salary * 0.08F;
        }
    }
}
