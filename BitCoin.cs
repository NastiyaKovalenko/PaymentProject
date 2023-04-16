
namespace PaymentApplication
{
    internal class BitCoin : IPayment
    {
        public float Amount { get; set; }
        public float ExchangeRate { get; set; }
       
        public BitCoin (float amount, float exchangeRate)
        {
            Amount = amount;
            ExchangeRate = exchangeRate;
        }
        public bool MakePayment(float sum)
        {
            if (sum < GetBalance())
            {
                Amount-=sum/ExchangeRate;
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
            return Amount* ExchangeRate;
        }
    }
}

