using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem
{
    public class InvoiceDetails
    {
        public int invoiceNumber;
        public string invoiceDescription;
        public double invoiceCost;
        public string invoicePayDate;
        public int customerNo;

        public InvoiceDetails()
        {
            invoiceNumber = 0;
            invoiceDescription = " ";
            invoiceCost = 0.00;
            invoicePayDate = " ";
            customerNo = 0;
        }
    }
}
