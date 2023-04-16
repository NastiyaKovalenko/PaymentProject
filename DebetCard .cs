namespace PaymentApplication
{
    internal class DebetCard:PaymentCard
    {
        public float DepositInterest { get; set; }

        public DebetCard(string cardnumber, ExpirationDate expirationDate, int ccv, float balance, float depositInterest)
                                                                                     :base(cardnumber, expirationDate, ccv, balance)
        {
            DepositInterest = depositInterest; 
        }

        public override bool MakePayment(float sum)
        {
            if(sum < Balance)
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
