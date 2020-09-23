using System;
using System.Collections.Generic;
using System.Text;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        public decimal PaymentDue { get; set; }

        public string Display // metoda dispaly pentru vendors
        {
            get
            {
                return string.Format("{0} {1} - ${2} ", FirstName, LastName, PaymentDue);
            }
        }

        public Vendor() // construcor vendor pentru default commission .5
        {
            Commission = .5;
        }

    }
}
