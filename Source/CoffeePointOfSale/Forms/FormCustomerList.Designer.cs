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
            this.OnClickBtntoMain1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OnClickBtntoMain1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OnClickBtntoMain1.Location = new System.Drawing.Point(0, 2);
            this.OnClickBtntoMain1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OnClickBtntoMain1.Name = "OnClickBtntoMain1";
            this.OnClickBtntoMain1.Size = new System.Drawing.Size(123, 42);
            this.OnClickBtntoMain1.TabIndex = 0;
            this.OnClickBtntoMain1.Text = "Main Menu";
            this.OnClickBtntoMain1.UseVisualStyleBackColor = false;
            this.OnClickBtntoMain1.Click += new System.EventHandler(this.OnClickBtnCustomerListing);
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newCustomerBtn.Location = new System.Drawing.Point(440, 426);
            this.newCustomerBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(179, 46);
            this.newCustomerBtn.TabIndex = 1;
            this.newCustomerBtn.Text = "New Customer";
            this.newCustomerBtn.UseVisualStyleBackColor = false;
            this.newCustomerBtn.Click += new System.EventHandler(this.newCustomerBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(418, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALL CUSTOMERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customerListTxtbox
            // 
            this.customerListTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerListTxtbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerListTxtbox.Location = new System.Drawing.Point(194, 68);
            this.customerListTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerListTxtbox.Multiline = true;
            this.customerListTxtbox.Name = "customerListTxtbox";
            this.customerListTxtbox.ReadOnly = true;
            this.customerListTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customerListTxtbox.Size = new System.Drawing.Size(685, 354);
            this.customerListTxtbox.TabIndex = 3;
            this.customerListTxtbox.TextChanged += new System.EventHandler(this.customerListTxtbox_TextChanged);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 570);
            this.Controls.Add(this.customerListTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newCustomerBtn);
            this.Controls.Add(this.OnClickBtntoMain1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1090, 601);
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