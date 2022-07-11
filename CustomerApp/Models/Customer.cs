namespace Models
{
    public class Customer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Address CustomerAddress { get; set; }
        public string? PhoneNumber { get; set; }

        public Customer()
        {
            FirstName = "";
            LastName = "";
            CustomerAddress = new Address();
            PhoneNumber = "";
        }

        public Customer(string? fName, string? lName, string? country, string? county,
            string? city, string? street, int? number, string? pNumber)
        {
            FirstName = fName;
            LastName = lName;
            CustomerAddress = new Address(country, county, city, street, number);
            PhoneNumber = pNumber;
        }


        public string ShowInfo()
        {
            return $"{FirstName} {LastName} - {PhoneNumber}";
        }
    }
}