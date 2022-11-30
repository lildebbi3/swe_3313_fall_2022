namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.paymentCancelBtn = new System.Windows.Forms.Button();
            this.ccNumTxtbox = new System.Windows.Forms.TextBox();
            this.ExpDateTxtbox = new System.Windows.Forms.TextBox();
            this.cvvTxtbox = new System.Windows.Forms.TextBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.ExpDateLabel = new System.Windows.Forms.Label();
            this.CvvLabel = new System.Windows.Forms.Label();
            this.CCPaymentBtn = new System.Windows.Forms.Button();
            this.RewardPaymentBtn = new System.Windows.Forms.Button();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.CCwarningLabel = new System.Windows.Forms.Label();
            this.orderItems = new System.Windows.Forms.ListBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.salestaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.rpToEarnLabel = new System.Windows.Forms.Label();
            this.rpCostLabel = new System.Windows.Forms.Label();
            this.currentRPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentCancelBtn
            // 
            this.paymentCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paymentCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.paymentCancelBtn.Location = new System.Drawing.Point(1, 2);
            this.paymentCancelBtn.Name = "paymentCancelBtn";
            this.paymentCancelBtn.Size = new System.Drawing.Size(123, 43);
            this.paymentCancelBtn.TabIndex = 1;
            this.paymentCancelBtn.Text = "Cancel Order";
            this.paymentCancelBtn.UseVisualStyleBackColor = false;
            this.paymentCancelBtn.Click += new System.EventHandler(this.paymentCancelBtn_Click);
            // 
            // ccNumTxtbox
            // 
            this.ccNumTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ccNumTxtbox.Location = new System.Drawing.Point(450, 346);
            this.ccNumTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.ccNumTxtbox.Name = "ccNumTxtbox";
            this.ccNumTxtbox.PlaceholderText = "****-****-****-****";
            this.ccNumTxtbox.Size = new System.Drawing.Size(239, 27);
            this.ccNumTxtbox.TabIndex = 6;
            // 
            // ExpDateTxtbox
            // 
            this.ExpDateTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExpDateTxtbox.Location = new System.Drawing.Point(450, 402);
            this.ExpDateTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.ExpDateTxtbox.Name = "ExpDateTxtbox";
            this.ExpDateTxtbox.PlaceholderText = "mm/yy";
            this.ExpDateTxtbox.Size = new System.Drawing.Size(239, 27);
            this.ExpDateTxtbox.TabIndex = 7;
            // 
            // cvvTxtbox
            // 
            this.cvvTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cvvTxtbox.Location = new System.Drawing.Point(450, 458);
            this.cvvTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.cvvTxtbox.Name = "cvvTxtbox";
            this.cvvTxtbox.PlaceholderText = "123";
            this.cvvTxtbox.Size = new System.Drawing.Size(239, 27);
            this.cvvTxtbox.TabIndex = 8;
            // 
            // cardLabel
            // 
            this.cardLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardLabel.AutoSize = true;
            this.cardLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardLabel.Location = new System.Drawing.Point(384, 353);
            this.cardLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(53, 20);
            this.cardLabel.TabIndex = 9;
            this.cardLabel.Text = "Card #";
            // 
            // ExpDateLabel
            // 
            this.ExpDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExpDateLabel.AutoSize = true;
            this.ExpDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExpDateLabel.Location = new System.Drawing.Point(371, 405);
            this.ExpDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ExpDateLabel.Name = "ExpDateLabel";
            this.ExpDateLabel.Size = new System.Drawing.Size(68, 20);
            this.ExpDateLabel.TabIndex = 10;
            this.ExpDateLabel.Text = "Exp.Date";
            // 
            // CvvLabel
            // 
            this.CvvLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CvvLabel.AutoSize = true;
            this.CvvLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CvvLabel.Location = new System.Drawing.Point(400, 461);
            this.CvvLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CvvLabel.Name = "CvvLabel";
            this.CvvLabel.Size = new System.Drawing.Size(36, 20);
            this.CvvLabel.TabIndex = 11;
            this.CvvLabel.Text = "CVV";
            // 
            // CCPaymentBtn
            // 
            this.CCPaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CCPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CCPaymentBtn.Location = new System.Drawing.Point(308, 577);
            this.CCPaymentBtn.Name = "CCPaymentBtn";
            this.CCPaymentBtn.Size = new System.Drawing.Size(213, 43);
            this.CCPaymentBtn.TabIndex = 12;
            this.CCPaymentBtn.Text = "Pay With CC";
            this.CCPaymentBtn.UseVisualStyleBackColor = false;
            this.CCPaymentBtn.Click += new System.EventHandler(this.CCPaymentBtn_Click);
            // 
            // RewardPaymentBtn
            // 
            this.RewardPaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RewardPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RewardPaymentBtn.Enabled = false;
            this.RewardPaymentBtn.Location = new System.Drawing.Point(574, 577);
            this.RewardPaymentBtn.Name = "RewardPaymentBtn";
            this.RewardPaymentBtn.Size = new System.Drawing.Size(213, 43);
            this.RewardPaymentBtn.TabIndex = 13;
            this.RewardPaymentBtn.Text = "Pay With Rewards";
            this.RewardPaymentBtn.UseVisualStyleBackColor = false;
            this.RewardPaymentBtn.Click += new System.EventHandler(this.RewardPaymentBtn_Click);
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderTotalLabel.Location = new System.Drawing.Point(356, 142);
            this.orderTotalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(84, 20);
            this.orderTotalLabel.TabIndex = 14;
            this.orderTotalLabel.Text = "Order Total";
            // 
            // CCwarningLabel
            // 
            this.CCwarningLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CCwarningLabel.AutoSize = true;
            this.CCwarningLabel.ForeColor = System.Drawing.Color.Red;
            this.CCwarningLabel.Location = new System.Drawing.Point(322, 521);
            this.CCwarningLabel.Name = "CCwarningLabel";
            this.CCwarningLabel.Size = new System.Drawing.Size(443, 20);
            this.CCwarningLabel.TabIndex = 16;
            this.CCwarningLabel.Text = "The info you provided is incorrect or incomplete, please try again.";
            this.CCwarningLabel.Visible = false;
            // 
            // orderItems
            // 
            this.orderItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderItems.FormattingEnabled = true;
            this.orderItems.ItemHeight = 20;
            this.orderItems.Location = new System.Drawing.Point(450, 32);
            this.orderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(239, 164);
            this.orderItems.TabIndex = 17;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subtotalLabel.Location = new System.Drawing.Point(429, 232);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(123, 20);
            this.subtotalLabel.TabIndex = 18;
            this.subtotalLabel.Text = "Sub-Total: $00.00";
            // 
            // salestaxLabel
            // 
            this.salestaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salestaxLabel.AutoSize = true;
            this.salestaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salestaxLabel.Location = new System.Drawing.Point(429, 259);
            this.salestaxLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.salestaxLabel.Name = "salestaxLabel";
            this.salestaxLabel.Size = new System.Drawing.Size(118, 20);
            this.salestaxLabel.TabIndex = 19;
            this.salestaxLabel.Text = "Sales Tax: $00.00";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalLabel.Location = new System.Drawing.Point(429, 284);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(92, 20);
            this.totalLabel.TabIndex = 20;
            this.totalLabel.Text = "Total: $00.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rpToEarnLabel
            // 
            this.rpToEarnLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpToEarnLabel.AutoSize = true;
            this.rpToEarnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rpToEarnLabel.Location = new System.Drawing.Point(564, 284);
            this.rpToEarnLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rpToEarnLabel.Name = "rpToEarnLabel";
            this.rpToEarnLabel.Size = new System.Drawing.Size(92, 20);
            this.rpToEarnLabel.TabIndex = 22;
            this.rpToEarnLabel.Text = "RP to Earn: 0";
            this.rpToEarnLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rpCostLabel
            // 
            this.rpCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpCostLabel.AutoSize = true;
            this.rpCostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rpCostLabel.Location = new System.Drawing.Point(564, 259);
            this.rpCostLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rpCostLabel.Name = "rpCostLabel";
            this.rpCostLabel.Size = new System.Drawing.Size(74, 20);
            this.rpCostLabel.TabIndex = 21;
            this.rpCostLabel.Text = "RP Cost: 0";
            // 
            // currentRPLabel
            // 
            this.currentRPLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentRPLabel.AutoSize = true;
            this.currentRPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentRPLabel.Location = new System.Drawing.Point(564, 232);
            this.currentRPLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.currentRPLabel.Name = "currentRPLabel";
            this.currentRPLabel.Size = new System.Drawing.Size(139, 20);
            this.currentRPLabel.TabIndex = 23;
            this.currentRPLabel.Text = "Customer\'s Points: 0";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.currentRPLabel);
            this.Controls.Add(this.rpToEarnLabel);
            this.Controls.Add(this.rpCostLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salestaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.orderItems);
            this.Controls.Add(this.CCwarningLabel);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.RewardPaymentBtn);
            this.Controls.Add(this.CCPaymentBtn);
            this.Controls.Add(this.CvvLabel);
            this.Controls.Add(this.ExpDateLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.cvvTxtbox);
            this.Controls.Add(this.ExpDateTxtbox);
            this.Controls.Add(this.ccNumTxtbox);
            this.Controls.Add(this.paymentCancelBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1091, 606);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button paymentCancelBtn;
        private TextBox ccNumTxtbox;
        private TextBox ExpDateTxtbox;
        private TextBox cvvTxtbox;
        private Label cardLabel;
        private Label ExpDateLabel;
        private Label CvvLabel;
        private Button CCPaymentBtn;
        private Button RewardPaymentBtn;
        private Label orderTotalLabel;
        private Label CCwarningLabel;
        private ListBox orderItems;
        private Label subtotalLabel;
        private Label salestaxLabel;
        private Label totalLabel;
        private Label rpToEarnLabel;
        private Label rpCostLabel;
        private Label currentRPLabel;
    }
}