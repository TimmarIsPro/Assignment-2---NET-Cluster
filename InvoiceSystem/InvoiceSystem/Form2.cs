using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if ((txtUsername.Text == "TestAccount") && (txtPassword.Text == "TestPassword"))
            {
                Form1 f1 = new InvoiceSystem.Form1();
                f1.ShowDialog();
                this.Hide();

            }
            else if ((txtUsername.Text == "TestAccount") && (txtPassword.Text != "TestPassword"))
            {
                MessageBox.Show("Incorrect Password");
            }
            else
            {
                MessageBox.Show("Invalid Username");
            }
        }
    }
}
