using System.Security.Cryptography.X509Certificates;

namespace Домашняя_работа2
{
    internal class Program
    {
        static void Information(PaymentCard[] cards)
        {
            foreach (PaymentCard obj in cards)
            {
                Console.WriteLine(obj.GetFullInformation());

            }
        }
        static void Main(string[] args)
        {
           PaymentCard card1 = new PaymentCard("1234 1423 4123 4123", "10 / 23", "Alex", "Kovalenko",575);
           PaymentCard card2 = new PaymentCard("7586 2451 3648 4135", "02 / 25", "Anastasiya", "Kovalenko",310);
           PaymentCard card3 = new PaymentCard("5612 3002 3666 7777", "07 / 26", "Kira", "Kovalenko",633);
           PaymentCard card4 = new PaymentCard("7080 3002 5556 9887", "06 / 25", "Stanislav", "Moroz", 207);
           PaymentCard card5 = new PaymentCard("2589 3002 6666 6283", "11 / 26", "Nataliya", "Moroz",540);
        
           PaymentCard[] cards = new PaymentCard[] {card1,card2,card3,card4,card5};
         
           Information(cards);

        }
    }
}