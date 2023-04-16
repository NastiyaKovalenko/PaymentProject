namespace PaymentApplication
{
    internal class BankClient
    {
        public string Firstname { get; }
        public string Lastname { get; set; }
        public Address Address { get; set; }
        public int MobileNumber { get; set; }
        public List<IPayment> Payments { get; set; }

        public BankClient(string firstName, string lastName, Address address, int mobileNumber, List<IPayment> payments)
        {
            Firstname = firstName;
            Lastname = lastName;
            Address = address;
            MobileNumber = mobileNumber;
            Payments = payments;
        }
       
        public bool Pay(float sum)
        {
            foreach (IPayment payment in Payments)
            {
                if (payment is Cash cash && cash.Amount >= sum)
                {
                    cash.MakePayment(sum);
                    return true;
                }
            }
            CashBackCard? maxCashBackCard = null;
            foreach (IPayment payment in Payments)
            {
                if (payment is CashBackCard cashBackCard && cashBackCard.Balance >= sum)
                {
                    if (maxCashBackCard == null)
                    {
                        maxCashBackCard = cashBackCard;
                    }
                    else if (maxCashBackCard.CashBack < cashBackCard.CashBack)
                    {
                        maxCashBackCard = cashBackCard;
                    }
                }
            }
            if (maxCashBackCard != null)
            {
                maxCashBackCard.MakePayment(sum);
                return true;
            }
            foreach (IPayment payment in Payments)
            {
                if (payment is DebetCard debetCard && debetCard.Balance >= sum)
                {
                    payment.MakePayment(sum);
                    return true;
                }
            }
            CreditCard? minProcentCredit = null;
            foreach (IPayment payment in Payments)
            {
                if (payment is CreditCard creditCard && creditCard.Balance >= sum)
                {
                    if (minProcentCredit == null)
                    {
                        minProcentCredit = creditCard;
                    }
                    else if (minProcentCredit.ProcentCredit < creditCard.ProcentCredit)
                    {
                        minProcentCredit = creditCard;
                    }
                }
            }
            if (minProcentCredit != null)
            {
                minProcentCredit.MakePayment(sum);
                return true;
            }
            foreach (IPayment payment in Payments)
            {
                if (payment is BitCoin bitCoin && bitCoin.GetBalance() >= sum)
                {
                    bitCoin.MakePayment(sum);
                    return true;
                }
            }
            return false;
        }
    }
}