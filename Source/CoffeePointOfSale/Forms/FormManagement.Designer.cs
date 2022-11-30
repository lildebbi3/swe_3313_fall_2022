namespace CoffeePointOfSale.Forms
{
    partial class FormManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.GenerateCSVbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(0, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Main Menu";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // GenerateCSVbtn
            // 
            this.GenerateCSVbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenerateCSVbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GenerateCSVbtn.Location = new System.Drawing.Point(460, 214);
            this.GenerateCSVbtn.Name = "GenerateCSVbtn";
            this.GenerateCSVbtn.Size = new System.Drawing.Size(267, 76);
            this.GenerateCSVbtn.TabIndex = 2;
            this.GenerateCSVbtn.Text = "Generate CSV";
            this.GenerateCSVbtn.UseVisualStyleBackColor = false;
            this.GenerateCSVbtn.Click += new System.EventHandler(this.GenerateCSVbtn_Click);
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 569);
            this.Controls.Add(this.GenerateCSVbtn);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1091, 606);
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoadFormManagement);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClose;
        private Button GenerateCSVbtn;
    }
}