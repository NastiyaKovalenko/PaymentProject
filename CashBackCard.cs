namespace PaymentApplication
{
    internal class CashBackCard: PaymentCard
    {
        public float CashBack { get; set; }
        
        public CashBackCard( string cardnumber, ExpirationDate expirationDate, int ccv,float balance,float cashback)
                                                                               : base(cardnumber, expirationDate, ccv,balance)
        {
            CashBack = cashback;
        }
      
        public  override bool MakePayment(float sum)
        {
            if (sum < Balance)
            {
                Balance = Balance - sum + CashBack;
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
