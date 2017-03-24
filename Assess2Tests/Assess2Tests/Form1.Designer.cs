namespace Assess2Tests
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
            this.btnLoadCust = new System.Windows.Forms.Button();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustNumber = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustContact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadCust
            // 
            this.btnLoadCust.Location = new System.Drawing.Point(237, 112);
            this.btnLoadCust.Name = "btnLoadCust";
            this.btnLoadCust.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCust.TabIndex = 0;
            this.btnLoadCust.Text = "LoadCustomer";
            this.btnLoadCust.UseVisualStyleBackColor = true;
            this.btnLoadCust.Click += new System.EventHandler(this.btnLoadCust_Click);
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.Location = new System.Drawing.Point(237, 189);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCust.TabIndex = 1;
            this.btnSaveCust.Text = "SaveNew";
            this.btnSaveCust.UseVisualStyleBackColor = true;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(318, 189);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(75, 23);
            this.btnEditCust.TabIndex = 2;
            this.btnEditCust.Text = "EditCustomer";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(60, 114);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.Text = "CustomerName";
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Location = new System.Drawing.Point(60, 140);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCustNumber.TabIndex = 4;
            this.txtCustNumber.Text = "CustomerNumber";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(60, 166);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCustAddress.TabIndex = 5;
            this.txtCustAddress.Text = "Address";
            // 
            // txtCustContact
            // 
            this.txtCustContact.Location = new System.Drawing.Point(60, 192);
            this.txtCustContact.Name = "txtCustContact";
            this.txtCustContact.Size = new System.Drawing.Size(100, 20);
            this.txtCustContact.TabIndex = 6;
            this.txtCustContact.Text = "ContactNumber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 339);
            this.Controls.Add(this.txtCustContact);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustNumber);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.btnEditCust);
            this.Controls.Add(this.btnSaveCust);
            this.Controls.Add(this.btnLoadCust);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCust;
        private System.Windows.Forms.Button btnSaveCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustContact;
    }
}

