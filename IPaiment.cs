namespace PaymentApplication
{
    internal interface IPayment
    {
        bool MakePayment(float amount);
        void TopUp(float amount);
        float GetBalance();

    }
}
