namespace PaymentApplication
{
    internal class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public int Appartment { get; set; }
        public int PostCode { get; set; }

        public Address( string country, string city, string street, string homeNumber, int appartment, int postcode )
        {
            Country = country;
            City = city;
            Street = street;
            HomeNumber = homeNumber;
            Appartment = appartment;
            PostCode = postcode;
        }
        public override string ToString()
        {
            return string.Format ("Country:{0}, City: {1}, Street:{2}, HomeNumber: {3}, Appartment: {4}, Posctcode: {5}", Country, City, Street, HomeNumber, Appartment, PostCode);
        }
    }
}
