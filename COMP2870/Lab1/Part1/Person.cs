namespace Part1
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = lastName;
            LastName = firstName;
        }
    }
}