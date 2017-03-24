using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assess2Tests
{


    public partial class Form1 : Form
    {

        int count = 0; //Determines maximum spot in the array
        CustomerDetails[] allCustomers = new CustomerDetails[100];

        public Form1()
        {

            InitializeComponent();
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            //Needs some sort of statement to catch blank inputs

            allCustomers[count] = new CustomerDetails();
            allCustomers[count].CustomerName = txtCustName.Text;
            allCustomers[count].CustomerNumber = Convert.ToInt32(txtCustNumber.Text);
            allCustomers[count].CustomerAddress = txtCustAddress.Text;
            allCustomers[count].CustomerContact = Convert.ToInt32(txtCustContact.Text);
            count++;



        }

        private void btnLoadCust_Click(object sender, EventArgs e)
        {

            for (int i= 0; i < count; i++)
            {
                if (txtCustName.Text == allCustomers[i].CustomerName)
                {
                    txtCustNumber.Text = Convert.ToString(allCustomers[i].CustomerNumber);
                    txtCustAddress.Text = allCustomers[i].CustomerAddress;
                    txtCustContact.Text = Convert.ToString(allCustomers[i].CustomerContact);

                }

         } 

        
        }
    }
}
