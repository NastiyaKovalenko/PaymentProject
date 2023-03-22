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
        private string Cardnumber;
        private string Expirationdate;
        private string Firstname;
        private string Lastname;
        private int Ccv;

        public PaymentCard (string cardnumber, string expirationdate, string firstname, string lastname, int ccv)
        {
            Cardnumber = cardnumber;
            Expirationdate = expirationdate;
            Firstname = firstname;
            Lastname = lastname;
            Ccv = ccv;


        }
        public string GetFullInformation()
        {
            return String.Format("Cardnumber:{0}, Expirationdate: {1}, Firstname: {2}, Lastname: {3} , Ccv: {4}", Cardnumber, Expirationdate, Firstname, Lastname, Ccv);


        }

       
    }
}
