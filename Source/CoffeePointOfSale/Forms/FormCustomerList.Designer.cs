namespace CoffeePointOfSale.Forms
{
    partial class FormCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerList));
            this.OnClickBtntoMain1 = new System.Windows.Forms.Button();
            this.newCustomerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerListTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OnClickBtntoMain1
            // 
            this.OnClickBtntoMain1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OnClickBtntoMain1.Location = new System.Drawing.Point(12, 14);
            this.OnClickBtntoMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnClickBtntoMain1.Name = "OnClickBtntoMain1";
            this.OnClickBtntoMain1.Size = new System.Drawing.Size(112, 56);
            this.OnClickBtntoMain1.TabIndex = 0;
            this.OnClickBtntoMain1.Text = "Back";
            this.OnClickBtntoMain1.UseVisualStyleBackColor = false;
            this.OnClickBtntoMain1.Click += new System.EventHandler(this.OnClickBtnCustomerListing);
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newCustomerBtn.Location = new System.Drawing.Point(550, 562);
            this.newCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(224, 56);
            this.newCustomerBtn.TabIndex = 1;
            this.newCustomerBtn.Text = "New Customer";
            this.newCustomerBtn.UseVisualStyleBackColor = false;
            this.newCustomerBtn.Click += new System.EventHandler(this.newCustomerBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(523, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALL CUSTOMERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customerListTxtbox
            // 
            this.customerListTxtbox.Location = new System.Drawing.Point(280, 82);
            this.customerListTxtbox.Multiline = true;
            this.customerListTxtbox.Name = "customerListTxtbox";
            this.customerListTxtbox.ReadOnly = true;
            this.customerListTxtbox.Size = new System.Drawing.Size(804, 440);
            this.customerListTxtbox.TabIndex = 3;
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.customerListTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newCustomerBtn);
            this.Controls.Add(this.OnClickBtntoMain1);
            this.Margin = new System.Windows.Forms.Padding(19, 38, 19, 38);
            this.MaximizeBox = true;
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OnClickBtntoMain1;
        private Button newCustomerBtn;
        private Label label1;
        private TextBox customerListTxtbox;
    }
}