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
            this.coffeeObtn = new System.Windows.Forms.Button();
            this.espressoObtn = new System.Windows.Forms.Button();
            this.mgtlObtn = new System.Windows.Forms.Button();
            this.latteObtn = new System.Windows.Forms.Button();
            this.cappuccinoObtn = new System.Windows.Forms.Button();
            this.minusBtnQ = new System.Windows.Forms.Button();
            this.plusBtnQ = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.orderItems = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.waterObtn = new System.Windows.Forms.Button();
            this.teaObtn = new System.Windows.Forms.Button();
            this.coffeeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wholeMilkCB = new System.Windows.Forms.CheckBox();
            this.nFMilkCB = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.custmzGroup = new System.Windows.Forms.GroupBox();
            this.coldRBtn = new System.Windows.Forms.RadioButton();
            this.hotRBtn = new System.Windows.Forms.RadioButton();
            this.chocolateSCB = new System.Windows.Forms.CheckBox();
            this.whippedCreamCB = new System.Windows.Forms.CheckBox();
            this.foamCB = new System.Windows.Forms.CheckBox();
            this.sNLCB = new System.Windows.Forms.CheckBox();
            this.steviaCB = new System.Windows.Forms.CheckBox();
            this.sugarCB = new System.Windows.Forms.CheckBox();
            this.soyMilkCB = new System.Windows.Forms.CheckBox();
            this.almondMilkCB = new System.Windows.Forms.CheckBox();
            this.oatMilkCB = new System.Windows.Forms.CheckBox();
            this.addDrinkBtn = new System.Windows.Forms.Button();
            this.sizesGroup = new System.Windows.Forms.GroupBox();
            this.largeRBtn = new System.Windows.Forms.RadioButton();
            this.regularRBtn = new System.Windows.Forms.RadioButton();
            this.smallRBtn = new System.Windows.Forms.RadioButton();
            this.QtyTxtbox = new System.Windows.Forms.TextBox();
            this.custmzGroup.SuspendLayout();
            this.sizesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mainMenuBtn.Location = new System.Drawing.Point(0, 2);
            this.mainMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(108, 32);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // coffeeObtn
            // 
            this.coffeeObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.coffeeObtn.Location = new System.Drawing.Point(149, 65);
            this.coffeeObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coffeeObtn.Name = "coffeeObtn";
            this.coffeeObtn.Size = new System.Drawing.Size(93, 35);
            this.coffeeObtn.TabIndex = 3;
            this.coffeeObtn.Text = "Coffee";
            this.coffeeObtn.UseVisualStyleBackColor = false;
            this.coffeeObtn.Click += new System.EventHandler(this.coffeeObtn_Click);
            // 
            // espressoObtn
            // 
            this.espressoObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.espressoObtn.Location = new System.Drawing.Point(149, 110);
            this.espressoObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.espressoObtn.Name = "espressoObtn";
            this.espressoObtn.Size = new System.Drawing.Size(93, 35);
            this.espressoObtn.TabIndex = 6;
            this.espressoObtn.Text = "Espresso";
            this.espressoObtn.UseVisualStyleBackColor = false;
            this.espressoObtn.Click += new System.EventHandler(this.espressoObtn_Click);
            // 
            // mgtlObtn
            // 
            this.mgtlObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mgtlObtn.Location = new System.Drawing.Point(285, 66);
            this.mgtlObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mgtlObtn.Name = "mgtlObtn";
            this.mgtlObtn.Size = new System.Drawing.Size(93, 35);
            this.mgtlObtn.TabIndex = 7;
            this.mgtlObtn.Text = "Matcha Green Tea Latte";
            this.mgtlObtn.UseVisualStyleBackColor = false;
            this.mgtlObtn.Click += new System.EventHandler(this.mgtlObtn_Click);
            // 
            // latteObtn
            // 
            this.latteObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.latteObtn.Location = new System.Drawing.Point(149, 155);
            this.latteObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.latteObtn.Name = "latteObtn";
            this.latteObtn.Size = new System.Drawing.Size(93, 35);
            this.latteObtn.TabIndex = 8;
            this.latteObtn.Text = "Latte";
            this.latteObtn.UseVisualStyleBackColor = false;
            this.latteObtn.Click += new System.EventHandler(this.latteObtn_Click);
            // 
            // cappuccinoObtn
            // 
            this.cappuccinoObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cappuccinoObtn.Location = new System.Drawing.Point(285, 110);
            this.cappuccinoObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cappuccinoObtn.Name = "cappuccinoObtn";
            this.cappuccinoObtn.Size = new System.Drawing.Size(93, 35);
            this.cappuccinoObtn.TabIndex = 9;
            this.cappuccinoObtn.Text = "Cappuccino";
            this.cappuccinoObtn.UseVisualStyleBackColor = false;
            this.cappuccinoObtn.Click += new System.EventHandler(this.cappuccinoObtn_Click);
            // 
            // minusBtnQ
            // 
            this.minusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minusBtnQ.Location = new System.Drawing.Point(416, 226);
            this.minusBtnQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minusBtnQ.Name = "minusBtnQ";
            this.minusBtnQ.Size = new System.Drawing.Size(34, 28);
            this.minusBtnQ.TabIndex = 22;
            this.minusBtnQ.Text = "-";
            this.minusBtnQ.UseVisualStyleBackColor = false;
            this.minusBtnQ.Click += new System.EventHandler(this.minusBtnQ_Click);
            // 
            // plusBtnQ
            // 
            this.plusBtnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plusBtnQ.Location = new System.Drawing.Point(526, 226);
            this.plusBtnQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plusBtnQ.Name = "plusBtnQ";
            this.plusBtnQ.Size = new System.Drawing.Size(34, 28);
            this.plusBtnQ.TabIndex = 23;
            this.plusBtnQ.Text = "+";
            this.plusBtnQ.UseVisualStyleBackColor = false;
            this.plusBtnQ.Click += new System.EventHandler(this.plusBtnQ_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button17.Location = new System.Drawing.Point(1026, 317);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(101, 22);
            this.button17.TabIndex = 26;
            this.button17.Text = "Pay via RPoints";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // orderItems
            // 
            this.orderItems.Location = new System.Drawing.Point(608, 14);
            this.orderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderItems.Multiline = true;
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(299, 186);
            this.orderItems.TabIndex = 27;
            this.orderItems.Text = "Orders: ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox6.Location = new System.Drawing.Point(764, 214);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 23);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "Sub-Total:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox7.Location = new System.Drawing.Point(764, 241);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 23);
            this.textBox7.TabIndex = 29;
            this.textBox7.Text = "Sales Tax: ";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox8.Location = new System.Drawing.Point(764, 268);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(143, 23);
            this.textBox8.TabIndex = 30;
            this.textBox8.Text = "Total: ";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.payButton.Location = new System.Drawing.Point(764, 327);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(143, 60);
            this.payButton.TabIndex = 31;
            this.payButton.Text = "Complete Order";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // waterObtn
            // 
            this.waterObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.waterObtn.Location = new System.Drawing.Point(417, 65);
            this.waterObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waterObtn.Name = "waterObtn";
            this.waterObtn.Size = new System.Drawing.Size(93, 35);
            this.waterObtn.TabIndex = 32;
            this.waterObtn.Text = "Water";
            this.waterObtn.UseVisualStyleBackColor = false;
            this.waterObtn.Click += new System.EventHandler(this.waterObtn_Click);
            // 
            // teaObtn
            // 
            this.teaObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.teaObtn.Location = new System.Drawing.Point(417, 110);
            this.teaObtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teaObtn.Name = "teaObtn";
            this.teaObtn.Size = new System.Drawing.Size(93, 35);
            this.teaObtn.TabIndex = 33;
            this.teaObtn.Text = "Tea";
            this.teaObtn.UseVisualStyleBackColor = false;
            this.teaObtn.Click += new System.EventHandler(this.teaObtn_Click);
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coffeeLabel.Location = new System.Drawing.Point(149, 37);
            this.coffeeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(229, 18);
            this.coffeeLabel.TabIndex = 34;
            this.coffeeLabel.Tag = "";
            this.coffeeLabel.Text = "Coffees";
            this.coffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(416, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 35;
            this.label1.Tag = "";
            this.label1.Text = "Others";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wholeMilkCB
            // 
            this.wholeMilkCB.AutoSize = true;
            this.wholeMilkCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wholeMilkCB.Location = new System.Drawing.Point(4, 39);
            this.wholeMilkCB.Margin = new System.Windows.Forms.Padding(2);
            this.wholeMilkCB.Name = "wholeMilkCB";
            this.wholeMilkCB.Size = new System.Drawing.Size(86, 19);
            this.wholeMilkCB.TabIndex = 38;
            this.wholeMilkCB.Text = "Whole Milk";
            this.wholeMilkCB.UseVisualStyleBackColor = false;
            // 
            // nFMilkCB
            // 
            this.nFMilkCB.AutoSize = true;
            this.nFMilkCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nFMilkCB.Location = new System.Drawing.Point(4, 18);
            this.nFMilkCB.Margin = new System.Windows.Forms.Padding(2);
            this.nFMilkCB.Name = "nFMilkCB";
            this.nFMilkCB.Size = new System.Drawing.Size(96, 19);
            this.nFMilkCB.TabIndex = 39;
            this.nFMilkCB.Text = "Non-Fat Milk";
            this.nFMilkCB.UseVisualStyleBackColor = false;
            // 
            // custmzGroup
            // 
            this.custmzGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custmzGroup.Controls.Add(this.coldRBtn);
            this.custmzGroup.Controls.Add(this.hotRBtn);
            this.custmzGroup.Controls.Add(this.chocolateSCB);
            this.custmzGroup.Controls.Add(this.whippedCreamCB);
            this.custmzGroup.Controls.Add(this.foamCB);
            this.custmzGroup.Controls.Add(this.sNLCB);
            this.custmzGroup.Controls.Add(this.steviaCB);
            this.custmzGroup.Controls.Add(this.sugarCB);
            this.custmzGroup.Controls.Add(this.soyMilkCB);
            this.custmzGroup.Controls.Add(this.almondMilkCB);
            this.custmzGroup.Controls.Add(this.oatMilkCB);
            this.custmzGroup.Controls.Add(this.wholeMilkCB);
            this.custmzGroup.Controls.Add(this.nFMilkCB);
            this.custmzGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.custmzGroup.Location = new System.Drawing.Point(16, 214);
            this.custmzGroup.Margin = new System.Windows.Forms.Padding(2);
            this.custmzGroup.Name = "custmzGroup";
            this.custmzGroup.Padding = new System.Windows.Forms.Padding(2);
            this.custmzGroup.Size = new System.Drawing.Size(362, 173);
            this.custmzGroup.TabIndex = 41;
            this.custmzGroup.TabStop = false;
            this.custmzGroup.Text = "Customizations";
            // 
            // coldRBtn
            // 
            this.coldRBtn.AutoSize = true;
            this.coldRBtn.Location = new System.Drawing.Point(271, 38);
            this.coldRBtn.Name = "coldRBtn";
            this.coldRBtn.Size = new System.Drawing.Size(77, 19);
            this.coldRBtn.TabIndex = 51;
            this.coldRBtn.TabStop = true;
            this.coldRBtn.Text = "Cold/Iced";
            this.coldRBtn.UseVisualStyleBackColor = true;
            this.coldRBtn.CheckedChanged += new System.EventHandler(this.coldRBtn_CheckedChanged);
            // 
            // hotRBtn
            // 
            this.hotRBtn.AutoSize = true;
            this.hotRBtn.Location = new System.Drawing.Point(271, 18);
            this.hotRBtn.Name = "hotRBtn";
            this.hotRBtn.Size = new System.Drawing.Size(45, 19);
            this.hotRBtn.TabIndex = 50;
            this.hotRBtn.TabStop = true;
            this.hotRBtn.Text = "Hot";
            this.hotRBtn.UseVisualStyleBackColor = true;
            this.hotRBtn.CheckedChanged += new System.EventHandler(this.hotRBtn_CheckedChanged);
            // 
            // chocolateSCB
            // 
            this.chocolateSCB.AutoSize = true;
            this.chocolateSCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chocolateSCB.Location = new System.Drawing.Point(131, 113);
            this.chocolateSCB.Margin = new System.Windows.Forms.Padding(2);
            this.chocolateSCB.Name = "chocolateSCB";
            this.chocolateSCB.Size = new System.Drawing.Size(113, 19);
            this.chocolateSCB.TabIndex = 49;
            this.chocolateSCB.Text = "Chocolate Syrup";
            this.chocolateSCB.UseVisualStyleBackColor = false;
            // 
            // whippedCreamCB
            // 
            this.whippedCreamCB.AutoSize = true;
            this.whippedCreamCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.whippedCreamCB.Location = new System.Drawing.Point(131, 92);
            this.whippedCreamCB.Margin = new System.Windows.Forms.Padding(2);
            this.whippedCreamCB.Name = "whippedCreamCB";
            this.whippedCreamCB.Size = new System.Drawing.Size(112, 19);
            this.whippedCreamCB.TabIndex = 48;
            this.whippedCreamCB.Text = "Whipped Cream";
            this.whippedCreamCB.UseVisualStyleBackColor = false;
            // 
            // foamCB
            // 
            this.foamCB.AutoSize = true;
            this.foamCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.foamCB.Location = new System.Drawing.Point(132, 134);
            this.foamCB.Margin = new System.Windows.Forms.Padding(2);
            this.foamCB.Name = "foamCB";
            this.foamCB.Size = new System.Drawing.Size(56, 19);
            this.foamCB.TabIndex = 47;
            this.foamCB.Text = "Foam";
            this.foamCB.UseVisualStyleBackColor = false;
            // 
            // sNLCB
            // 
            this.sNLCB.AutoSize = true;
            this.sNLCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sNLCB.Location = new System.Drawing.Point(131, 39);
            this.sNLCB.Margin = new System.Windows.Forms.Padding(2);
            this.sNLCB.Name = "sNLCB";
            this.sNLCB.Size = new System.Drawing.Size(94, 19);
            this.sNLCB.TabIndex = 46;
            this.sNLCB.Text = "Sweet\'N\'Low";
            this.sNLCB.UseVisualStyleBackColor = false;
            // 
            // steviaCB
            // 
            this.steviaCB.AutoSize = true;
            this.steviaCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.steviaCB.Location = new System.Drawing.Point(131, 60);
            this.steviaCB.Margin = new System.Windows.Forms.Padding(2);
            this.steviaCB.Name = "steviaCB";
            this.steviaCB.Size = new System.Drawing.Size(57, 19);
            this.steviaCB.TabIndex = 45;
            this.steviaCB.Text = "Stevia";
            this.steviaCB.UseVisualStyleBackColor = false;
            // 
            // sugarCB
            // 
            this.sugarCB.AutoSize = true;
            this.sugarCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sugarCB.Location = new System.Drawing.Point(131, 18);
            this.sugarCB.Margin = new System.Windows.Forms.Padding(2);
            this.sugarCB.Name = "sugarCB";
            this.sugarCB.Size = new System.Drawing.Size(56, 19);
            this.sugarCB.TabIndex = 44;
            this.sugarCB.Text = "Sugar";
            this.sugarCB.UseVisualStyleBackColor = false;
            // 
            // soyMilkCB
            // 
            this.soyMilkCB.AutoSize = true;
            this.soyMilkCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.soyMilkCB.Location = new System.Drawing.Point(5, 102);
            this.soyMilkCB.Margin = new System.Windows.Forms.Padding(2);
            this.soyMilkCB.Name = "soyMilkCB";
            this.soyMilkCB.Size = new System.Drawing.Size(71, 19);
            this.soyMilkCB.TabIndex = 43;
            this.soyMilkCB.Text = "Soy Milk";
            this.soyMilkCB.UseVisualStyleBackColor = false;
            // 
            // almondMilkCB
            // 
            this.almondMilkCB.AutoSize = true;
            this.almondMilkCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.almondMilkCB.Location = new System.Drawing.Point(5, 81);
            this.almondMilkCB.Margin = new System.Windows.Forms.Padding(2);
            this.almondMilkCB.Name = "almondMilkCB";
            this.almondMilkCB.Size = new System.Drawing.Size(95, 19);
            this.almondMilkCB.TabIndex = 42;
            this.almondMilkCB.Text = "Almond Milk";
            this.almondMilkCB.UseVisualStyleBackColor = false;
            // 
            // oatMilkCB
            // 
            this.oatMilkCB.AutoSize = true;
            this.oatMilkCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.oatMilkCB.Location = new System.Drawing.Point(5, 60);
            this.oatMilkCB.Margin = new System.Windows.Forms.Padding(2);
            this.oatMilkCB.Name = "oatMilkCB";
            this.oatMilkCB.Size = new System.Drawing.Size(71, 19);
            this.oatMilkCB.TabIndex = 41;
            this.oatMilkCB.Text = "Oat Milk";
            this.oatMilkCB.UseVisualStyleBackColor = false;
            // 
            // addDrinkBtn
            // 
            this.addDrinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addDrinkBtn.Location = new System.Drawing.Point(416, 285);
            this.addDrinkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDrinkBtn.Name = "addDrinkBtn";
            this.addDrinkBtn.Size = new System.Drawing.Size(144, 61);
            this.addDrinkBtn.TabIndex = 42;
            this.addDrinkBtn.Text = "Add Drink";
            this.addDrinkBtn.UseVisualStyleBackColor = false;
            this.addDrinkBtn.Click += new System.EventHandler(this.addDrinkBtn_Click);
            // 
            // sizesGroup
            // 
            this.sizesGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sizesGroup.Controls.Add(this.largeRBtn);
            this.sizesGroup.Controls.Add(this.regularRBtn);
            this.sizesGroup.Controls.Add(this.smallRBtn);
            this.sizesGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sizesGroup.Location = new System.Drawing.Point(16, 53);
            this.sizesGroup.Margin = new System.Windows.Forms.Padding(2);
            this.sizesGroup.Name = "sizesGroup";
            this.sizesGroup.Padding = new System.Windows.Forms.Padding(2);
            this.sizesGroup.Size = new System.Drawing.Size(92, 141);
            this.sizesGroup.TabIndex = 50;
            this.sizesGroup.TabStop = false;
            this.sizesGroup.Text = "Sizes";
            // 
            // largeRBtn
            // 
            this.largeRBtn.AutoSize = true;
            this.largeRBtn.Location = new System.Drawing.Point(5, 70);
            this.largeRBtn.Name = "largeRBtn";
            this.largeRBtn.Size = new System.Drawing.Size(54, 19);
            this.largeRBtn.TabIndex = 2;
            this.largeRBtn.TabStop = true;
            this.largeRBtn.Text = "Large";
            this.largeRBtn.UseVisualStyleBackColor = true;
            this.largeRBtn.CheckedChanged += new System.EventHandler(this.largeRBtn_CheckedChanged);
            // 
            // regularRBtn
            // 
            this.regularRBtn.AutoSize = true;
            this.regularRBtn.Location = new System.Drawing.Point(5, 45);
            this.regularRBtn.Name = "regularRBtn";
            this.regularRBtn.Size = new System.Drawing.Size(65, 19);
            this.regularRBtn.TabIndex = 1;
            this.regularRBtn.TabStop = true;
            this.regularRBtn.Text = "Regular";
            this.regularRBtn.UseVisualStyleBackColor = true;
            this.regularRBtn.CheckedChanged += new System.EventHandler(this.regularRBtn_CheckedChanged);
            // 
            // smallRBtn
            // 
            this.smallRBtn.AutoSize = true;
            this.smallRBtn.Location = new System.Drawing.Point(5, 21);
            this.smallRBtn.Name = "smallRBtn";
            this.smallRBtn.Size = new System.Drawing.Size(54, 19);
            this.smallRBtn.TabIndex = 0;
            this.smallRBtn.TabStop = true;
            this.smallRBtn.Text = "Small";
            this.smallRBtn.UseVisualStyleBackColor = true;
            this.smallRBtn.CheckedChanged += new System.EventHandler(this.smallRBtn_CheckedChanged);
            // 
            // QtyTxtbox
            // 
            this.QtyTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.QtyTxtbox.Location = new System.Drawing.Point(443, 216);
            this.QtyTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QtyTxtbox.Multiline = true;
            this.QtyTxtbox.Name = "QtyTxtbox";
            this.QtyTxtbox.ReadOnly = true;
            this.QtyTxtbox.Size = new System.Drawing.Size(89, 48);
            this.QtyTxtbox.TabIndex = 24;
            this.QtyTxtbox.Text = "Qty: 1";
            this.QtyTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(941, 427);
            this.Controls.Add(this.sizesGroup);
            this.Controls.Add(this.addDrinkBtn);
            this.Controls.Add(this.custmzGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coffeeLabel);
            this.Controls.Add(this.teaObtn);
            this.Controls.Add(this.waterObtn);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.orderItems);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.QtyTxtbox);
            this.Controls.Add(this.plusBtnQ);
            this.Controls.Add(this.minusBtnQ);
            this.Controls.Add(this.cappuccinoObtn);
            this.Controls.Add(this.latteObtn);
            this.Controls.Add(this.mgtlObtn);
            this.Controls.Add(this.espressoObtn);
            this.Controls.Add(this.coffeeObtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = true;
            this.Name = "FormOrder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Jeff\'s Coffee Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.custmzGroup.ResumeLayout(false);
            this.custmzGroup.PerformLayout();
            this.sizesGroup.ResumeLayout(false);
            this.sizesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mainMenuBtn;
        private Button coffeeObtn;
        private Button espressoObtn;
        private Button mgtlObtn;
        private Button latteObtn;
        private Button cappuccinoObtn;
        private Button minusBtnQ;
        private Button plusBtnQ;
        private Button button17;
        private TextBox orderItems;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button payButton;
        private Button waterObtn;
        private Button teaObtn;
        private Label coffeeLabel;
        private Label label1;
        private CheckBox wholeMilkCB;
        private CheckBox nFMilkCB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox custmzGroup;
        private CheckBox oatMilkCB;
        private CheckBox steviaCB;
        private CheckBox sugarCB;
        private CheckBox soyMilkCB;
        private CheckBox almondMilkCB;
        private CheckBox sNLCB;
        private CheckBox chocolateSCB;
        private CheckBox whippedCreamCB;
        private CheckBox foamCB;
        private Button addDrinkBtn;
        private GroupBox sizesGroup;
        private RadioButton smallRBtn;
        private RadioButton largeRBtn;
        private RadioButton regularRBtn;
        private RadioButton coldRBtn;
        private RadioButton hotRBtn;
        private TextBox QtyTxtbox;
    }
}