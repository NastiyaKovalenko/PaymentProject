using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа2
{
    internal class PaymentCard
    {
        public Person Person { get; set; }
        public string Cardnumber {get; set; }
        public ExpirationDate ExpirationDate { get; set; }
        
        public int Ccv { get; set; }

        public PaymentCard (Person person,string cardnumber, ExpirationDate expirationDate,int ccv)
        {
            Person = person;
            Cardnumber = cardnumber;
            ExpirationDate = expirationDate;
            Ccv = ccv;

        }
        public string GetFullInformation()
        {
            return String.Format("{0},\n Cardnumber: {1},\n ExpirationDate: {2},\n Ccv: {3}", Person.GetPersonInformation(),Cardnumber, ExpirationDate.GetDateInformation() ,Ccv);


        }

       
    }
}
