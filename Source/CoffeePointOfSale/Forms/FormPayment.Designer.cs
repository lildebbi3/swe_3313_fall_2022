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
            this.orderTotalTxtbox = new System.Windows.Forms.TextBox();
            this.CCwarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentCancelBtn
            // 
            this.paymentCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.paymentCancelBtn.Location = new System.Drawing.Point(0, 4);
            this.paymentCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.paymentCancelBtn.Name = "paymentCancelBtn";
            this.paymentCancelBtn.Size = new System.Drawing.Size(154, 54);
            this.paymentCancelBtn.TabIndex = 1;
            this.paymentCancelBtn.Text = "Cancel Order";
            this.paymentCancelBtn.UseVisualStyleBackColor = false;
            this.paymentCancelBtn.Click += new System.EventHandler(this.paymentCancelBtn_Click);
            // 
            // ccNumTxtbox
            // 
            this.ccNumTxtbox.Location = new System.Drawing.Point(531, 258);
            this.ccNumTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.ccNumTxtbox.Name = "ccNumTxtbox";
            this.ccNumTxtbox.Size = new System.Drawing.Size(298, 31);
            this.ccNumTxtbox.TabIndex = 6;
            // 
            // ExpDateTxtbox
            // 
            this.ExpDateTxtbox.Location = new System.Drawing.Point(531, 328);
            this.ExpDateTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.ExpDateTxtbox.Name = "ExpDateTxtbox";
            this.ExpDateTxtbox.Size = new System.Drawing.Size(298, 31);
            this.ExpDateTxtbox.TabIndex = 7;
            // 
            // cvvTxtbox
            // 
            this.cvvTxtbox.Location = new System.Drawing.Point(531, 398);
            this.cvvTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.cvvTxtbox.Name = "cvvTxtbox";
            this.cvvTxtbox.Size = new System.Drawing.Size(298, 31);
            this.cvvTxtbox.TabIndex = 8;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardLabel.Location = new System.Drawing.Point(449, 266);
            this.cardLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(65, 25);
            this.cardLabel.TabIndex = 9;
            this.cardLabel.Text = "Card #";
            // 
            // ExpDateLabel
            // 
            this.ExpDateLabel.AutoSize = true;
            this.ExpDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExpDateLabel.Location = new System.Drawing.Point(433, 332);
            this.ExpDateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ExpDateLabel.Name = "ExpDateLabel";
            this.ExpDateLabel.Size = new System.Drawing.Size(81, 25);
            this.ExpDateLabel.TabIndex = 10;
            this.ExpDateLabel.Text = "Exp.Date";
            // 
            // CvvLabel
            // 
            this.CvvLabel.AutoSize = true;
            this.CvvLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CvvLabel.Location = new System.Drawing.Point(469, 401);
            this.CvvLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CvvLabel.Name = "CvvLabel";
            this.CvvLabel.Size = new System.Drawing.Size(45, 25);
            this.CvvLabel.TabIndex = 11;
            this.CvvLabel.Text = "CVV";
            // 
            // CCPaymentBtn
            // 
            this.CCPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CCPaymentBtn.Location = new System.Drawing.Point(355, 546);
            this.CCPaymentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CCPaymentBtn.Name = "CCPaymentBtn";
            this.CCPaymentBtn.Size = new System.Drawing.Size(266, 54);
            this.CCPaymentBtn.TabIndex = 12;
            this.CCPaymentBtn.Text = "Pay With CC";
            this.CCPaymentBtn.UseVisualStyleBackColor = false;
            this.CCPaymentBtn.Click += new System.EventHandler(this.CCPaymentBtn_Click);
            // 
            // RewardPaymentBtn
            // 
            this.RewardPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RewardPaymentBtn.Location = new System.Drawing.Point(686, 546);
            this.RewardPaymentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RewardPaymentBtn.Name = "RewardPaymentBtn";
            this.RewardPaymentBtn.Size = new System.Drawing.Size(266, 54);
            this.RewardPaymentBtn.TabIndex = 13;
            this.RewardPaymentBtn.Text = "Pay With Rewards";
            this.RewardPaymentBtn.UseVisualStyleBackColor = false;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderTotalLabel.Location = new System.Drawing.Point(414, 168);
            this.orderTotalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(100, 25);
            this.orderTotalLabel.TabIndex = 14;
            this.orderTotalLabel.Text = "Order Total";
            // 
            // orderTotalTxtbox
            // 
            this.orderTotalTxtbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderTotalTxtbox.Location = new System.Drawing.Point(531, 31);
            this.orderTotalTxtbox.Margin = new System.Windows.Forms.Padding(1);
            this.orderTotalTxtbox.Multiline = true;
            this.orderTotalTxtbox.Name = "orderTotalTxtbox";
            this.orderTotalTxtbox.ReadOnly = true;
            this.orderTotalTxtbox.Size = new System.Drawing.Size(298, 209);
            this.orderTotalTxtbox.TabIndex = 15;
            // 
            // CCwarningLabel
            // 
            this.CCwarningLabel.AutoSize = true;
            this.CCwarningLabel.ForeColor = System.Drawing.Color.Red;
            this.CCwarningLabel.Location = new System.Drawing.Point(371, 476);
            this.CCwarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CCwarningLabel.Name = "CCwarningLabel";
            this.CCwarningLabel.Size = new System.Drawing.Size(530, 25);
            this.CCwarningLabel.TabIndex = 16;
            this.CCwarningLabel.Text = "The info you provided is incorrect or incomplete, please try again.";
            this.CCwarningLabel.Visible = false;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.CCwarningLabel);
            this.Controls.Add(this.orderTotalTxtbox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.MaximizeBox = true;
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
        private TextBox orderTotalTxtbox;
        private Label CCwarningLabel;
    }
}