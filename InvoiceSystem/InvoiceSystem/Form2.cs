using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//A basic login form using a single hardcoded 'account'.

namespace InvoiceSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)//btnLogin
        {
            //Username: lister  Password: 1472
            if ((txtUsername.Text == "lister") && (txtPassword.Text == "1472"))
            {
                Form1 f1 = new InvoiceSystem.Form1();
                f1.ShowDialog();

            }
            else if ((txtUsername.Text == "lister") && (txtPassword.Text != "1472"))
            {
                //Mention that the password is incorrect, identifying it as the issue to a user.
                MessageBox.Show("Incorrect Password");
            }
            else
            {
                //Mention that the username is incorrect, identifying that as the issue to the user.
                MessageBox.Show("Invalid Username");
            }
        }
    }
}
