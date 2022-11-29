namespace CoffeePointOfSale.Forms
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.latteBtn = new System.Windows.Forms.Button();
            this.icedLatteBtn = new System.Windows.Forms.Button();
            this.coffeeBtn = new System.Windows.Forms.Button();
            this.matchaGreenBtn = new System.Windows.Forms.Button();
            this.waterBtn = new System.Windows.Forms.Button();
            this.minusBtnQ = new System.Windows.Forms.Button();
            this.plusBtnQ = new System.Windows.Forms.Button();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.salesTax = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.espressoBtn = new System.Windows.Forms.Button();
            this.coffeeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addDrinkBtn = new System.Windows.Forms.Button();
            this.qtyTxtbox = new System.Windows.Forms.TextBox();
            this.customizationListBox = new System.Windows.Forms.CheckedListBox();
            this.orderItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainMenuBtn.Location = new System.Drawing.Point(150, 2);
            this.mainMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(108, 32);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // latteBtn
            // 
            this.latteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.latteBtn.Location = new System.Drawing.Point(210, 56);
            this.latteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.latteBtn.Name = "latteBtn";
            this.latteBtn.Size = new System.Drawing.Size(93, 35);
            this.latteBtn.TabIndex = 3;
            this.latteBtn.Text = "Latte";
            this.latteBtn.UseVisualStyleBackColor = false;
            this.latteBtn.Click += new System.EventHandler(this.latteBtn_Click);
            // 
            // icedLatteBtn
            // 
            this.icedLatteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icedLatteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.icedLatteBtn.Location = new System.Drawing.Point(210, 89);
            this.icedLatteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icedLatteBtn.Name = "icedLatteBtn";
            this.icedLatteBtn.Size = new System.Drawing.Size(93, 35);
            this.icedLatteBtn.TabIndex = 6;
            this.icedLatteBtn.Text = "Iced Latte";
            this.icedLatteBtn.UseVisualStyleBackColor = false;
            this.icedLatteBtn.Click += new System.EventHandler(this.icedLatteBtn_Click);
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coffeeBtn.BackColor = System.Drawing.Color.Olive;
            this.coffeeBtn.Location = new System.Drawing.Point(329, 56);
            this.coffeeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(93, 35);
            this.coffeeBtn.TabIndex = 7;
            this.coffeeBtn.Text = "Coffee";
            this.coffeeBtn.UseVisualStyleBackColor = false;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // matchaGreenBtn
            // 
            this.matchaGreenBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matchaGreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.matchaGreenBtn.Location = new System.Drawing.Point(210, 123);
            this.matchaGreenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchaGreenBtn.Name = "matchaGreenBtn";
            this.matchaGreenBtn.Size = new System.Drawing.Size(93, 35);
            this.matchaGreenBtn.TabIndex = 8;
            this.matchaGreenBtn.Text = "Matcha Latte";
            this.matchaGreenBtn.UseVisualStyleBackColor = false;
            this.matchaGreenBtn.Click += new System.EventHandler(this.matchaGreenBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.waterBtn.Location = new System.Drawing.Point(329, 89);
            this.waterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(93, 35);
            this.waterBtn.TabIndex = 9;
            this.waterBtn.Text = "Water";
            this.waterBtn.UseVisualStyleBackColor = false;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // minusBtnQ
            // 
            this.minusBtnQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minusBtnQ.Location = new System.Drawing.Point(461, 56);
            this.minusBtnQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minusBtnQ.Name = "minusBtnQ";
            this.minusBtnQ.Size = new System.Drawing.Size(34, 48);
            this.minusBtnQ.TabIndex = 22;
            this.minusBtnQ.Text = "-";
            this.minusBtnQ.UseVisualStyleBackColor = false;
            this.minusBtnQ.Click += new System.EventHandler(this.minusBtnQ_Click);
            // 
            // plusBtnQ
            // 
            this.plusBtnQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.plusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plusBtnQ.Location = new System.Drawing.Point(557, 56);
            this.plusBtnQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plusBtnQ.Name = "plusBtnQ";
            this.plusBtnQ.Size = new System.Drawing.Size(34, 48);
            this.plusBtnQ.TabIndex = 23;
            this.plusBtnQ.Text = "+";
            this.plusBtnQ.UseVisualStyleBackColor = false;
            this.plusBtnQ.Click += new System.EventHandler(this.plusBtnQ_Click);
            // 
            // subTotal
            // 
            this.subTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.subTotal.Location = new System.Drawing.Point(819, 160);
            this.subTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Size = new System.Drawing.Size(143, 23);
            this.subTotal.TabIndex = 28;
            this.subTotal.Text = "Sub-Total:";
            // 
            // salesTax
            // 
            this.salesTax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salesTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.salesTax.Location = new System.Drawing.Point(819, 181);
            this.salesTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesTax.Name = "salesTax";
            this.salesTax.ReadOnly = true;
            this.salesTax.Size = new System.Drawing.Size(143, 23);
            this.salesTax.TabIndex = 29;
            this.salesTax.Text = "Sales Tax: ";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.total.Location = new System.Drawing.Point(819, 201);
            this.total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(143, 23);
            this.total.TabIndex = 30;
            this.total.Text = "Total: ";
            // 
            // payButton
            // 
            this.payButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.payButton.Location = new System.Drawing.Point(819, 245);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(143, 60);
            this.payButton.TabIndex = 31;
            this.payButton.Text = "Complete Order";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // espressoBtn
            // 
            this.espressoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.espressoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.espressoBtn.Location = new System.Drawing.Point(329, 123);
            this.espressoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.espressoBtn.Name = "espressoBtn";
            this.espressoBtn.Size = new System.Drawing.Size(93, 35);
            this.espressoBtn.TabIndex = 32;
            this.espressoBtn.Text = "Espresso";
            this.espressoBtn.UseVisualStyleBackColor = false;
            this.espressoBtn.Click += new System.EventHandler(this.espressoBtn_Click);
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coffeeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coffeeLabel.Location = new System.Drawing.Point(210, 34);
            this.coffeeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(229, 18);
            this.coffeeLabel.TabIndex = 34;
            this.coffeeLabel.Tag = "";
            this.coffeeLabel.Text = "Drinks";
            this.coffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDrinkBtn
            // 
            this.addDrinkBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addDrinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addDrinkBtn.Location = new System.Drawing.Point(460, 104);
            this.addDrinkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDrinkBtn.Name = "addDrinkBtn";
            this.addDrinkBtn.Size = new System.Drawing.Size(144, 61);
            this.addDrinkBtn.TabIndex = 42;
            this.addDrinkBtn.Text = "Add Drink";
            this.addDrinkBtn.UseVisualStyleBackColor = false;
            this.addDrinkBtn.Click += new System.EventHandler(this.addDrinkBtn_Click);
            // 
            // qtyTxtbox
            // 
            this.qtyTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qtyTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.qtyTxtbox.Location = new System.Drawing.Point(485, 56);
            this.qtyTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qtyTxtbox.Multiline = true;
            this.qtyTxtbox.Name = "qtyTxtbox";
            this.qtyTxtbox.ReadOnly = true;
            this.qtyTxtbox.Size = new System.Drawing.Size(89, 48);
            this.qtyTxtbox.TabIndex = 24;
            this.qtyTxtbox.Text = "Qty: \r\n1";
            this.qtyTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customizationListBox
            // 
            this.customizationListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customizationListBox.FormattingEnabled = true;
            this.customizationListBox.Location = new System.Drawing.Point(164, 160);
            this.customizationListBox.Name = "customizationListBox";
            this.customizationListBox.Size = new System.Drawing.Size(482, 166);
            this.customizationListBox.TabIndex = 51;
            // 
            // orderItems
            // 
            this.orderItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderItems.Location = new System.Drawing.Point(715, 6);
            this.orderItems.Multiline = true;
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(314, 141);
            this.orderItems.TabIndex = 52;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1181, 547);
            this.Controls.Add(this.orderItems);
            this.Controls.Add(this.customizationListBox);
            this.Controls.Add(this.addDrinkBtn);
            this.Controls.Add(this.coffeeLabel);
            this.Controls.Add(this.espressoBtn);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.total);
            this.Controls.Add(this.salesTax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.qtyTxtbox);
            this.Controls.Add(this.plusBtnQ);
            this.Controls.Add(this.minusBtnQ);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.matchaGreenBtn);
            this.Controls.Add(this.coffeeBtn);
            this.Controls.Add(this.icedLatteBtn);
            this.Controls.Add(this.latteBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1197, 586);
            this.Name = "FormOrder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeff\'s Coffee Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mainMenuBtn;
        private Button latteBtn;
        private Button icedLatteBtn;
        private Button coffeeBtn;
        private Button matchaGreenBtn;
        private Button waterBtn;
        private Button minusBtnQ;
        private Button plusBtnQ;
        private TextBox subTotal;
        private TextBox salesTax;
        private TextBox total;
        private Button payButton;
        private Button espressoBtn;
        private Label coffeeLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button addDrinkBtn;
        private TextBox qtyTxtbox;
        private CheckedListBox customizationListBox;
        private TextBox orderItems;
    }
}