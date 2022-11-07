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
            this.OnClickBtntoMain1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OnClickBtntoMain1
            // 
            this.OnClickBtntoMain1.Location = new System.Drawing.Point(260, 159);
            this.OnClickBtntoMain1.Name = "OnClickBtntoMain1";
            this.OnClickBtntoMain1.Size = new System.Drawing.Size(141, 59);
            this.OnClickBtntoMain1.TabIndex = 0;
            this.OnClickBtntoMain1.Text = "Main";
            this.OnClickBtntoMain1.UseVisualStyleBackColor = true;
            this.OnClickBtntoMain1.Click += new System.EventHandler(this.OnClickBtnCustomerListing);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.OnClickBtntoMain1);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.ResumeLayout(false);

        }

        #endregion

        private Button OnClickBtntoMain1;
    }
}