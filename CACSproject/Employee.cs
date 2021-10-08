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
            this.Salary = this.Salary + (this.Salary * 0.08F);
        }
    }
}
