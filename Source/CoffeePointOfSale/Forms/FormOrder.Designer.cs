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
            this.orderItems = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainMenuBtn.Location = new System.Drawing.Point(40, 15);
            this.mainMenuBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(154, 53);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // latteBtn
            // 
            this.latteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.latteBtn.Location = new System.Drawing.Point(126, 105);
            this.latteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.latteBtn.Name = "latteBtn";
            this.latteBtn.Size = new System.Drawing.Size(133, 58);
            this.latteBtn.TabIndex = 3;
            this.latteBtn.Text = "Latte";
            this.latteBtn.UseVisualStyleBackColor = false;
            this.latteBtn.Click += new System.EventHandler(this.latteBtn_Click);
            // 
            // icedLatteBtn
            // 
            this.icedLatteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.icedLatteBtn.Location = new System.Drawing.Point(126, 160);
            this.icedLatteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.icedLatteBtn.Name = "icedLatteBtn";
            this.icedLatteBtn.Size = new System.Drawing.Size(133, 58);
            this.icedLatteBtn.TabIndex = 6;
            this.icedLatteBtn.Text = "Iced Latte";
            this.icedLatteBtn.UseVisualStyleBackColor = false;
            this.icedLatteBtn.Click += new System.EventHandler(this.icedLatteBtn_Click);
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.BackColor = System.Drawing.Color.Olive;
            this.coffeeBtn.Location = new System.Drawing.Point(296, 105);
            this.coffeeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(133, 58);
            this.coffeeBtn.TabIndex = 7;
            this.coffeeBtn.Text = "Coffee";
            this.coffeeBtn.UseVisualStyleBackColor = false;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // matchaGreenBtn
            // 
            this.matchaGreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.matchaGreenBtn.Location = new System.Drawing.Point(126, 217);
            this.matchaGreenBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.matchaGreenBtn.Name = "matchaGreenBtn";
            this.matchaGreenBtn.Size = new System.Drawing.Size(133, 58);
            this.matchaGreenBtn.TabIndex = 8;
            this.matchaGreenBtn.Text = "Matcha Latte";
            this.matchaGreenBtn.UseVisualStyleBackColor = false;
            this.matchaGreenBtn.Click += new System.EventHandler(this.matchaGreenBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.waterBtn.Location = new System.Drawing.Point(296, 160);
            this.waterBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(133, 58);
            this.waterBtn.TabIndex = 9;
            this.waterBtn.Text = "Water";
            this.waterBtn.UseVisualStyleBackColor = false;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // minusBtnQ
            // 
            this.minusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minusBtnQ.Location = new System.Drawing.Point(485, 105);
            this.minusBtnQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minusBtnQ.Name = "minusBtnQ";
            this.minusBtnQ.Size = new System.Drawing.Size(49, 80);
            this.minusBtnQ.TabIndex = 22;
            this.minusBtnQ.Text = "-";
            this.minusBtnQ.UseVisualStyleBackColor = false;
            this.minusBtnQ.Click += new System.EventHandler(this.minusBtnQ_Click);
            // 
            // plusBtnQ
            // 
            this.plusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plusBtnQ.Location = new System.Drawing.Point(622, 105);
            this.plusBtnQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plusBtnQ.Name = "plusBtnQ";
            this.plusBtnQ.Size = new System.Drawing.Size(49, 80);
            this.plusBtnQ.TabIndex = 23;
            this.plusBtnQ.Text = "+";
            this.plusBtnQ.UseVisualStyleBackColor = false;
            this.plusBtnQ.Click += new System.EventHandler(this.plusBtnQ_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.BackColor = System.Drawing.Color.White;
            this.subTotalLabel.Location = new System.Drawing.Point(996, 279);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.ReadOnly = true;
            this.subTotalLabel.Size = new System.Drawing.Size(203, 31);
            this.subTotalLabel.TabIndex = 28;
            this.subTotalLabel.Text = "0.00";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.BackColor = System.Drawing.Color.White;
            this.salesTaxLabel.Location = new System.Drawing.Point(996, 314);
            this.salesTaxLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.ReadOnly = true;
            this.salesTaxLabel.Size = new System.Drawing.Size(203, 31);
            this.salesTaxLabel.TabIndex = 29;
            this.salesTaxLabel.Text = "0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(996, 351);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.ReadOnly = true;
            this.totalLabel.Size = new System.Drawing.Size(203, 31);
            this.totalLabel.TabIndex = 30;
            this.totalLabel.Text = "0.00";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.payButton.Location = new System.Drawing.Point(996, 420);
            this.payButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(204, 100);
            this.payButton.TabIndex = 31;
            this.payButton.Text = "Complete Order";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // espressoBtn
            // 
            this.espressoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.espressoBtn.Location = new System.Drawing.Point(296, 217);
            this.espressoBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espressoBtn.Name = "espressoBtn";
            this.espressoBtn.Size = new System.Drawing.Size(133, 58);
            this.espressoBtn.TabIndex = 32;
            this.espressoBtn.Text = "Espresso";
            this.espressoBtn.UseVisualStyleBackColor = false;
            this.espressoBtn.Click += new System.EventHandler(this.espressoBtn_Click);
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coffeeLabel.Location = new System.Drawing.Point(126, 69);
            this.coffeeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(327, 30);
            this.coffeeLabel.TabIndex = 34;
            this.coffeeLabel.Tag = "";
            this.coffeeLabel.Text = "Drinks";
            this.coffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDrinkBtn
            // 
            this.addDrinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addDrinkBtn.Location = new System.Drawing.Point(483, 185);
            this.addDrinkBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addDrinkBtn.Name = "addDrinkBtn";
            this.addDrinkBtn.Size = new System.Drawing.Size(206, 102);
            this.addDrinkBtn.TabIndex = 42;
            this.addDrinkBtn.Text = "Add Drink";
            this.addDrinkBtn.UseVisualStyleBackColor = false;
            this.addDrinkBtn.Click += new System.EventHandler(this.addDrinkBtn_Click);
            // 
            // qtyTxtbox
            // 
            this.qtyTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.qtyTxtbox.Location = new System.Drawing.Point(530, 105);
            this.qtyTxtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qtyTxtbox.Multiline = true;
            this.qtyTxtbox.Name = "qtyTxtbox";
            this.qtyTxtbox.ReadOnly = true;
            this.qtyTxtbox.Size = new System.Drawing.Size(102, 77);
            this.qtyTxtbox.TabIndex = 24;
            this.qtyTxtbox.Text = "Qty: \r\n1";
            this.qtyTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customizationListBox
            // 
            this.customizationListBox.FormattingEnabled = true;
            this.customizationListBox.Location = new System.Drawing.Point(60, 295);
            this.customizationListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customizationListBox.Name = "customizationListBox";
            this.customizationListBox.Size = new System.Drawing.Size(687, 256);
            this.customizationListBox.TabIndex = 51;
            // 
            // orderItems
            // 
            this.orderItems.Location = new System.Drawing.Point(847, 22);
            this.orderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderItems.Multiline = true;
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(447, 232);
            this.orderItems.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(884, 279);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 31);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "Sub-Total: $";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(884, 316);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(104, 31);
            this.textBox2.TabIndex = 54;
            this.textBox2.Text = "Sales Tax:   $";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(884, 351);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(104, 31);
            this.textBox3.TabIndex = 55;
            this.textBox3.Text = "Total:         $";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1679, 883);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.orderItems);
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
            this.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1701, 939);
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
        private TextBox orderItems;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}