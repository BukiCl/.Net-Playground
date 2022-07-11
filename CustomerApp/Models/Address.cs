namespace Models
{
    public class Address
    {
        public string? Country { get; set; }
        public string? County { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int? Number { get; set; }

        public Address()
        {
            Country = "";
            County = "";
            City = "";
            Street = "";
            Number = 0;
        }

        public Address(string? country, string? county, string? city, string? street, int? number)
        {
            Country = country;
            County = county;
            City = city;
            Street = street;
            Number = number;
        }
    }
}
