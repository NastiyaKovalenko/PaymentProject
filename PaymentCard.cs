namespace  PaymentApplication
{
     internal abstract class PaymentCard :IPayment
    {
        public string Cardnumber {get; private set; }
        public ExpirationDate ExpirationDate { get; set; }
        public int Ccv { get; set; }
        public float Balance { get; set; }

        public PaymentCard (string cardnumber, ExpirationDate expirationDate, int ccv, float balance)
        {
            Cardnumber = cardnumber;
            ExpirationDate = expirationDate;
            Ccv = ccv;
            Balance = balance;
        }
      
        public abstract bool MakePayment(float sum);
        public abstract void TopUp(float sum);
        public float GetBalance()
        {
            return Balance;
        }
    }
}
