using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem
{
    public class CustomerDetails
    {
        public string CustomerName;
        public int CustomerNumber;
        public string CustomerAddress;
        public int CustomerContact;

        public CustomerDetails()
        {
            CustomerName = " ";
            CustomerNumber = 0;
            CustomerAddress = " ";
            CustomerContact = 0;
        }


    }
}
