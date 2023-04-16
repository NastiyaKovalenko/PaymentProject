namespace PaymentApplication
{
    internal class Cash:IPayment
    {
        public float Amount { get; set; }
        public Cash(float amount)
        {
            Amount = amount;
        }
        public bool MakePayment(float sum)
        {
            if (sum < Amount)
            {
                Amount -= sum;
                return true;
            }
            return false;
        }
        public void TopUp(float sum)
        {
            Amount += sum;
        }
        public float GetBalance()
        {
            return Amount;
        }
    }
}
