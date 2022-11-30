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
            this.subTotalLabel = new System.Windows.Forms.TextBox();
            this.salesTaxLabel = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.espressoBtn = new System.Windows.Forms.Button();
            this.coffeeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addDrinkBtn = new System.Windows.Forms.Button();
            this.qtyTxtbox = new System.Windows.Forms.TextBox();
            this.customizationListBox = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.orderItems = new System.Windows.Forms.ListBox();
            this.priceDrinkL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainMenuBtn.Location = new System.Drawing.Point(89, 130);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(123, 43);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // latteBtn
            // 
            this.latteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.latteBtn.Location = new System.Drawing.Point(158, 202);
            this.latteBtn.Name = "latteBtn";
            this.latteBtn.Size = new System.Drawing.Size(106, 47);
            this.latteBtn.TabIndex = 3;
            this.latteBtn.Text = "Latte";
            this.latteBtn.UseVisualStyleBackColor = false;
            this.latteBtn.Click += new System.EventHandler(this.latteBtn_Click);
            // 
            // icedLatteBtn
            // 
            this.icedLatteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icedLatteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.icedLatteBtn.Location = new System.Drawing.Point(158, 246);
            this.icedLatteBtn.Name = "icedLatteBtn";
            this.icedLatteBtn.Size = new System.Drawing.Size(106, 47);
            this.icedLatteBtn.TabIndex = 6;
            this.icedLatteBtn.Text = "Iced Latte";
            this.icedLatteBtn.UseVisualStyleBackColor = false;
            this.icedLatteBtn.Click += new System.EventHandler(this.icedLatteBtn_Click);
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coffeeBtn.BackColor = System.Drawing.Color.Olive;
            this.coffeeBtn.Location = new System.Drawing.Point(294, 202);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(106, 47);
            this.coffeeBtn.TabIndex = 7;
            this.coffeeBtn.Text = "Coffee";
            this.coffeeBtn.UseVisualStyleBackColor = false;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // matchaGreenBtn
            // 
            this.matchaGreenBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matchaGreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.matchaGreenBtn.Location = new System.Drawing.Point(158, 291);
            this.matchaGreenBtn.Name = "matchaGreenBtn";
            this.matchaGreenBtn.Size = new System.Drawing.Size(106, 47);
            this.matchaGreenBtn.TabIndex = 8;
            this.matchaGreenBtn.Text = "Matcha Latte";
            this.matchaGreenBtn.UseVisualStyleBackColor = false;
            this.matchaGreenBtn.Click += new System.EventHandler(this.matchaGreenBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.waterBtn.Location = new System.Drawing.Point(294, 246);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(106, 47);
            this.waterBtn.TabIndex = 9;
            this.waterBtn.Text = "Water";
            this.waterBtn.UseVisualStyleBackColor = false;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // minusBtnQ
            // 
            this.minusBtnQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minusBtnQ.Location = new System.Drawing.Point(446, 202);
            this.minusBtnQ.Name = "minusBtnQ";
            this.minusBtnQ.Size = new System.Drawing.Size(39, 64);
            this.minusBtnQ.TabIndex = 22;
            this.minusBtnQ.Text = "-";
            this.minusBtnQ.UseVisualStyleBackColor = false;
            this.minusBtnQ.Click += new System.EventHandler(this.minusBtnQ_Click);
            // 
            // plusBtnQ
            // 
            this.plusBtnQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.plusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plusBtnQ.Location = new System.Drawing.Point(554, 202);
            this.plusBtnQ.Name = "plusBtnQ";
            this.plusBtnQ.Size = new System.Drawing.Size(39, 64);
            this.plusBtnQ.TabIndex = 23;
            this.plusBtnQ.Text = "+";
            this.plusBtnQ.UseVisualStyleBackColor = false;
            this.plusBtnQ.Click += new System.EventHandler(this.plusBtnQ_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subTotalLabel.BackColor = System.Drawing.Color.White;
            this.subTotalLabel.Location = new System.Drawing.Point(854, 341);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.ReadOnly = true;
            this.subTotalLabel.Size = new System.Drawing.Size(163, 27);
            this.subTotalLabel.TabIndex = 28;
            this.subTotalLabel.Text = "0.00";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salesTaxLabel.BackColor = System.Drawing.Color.White;
            this.salesTaxLabel.Location = new System.Drawing.Point(854, 369);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.ReadOnly = true;
            this.salesTaxLabel.Size = new System.Drawing.Size(163, 27);
            this.salesTaxLabel.TabIndex = 29;
            this.salesTaxLabel.Text = "0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(854, 399);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.ReadOnly = true;
            this.totalLabel.Size = new System.Drawing.Size(163, 27);
            this.totalLabel.TabIndex = 30;
            this.totalLabel.Text = "0.00";
            // 
            // payButton
            // 
            this.payButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.payButton.Location = new System.Drawing.Point(854, 454);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(163, 80);
            this.payButton.TabIndex = 31;
            this.payButton.Text = "Complete Order";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // espressoBtn
            // 
            this.espressoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.espressoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.espressoBtn.Location = new System.Drawing.Point(294, 291);
            this.espressoBtn.Name = "espressoBtn";
            this.espressoBtn.Size = new System.Drawing.Size(106, 47);
            this.espressoBtn.TabIndex = 32;
            this.espressoBtn.Text = "Espresso";
            this.espressoBtn.UseVisualStyleBackColor = false;
            this.espressoBtn.Click += new System.EventHandler(this.espressoBtn_Click);
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coffeeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coffeeLabel.Location = new System.Drawing.Point(158, 173);
            this.coffeeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(262, 24);
            this.coffeeLabel.TabIndex = 34;
            this.coffeeLabel.Tag = "";
            this.coffeeLabel.Text = "Drinks";
            this.coffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDrinkBtn
            // 
            this.addDrinkBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addDrinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addDrinkBtn.Location = new System.Drawing.Point(443, 266);
            this.addDrinkBtn.Name = "addDrinkBtn";
            this.addDrinkBtn.Size = new System.Drawing.Size(165, 81);
            this.addDrinkBtn.TabIndex = 42;
            this.addDrinkBtn.Text = "Add Drink";
            this.addDrinkBtn.UseVisualStyleBackColor = false;
            this.addDrinkBtn.Click += new System.EventHandler(this.addDrinkBtn_Click);
            // 
            // qtyTxtbox
            // 
            this.qtyTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qtyTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.qtyTxtbox.Location = new System.Drawing.Point(481, 202);
            this.qtyTxtbox.Multiline = true;
            this.qtyTxtbox.Name = "qtyTxtbox";
            this.qtyTxtbox.ReadOnly = true;
            this.qtyTxtbox.Size = new System.Drawing.Size(83, 63);
            this.qtyTxtbox.TabIndex = 24;
            this.qtyTxtbox.Text = "Qty: \r\n1";
            this.qtyTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customizationListBox
            // 
            this.customizationListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customizationListBox.FormattingEnabled = true;
            this.customizationListBox.Location = new System.Drawing.Point(105, 354);
            this.customizationListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customizationListBox.Name = "customizationListBox";
            this.customizationListBox.Size = new System.Drawing.Size(550, 180);
            this.customizationListBox.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(764, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 27);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "Sub-Total: $";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(764, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(84, 27);
            this.textBox2.TabIndex = 54;
            this.textBox2.Text = "Sales Tax:   $";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(764, 399);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(84, 27);
            this.textBox3.TabIndex = 55;
            this.textBox3.Text = "Total:         $";
            // 
            // orderItems
            // 
            this.orderItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderItems.FormattingEnabled = true;
            this.orderItems.ItemHeight = 20;
            this.orderItems.Location = new System.Drawing.Point(735, 135);
            this.orderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(358, 144);
            this.orderItems.TabIndex = 56;
            // 
            // priceDrinkL
            // 
            this.priceDrinkL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceDrinkL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceDrinkL.Location = new System.Drawing.Point(446, 173);
            this.priceDrinkL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.priceDrinkL.Name = "priceDrinkL";
            this.priceDrinkL.Size = new System.Drawing.Size(217, 24);
            this.priceDrinkL.TabIndex = 57;
            this.priceDrinkL.Tag = "";
            this.priceDrinkL.Text = "Price of the Drink: ";
            this.priceDrinkL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1349, 720);
            this.Controls.Add(this.priceDrinkL);
            this.Controls.Add(this.orderItems);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customizationListBox);
            this.Controls.Add(this.addDrinkBtn);
            this.Controls.Add(this.coffeeLabel);
            this.Controls.Add(this.espressoBtn);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subTotalLabel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1364, 756);
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
        private TextBox subTotalLabel;
        private TextBox salesTaxLabel;
        private TextBox totalLabel;
        private Button payButton;
        private Button espressoBtn;
        private Label coffeeLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button addDrinkBtn;
        private TextBox qtyTxtbox;
        private CheckedListBox customizationListBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox orderItems;
        private Label priceDrinkL;
    }
}