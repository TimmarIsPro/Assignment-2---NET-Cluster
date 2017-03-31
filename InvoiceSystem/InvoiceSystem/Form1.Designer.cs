namespace InvoiceSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.txtCustContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvDesc = new System.Windows.Forms.TextBox();
            this.alabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvCost = new System.Windows.Forms.TextBox();
            this.txtInvDate = new System.Windows.Forms.TextBox();
            this.BtnLoadCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnLoadInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.lblCustLabel = new System.Windows.Forms.Label();
            this.lblInvoiceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Invoice Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact Number";
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(143, 78);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(126, 20);
            this.txtCustNo.TabIndex = 3;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(143, 51);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(126, 20);
            this.txtCustName.TabIndex = 1;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(143, 104);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(126, 20);
            this.txtCustAddress.TabIndex = 4;
            // 
            // txtInvNo
            // 
            this.txtInvNo.Location = new System.Drawing.Point(143, 225);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(126, 20);
            this.txtInvNo.TabIndex = 8;
            // 
            // txtCustContact
            // 
            this.txtCustContact.Location = new System.Drawing.Point(143, 130);
            this.txtCustContact.Name = "txtCustContact";
            this.txtCustContact.Size = new System.Drawing.Size(126, 20);
            this.txtCustContact.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description";
            // 
            // txtInvDesc
            // 
            this.txtInvDesc.Location = new System.Drawing.Point(143, 251);
            this.txtInvDesc.Multiline = true;
            this.txtInvDesc.Name = "txtInvDesc";
            this.txtInvDesc.Size = new System.Drawing.Size(379, 79);
            this.txtInvDesc.TabIndex = 10;
            // 
            // alabel
            // 
            this.alabel.AutoSize = true;
            this.alabel.Location = new System.Drawing.Point(46, 336);
            this.alabel.Name = "alabel";
            this.alabel.Size = new System.Drawing.Size(28, 13);
            this.alabel.TabIndex = 0;
            this.alabel.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment Date";
            // 
            // txtInvCost
            // 
            this.txtInvCost.Location = new System.Drawing.Point(143, 336);
            this.txtInvCost.Name = "txtInvCost";
            this.txtInvCost.Size = new System.Drawing.Size(126, 20);
            this.txtInvCost.TabIndex = 11;
            // 
            // txtInvDate
            // 
            this.txtInvDate.Location = new System.Drawing.Point(143, 362);
            this.txtInvDate.Name = "txtInvDate";
            this.txtInvDate.Size = new System.Drawing.Size(126, 20);
            this.txtInvDate.TabIndex = 12;
            // 
            // BtnLoadCustomer
            // 
            this.BtnLoadCustomer.Location = new System.Drawing.Point(310, 52);
            this.BtnLoadCustomer.Name = "BtnLoadCustomer";
            this.BtnLoadCustomer.Size = new System.Drawing.Size(88, 19);
            this.BtnLoadCustomer.TabIndex = 2;
            this.BtnLoadCustomer.Text = "Load Customer";
            this.BtnLoadCustomer.UseVisualStyleBackColor = true;
            this.BtnLoadCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(404, 126);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(88, 20);
            this.btnEditCustomer.TabIndex = 7;
            this.btnEditCustomer.Text = "Save Changes";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoadInvoice
            // 
            this.btnLoadInvoice.Location = new System.Drawing.Point(310, 226);
            this.btnLoadInvoice.Name = "btnLoadInvoice";
            this.btnLoadInvoice.Size = new System.Drawing.Size(88, 19);
            this.btnLoadInvoice.TabIndex = 9;
            this.btnLoadInvoice.Text = "Load Invoice";
            this.btnLoadInvoice.UseVisualStyleBackColor = true;
            this.btnLoadInvoice.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Location = new System.Drawing.Point(404, 362);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(88, 19);
            this.btnEditInvoice.TabIndex = 14;
            this.btnEditInvoice.Text = "Save Changes";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(434, 446);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(88, 19);
            this.btnBackground.TabIndex = 0;
            this.btnBackground.TabStop = false;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(310, 126);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(88, 20);
            this.btnSaveCustomer.TabIndex = 6;
            this.btnSaveCustomer.Text = "Save New";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(310, 362);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(88, 19);
            this.btnSaveInvoice.TabIndex = 13;
            this.btnSaveInvoice.Text = "Save New";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblCustLabel
            // 
            this.lblCustLabel.AutoSize = true;
            this.lblCustLabel.Location = new System.Drawing.Point(324, 97);
            this.lblCustLabel.Name = "lblCustLabel";
            this.lblCustLabel.Size = new System.Drawing.Size(0, 13);
            this.lblCustLabel.TabIndex = 15;
            // 
            // lblInvoiceLabel
            // 
            this.lblInvoiceLabel.AutoSize = true;
            this.lblInvoiceLabel.Location = new System.Drawing.Point(307, 339);
            this.lblInvoiceLabel.Name = "lblInvoiceLabel";
            this.lblInvoiceLabel.Size = new System.Drawing.Size(0, 13);
            this.lblInvoiceLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 492);
            this.Controls.Add(this.lblInvoiceLabel);
            this.Controls.Add(this.lblCustLabel);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.btnLoadInvoice);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.BtnLoadCustomer);
            this.Controls.Add(this.txtInvDate);
            this.Controls.Add(this.txtInvCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alabel);
            this.Controls.Add(this.txtInvDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustContact);
            this.Controls.Add(this.txtInvNo);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Invoicing";
            this.Click += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.TextBox txtCustContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvDesc;
        private System.Windows.Forms.Label alabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvCost;
        private System.Windows.Forms.TextBox txtInvDate;
        private System.Windows.Forms.Button BtnLoadCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnLoadInvoice;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Label lblCustLabel;
        private System.Windows.Forms.Label lblInvoiceLabel;
    }
}

