namespace PaymentApplication
{
    internal class CreditCard : PaymentCard
    {
        public float ProcentCredit { get; set; }
        
        public CreditCard(string cardnumber, ExpirationDate expirationDate, int ccv, float balance, float procentcredit)
                                                                                   : base(cardnumber, expirationDate, ccv, balance)
        {
            ProcentCredit = procentcredit;
        }
      
        public override bool MakePayment(float sum)
        {
            if (sum < Balance)
            {
                Balance -= sum;
                return true;
            }
            return false;
        }
        public override void TopUp(float sum)
        {
            Balance += sum;
        }
    }
}
