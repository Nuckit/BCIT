namespace Part1
{
    public class Employee : Person
    {
        private int age;
        private decimal salary;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2}, Salary: {3}", FirstName, LastName, Age, Salary);
        }
    }
}