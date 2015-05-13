namespace Part1
{
    public class Customer: Person
    {
        private string phoneNumber;

        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Phone number: {2}", FirstName, LastName, PhoneNumber);
        }
    }
}