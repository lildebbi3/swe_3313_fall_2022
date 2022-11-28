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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(426, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(426, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(426, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(518, 529);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADD CUSTOMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(571, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CUSTOMER SIGNUP";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(571, 260);
            this.textBoxFN.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(208, 31);
            this.textBoxFN.TabIndex = 5;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(571, 316);
            this.textBoxLN.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(208, 31);
            this.textBoxLN.TabIndex = 6;
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(571, 376);
            this.textBoxPN.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(208, 31);
            this.textBoxPN.TabIndex = 7;
            // 
            // labelCustomerSignupWarning
            // 
            this.labelCustomerSignupWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelCustomerSignupWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCustomerSignupWarning.Location = new System.Drawing.Point(959, 67);
            this.labelCustomerSignupWarning.Margin = new System.Windows.Forms.Padding(9);
            this.labelCustomerSignupWarning.Name = "labelCustomerSignupWarning";
            this.labelCustomerSignupWarning.Padding = new System.Windows.Forms.Padding(6, 10, 1, 30);
            this.labelCustomerSignupWarning.Size = new System.Drawing.Size(306, 153);
            this.labelCustomerSignupWarning.TabIndex = 1;
            this.labelCustomerSignupWarning.Text = "All fields must be filled and cannot be left empty, doing so will result in an in" +
    "valid statement occuring on the screen.";
            this.labelCustomerSignupWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCustomerSignupWarning.Click += new System.EventHandler(this.label5_Click);
            // 
            // backBtnCC
            // 
            this.backBtnCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backBtnCC.Location = new System.Drawing.Point(11, 11);
            this.backBtnCC.Margin = new System.Windows.Forms.Padding(1);
            this.backBtnCC.Name = "backBtnCC";
            this.backBtnCC.Size = new System.Drawing.Size(106, 59);
            this.backBtnCC.TabIndex = 8;
            this.backBtnCC.Text = "Back";
            this.backBtnCC.UseVisualStyleBackColor = false;
            this.backBtnCC.Click += new System.EventHandler(this.backBtnCC_Click);
            // 
            // CCwarningLabel
            // 
            this.CCwarningLabel.AutoSize = true;
            this.CCwarningLabel.ForeColor = System.Drawing.Color.Red;
            this.CCwarningLabel.Location = new System.Drawing.Point(412, 462);
            this.CCwarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.CCwarningLabel);
            this.Controls.Add(this.backBtnCC);
            this.Controls.Add(this.labelCustomerSignupWarning);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(11, 21, 11, 21);
            this.MaximizeBox = true;
            this.Name = "FormCreateCustomer";
            this.ShowIcon = false;
            this.Text = "Jeff\'s Coffee Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBoxFN;
        private TextBox textBoxLN;
        private TextBox textBoxPN;
        private Label labelCustomerSignupWarning;
        private Button backBtnCC;
        private Label CCwarningLabel;
    }
}