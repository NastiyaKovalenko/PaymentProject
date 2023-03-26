using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа2
{
    internal class ExpirationDate
    {
        public int Month { get; set; }
        public int Year { get; set; }

        public ExpirationDate (int month, int year)
        {
            Month = month;
            Year = year;
        }

        public string GetDateInformation()
        {
            return string.Format("{0} / {1}",Month,Year);

        }
    }
}
