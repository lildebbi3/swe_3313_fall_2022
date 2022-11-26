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
            this.SuspendLayout();
            // 
            // paymentCancelBtn
            // 
            this.paymentCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.paymentCancelBtn.Location = new System.Drawing.Point(1, 2);
            this.paymentCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.paymentCancelBtn.Name = "paymentCancelBtn";
            this.paymentCancelBtn.Size = new System.Drawing.Size(154, 53);
            this.paymentCancelBtn.TabIndex = 1;
            this.paymentCancelBtn.Text = "Cancel Order";
            this.paymentCancelBtn.UseVisualStyleBackColor = false;
            this.paymentCancelBtn.Click += new System.EventHandler(this.paymentCancelBtn_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1685, 901);
            this.Controls.Add(this.paymentCancelBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.ResumeLayout(false);

        }

        #endregion

        private Button paymentCancelBtn;
    }
}