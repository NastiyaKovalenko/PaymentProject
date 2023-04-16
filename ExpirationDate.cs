namespace PaymentApplication
{
    internal class ExpirationDate
    {
        public int Month { get; set; }
        public int Year { get; set; }

        public ExpirationDate (int month, int year)
        {
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return Month + "/" + Year;
        }
    }
}
