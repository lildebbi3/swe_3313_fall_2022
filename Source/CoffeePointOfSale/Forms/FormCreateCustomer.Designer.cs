namespace CoffeePointOfSale.Forms
{
    partial class FormCreateCustomer
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
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.labelCustomerSignupWarning = new System.Windows.Forms.Label();
            this.backBtnCC = new System.Windows.Forms.Button();
            this.CCwarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(532, 529);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(235, 39);
            this.addCustomerBtn.TabIndex = 3;
            this.addCustomerBtn.Text = "ADD CUSTOMER";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CUSTOMER SIGNUP";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(559, 202);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(208, 31);
            this.textBoxFN.TabIndex = 5;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(559, 259);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(208, 31);
            this.textBoxLN.TabIndex = 6;
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(559, 317);
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(208, 31);
            this.textBoxPN.TabIndex = 7;
            // 
            // labelCustomerSignupWarning
            // 
            this.labelCustomerSignupWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCustomerSignupWarning.Location = new System.Drawing.Point(989, 49);
            this.labelCustomerSignupWarning.Margin = new System.Windows.Forms.Padding(7);
            this.labelCustomerSignupWarning.Name = "labelCustomerSignupWarning";
            this.labelCustomerSignupWarning.Padding = new System.Windows.Forms.Padding(5, 10, 2, 30);
            this.labelCustomerSignupWarning.Size = new System.Drawing.Size(306, 153);
            this.labelCustomerSignupWarning.TabIndex = 1;
            this.labelCustomerSignupWarning.Text = "All fields must be filled and cannot be left empty, doing so will result in an in" +
    "valid statement occuring on the screen.";
            this.labelCustomerSignupWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCustomerSignupWarning.Click += new System.EventHandler(this.label5_Click);
            // 
            // backBtnCC
            // 
            this.backBtnCC.Location = new System.Drawing.Point(12, 12);
            this.backBtnCC.Name = "backBtnCC";
            this.backBtnCC.Size = new System.Drawing.Size(106, 59);
            this.backBtnCC.TabIndex = 8;
            this.backBtnCC.Text = "Back";
            this.backBtnCC.UseVisualStyleBackColor = true;
            this.backBtnCC.Click += new System.EventHandler(this.backBtnCC_Click);
            // 
            // CCwarningLabel
            // 
            this.CCwarningLabel.AutoSize = true;
            this.CCwarningLabel.ForeColor = System.Drawing.Color.Red;
            this.CCwarningLabel.Location = new System.Drawing.Point(430, 464);
            this.CCwarningLabel.Name = "CCwarningLabel";
            this.CCwarningLabel.Size = new System.Drawing.Size(497, 25);
            this.CCwarningLabel.TabIndex = 9;
            this.CCwarningLabel.Text = "Please enter info into the three boxes to add a new customer.";
            this.CCwarningLabel.Visible = false;
            // 
            // FormCreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.CCwarningLabel);
            this.Controls.Add(this.backBtnCC);
            this.Controls.Add(this.labelCustomerSignupWarning);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(13, 22, 13, 22);
            this.Name = "FormCreateCustomer";
            this.Text = "FormCreateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button addCustomerBtn;
        private Label label4;
        private TextBox textBoxFN;
        private TextBox textBoxLN;
        private TextBox textBoxPN;
        private Label labelCustomerSignupWarning;
        private Button backBtnCC;
        private Label CCwarningLabel;
    }
}