namespace PaymentApplication
{
    internal class Program
    {
        static void Payment(List<BankClient> bankClients,float sum)
        {             
            foreach (BankClient bankclient in bankClients)
            {
                bool payResult = bankclient.Pay(sum);
                if (payResult== true) 
                
                    Console.WriteLine("Payment was successful for " + bankclient.Firstname + " " + bankclient.Lastname + ", sum " + sum);
                else      
                    Console.WriteLine("Payment was failed for " + bankclient.Firstname + " " + bankclient.Lastname + ", sum " + sum);
             }

        }
        static void BalanceInformation(List<BankClient> bankClients)
        {
            foreach (BankClient bankclient in bankClients)
            {
                Console.WriteLine("Payments of "+ bankclient.Firstname + " " + bankclient.Lastname);
                foreach (IPayment payment in bankclient.Payments)
                {
                    Console.WriteLine(payment.GetBalance());
                }
            }
        }
        
     static void Main(string[] args)
        {
            Address address1 = new("Poland", "Poznan", "Sowia", "1", 17, 310520);
            Address address2 = new("Belarus", "Grodno", "Gorkogo", "78/1", 34, 200305);
  
            ExpirationDate expirationDate1 = new(10, 23);
            ExpirationDate expirationDate2 = new(02, 25);
            ExpirationDate expirationDate3 = new(07, 26);
            ExpirationDate expirationDate4 = new(06, 25);
            ExpirationDate expirationDate5 = new(11, 26);

            PaymentCard card1 = new DebetCard("1234 1423 5555 4123", expirationDate1, 321, 30, 7);
            PaymentCard card2 = new CreditCard("2589 3002 6666 6280", expirationDate2, 560, 700, 10);
            PaymentCard card3 = new CreditCard("5612 3002 3666 7777", expirationDate3, 633, 1000, 3);
            PaymentCard card4 = new DebetCard("7080 3002 5556 9887", expirationDate4, 207, 400, 5);
            PaymentCard card5 = new CashBackCard("2589 3002 6666 6283", expirationDate5, 540, 100, 3);

            Cash payment1 = new(5);
            Cash payment2 = new(100);

            BitCoin payment3 = new(1,90000);
           
            List< IPayment> payments1 = new List< IPayment>() { card1, card3, card5,payment1};
            List<IPayment> payments2 = new  List<IPayment>() { card2, card4, payment2,payment3};

            BankClient bankClient1 = new("Alex", "Kovalenko", address1, 5712607, payments1);
            BankClient bankClient2 = new("Nataliya", "Moroz", address2, 5628901, payments2);

            List<BankClient> bankClients = new List<BankClient>() { bankClient1, bankClient2 };

            Payment(bankClients,1500);
            Payment(bankClients, 1000000000);
            BalanceInformation(bankClients);
        }
    }
}