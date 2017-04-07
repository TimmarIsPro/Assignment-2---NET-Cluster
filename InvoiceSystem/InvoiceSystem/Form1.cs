using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//A good piece of software by Timothy Stewart.
//This program allows a user to input and save customer and invoice details to an array, and provides the ability to edit and
//load these details. In addition an option to change the background is included.

namespace InvoiceSystem
{
    public partial class Form1 : Form
    {
        //Declaring arrays of type class
        CustomerDetails[] allCustomers = new CustomerDetails[100];
        InvoiceDetails[] allInvoices = new InvoiceDetails[100];

        int ccount = 0;  //Determines maximum spot in the Customer Details array
        int ceditcount = 0; //Determines point in Customer Details array when editing
        int icount = 0; //Determines maximum point in the Invoice Details array
        int ieditcount = 0; //Determines point in Invoice Details array when editing


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)//btnEditCustomer
        {      
            //locates the position in the customers array that matches what is currently loaded, and prepares to edit it
            for (int i = 0; i < ccount; i++)
            {
                if (ceditcount == i)
                {
                    allCustomers[i].CustomerName = txtCustName.Text;
                    allCustomers[i].CustomerNumber = Convert.ToInt32(txtCustNo.Text);
                    allCustomers[i].CustomerAddress = txtCustAddress.Text;
                    allCustomers[i].CustomerContact = Convert.ToInt32(txtCustContact.Text);
                    lblCustLabel.Text = "Customer Information Edited.";//this, and other custLabel/invoiceLabel provide a response to confirm the action.
                }
            }
                     
        }

        private void button1_Click(object sender, EventArgs e)//btnLoadCustomer
        {
            //Search the array for the customer name that matches the name in the customer name textbox
            for (int i = 0; i < ccount; i++)
            {
                if (txtCustName.Text == allCustomers[i].CustomerName)
                {
                    txtCustNo.Text = Convert.ToString(allCustomers[i].CustomerNumber);
                    txtCustAddress.Text = allCustomers[i].CustomerAddress;
                    txtCustContact.Text = Convert.ToString(allCustomers[i].CustomerContact);
                    ceditcount = i;
                    lblCustLabel.Text = "Customer Information loaded.";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//btnEditInvoice
        {
            //Locates the position in the invoices array that matches what is currently loaded,
            //and edits the invoice details.
            for (int i = 0; i < icount; i++)
            {
                if (ieditcount == i)
                {
                    allInvoices[i].invoiceDescription = txtInvDesc.Text;
                    allInvoices[i].invoiceCost = Convert.ToDouble(txtInvCost.Text);
                    allInvoices[i].invoicePayDate = txtInvDate.Text;
                    allInvoices[i].customerNo = Convert.ToInt32(txtCustNo.Text);
                    lblInvoiceLabel.Text = "Invoice Information edited";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//btnLoadInvoice
        {
            //Search the array for the invoice number that matches the number in the invoice number textbox
            for (int i = 0; i < icount; i++)
            {
                if (Convert.ToInt32(txtInvNo.Text) == allInvoices[i].invoiceNumber)
                {
                    txtInvDesc.Text = allInvoices[i].invoiceDescription;
                    txtInvCost.Text = Convert.ToString(allInvoices[i].invoiceCost);
                    txtInvDate.Text = allInvoices[i].invoicePayDate;
                    txtCustNo.Text = Convert.ToString(allInvoices[i].customerNo);
                    ieditcount = i;
                    //Search the customers array for a customer number that matches the customer number 
                    //corresponding to the one existing in the InvoiceDetails object.
                    for (int c = 0; c < ccount; c++)
                    {
                        if (Convert.ToInt32(txtCustNo.Text) == allCustomers[c].CustomerNumber)
                        {
                            txtCustName.Text = allCustomers[c].CustomerName;
                            txtCustNo.Text = Convert.ToString(allCustomers[c].CustomerNumber);
                            txtCustAddress.Text = allCustomers[c].CustomerAddress;
                            txtCustContact.Text = Convert.ToString(allCustomers[c].CustomerContact);
                            ceditcount = c;
                        }
                    }
                    lblInvoiceLabel.Text = "Invoice information loaded.";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)//btnSaveCustomer
        {
            //Adds a new entry to the array, denotes it as the current "active" entry for editing, and increments for continued additions.
            ceditcount = ccount;
            allCustomers[ccount] = new CustomerDetails();
            allCustomers[ccount].CustomerName = txtCustName.Text;
            allCustomers[ccount].CustomerNumber = Convert.ToInt32(txtCustNo.Text);
            allCustomers[ccount].CustomerAddress = txtCustAddress.Text;
            allCustomers[ccount].CustomerContact = Convert.ToInt32(txtCustContact.Text);
            ccount++;
            lblCustLabel.Text = "Customer Information saved.";
        }

        private void button7_Click(object sender, EventArgs e)//btnSaveInvoice
        {
            //Adds a new entry to the array of invoices, denotes it as the current "active" entry for editing
            //saves the customer number to enable loading customer details alongside it, and increments for additional entries
            ieditcount = icount;
            allInvoices[icount] = new InvoiceDetails();
            allInvoices[icount].invoiceNumber = Convert.ToInt32(txtInvNo.Text);
            allInvoices[icount].invoiceDescription = txtInvDesc.Text;
            allInvoices[icount].invoiceCost = Convert.ToDouble(txtInvCost.Text);
            allInvoices[icount].invoicePayDate = txtInvDate.Text;
            allInvoices[icount].customerNo = Convert.ToInt32(txtCustNo.Text);
            icount++;
            lblInvoiceLabel.Text = "Invoice information saved.";
        }

        private void button5_Click(object sender, EventArgs e)//btnBackground
        {
            //Changes the background image of the input form to whatever bg.bmp is in the Resources file.
            //Included is an image of the default winxp desktop. Allegedly.
            Image background = InvoiceSystem.Properties.Resources.bg;
            this.BackgroundImage = background;
        }
    }
}
