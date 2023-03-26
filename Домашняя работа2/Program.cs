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

            Address address1 = new Address ("Poland", "Poznan", "Sowia", "1", 17, 310520);
            Address address2 = new Address("Poland", "Poznan", "Sowia", "1", 17, 310520);
            Address address3 = new Address("Poland", "Poznan", "Sowia", "1", 17, 310520);
            Address address4 = new Address("Belarus", "Grodno", "Gorkogo", "78/1", 34, 200305);
            Address address5 = new Address("Belarus", "Grodno", "Gorkogo", "78/1", 34, 200305);

            Person person1 = new Person ("Alex", "Kovalenko",address1,5712607);
            Person person2 = new Person ("Anastasiya", "Kovalenko",address2,3105204);
            Person person3 = new Person ("Kira", "Kovalenko",address3,6663208);
            Person person4 = new Person ("Stanislav", "Moroz",address4,4925213);
            Person person5 = new Person ("Nataliya", "Moroz",address5,5628901);

            ExpirationDate expirationDate1 = new ExpirationDate (10, 23);
            ExpirationDate expirationDate2 = new ExpirationDate (02, 25);
            ExpirationDate expirationDate3 = new ExpirationDate (07, 26);
            ExpirationDate expirationDate4 = new ExpirationDate (06, 25);
            ExpirationDate expirationDate5 = new ExpirationDate (11, 26);

           PaymentCard card1 = new PaymentCard ( person1, "1234 1423 4123 4123", expirationDate1, 575);
           PaymentCard card2 = new PaymentCard (person2, "7586 2451 3648 4135", expirationDate2, 310);
           PaymentCard card3 = new PaymentCard (person3, "5612 3002 3666 7777", expirationDate3, 633);
           PaymentCard card4 = new PaymentCard (person4, "7080 3002 5556 9887", expirationDate4, 207);
           PaymentCard card5 = new PaymentCard (person5, "2589 3002 6666 6283", expirationDate5, 540);
        
           PaymentCard[] cards = new PaymentCard[] {card1,card2,card3,card4,card5};
         
           Information(cards);

        }
    }
}