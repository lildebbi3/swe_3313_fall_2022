﻿namespace CoffeePointOfSale.Forms
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
            this.txtDeleteThis = new System.Windows.Forms.TextBox();
            this.GenerateCSVbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(430, 358);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // txtDeleteThis
            // 
            this.txtDeleteThis.Location = new System.Drawing.Point(436, 159);
            this.txtDeleteThis.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeleteThis.Multiline = true;
            this.txtDeleteThis.Name = "txtDeleteThis";
            this.txtDeleteThis.Size = new System.Drawing.Size(299, 120);
            this.txtDeleteThis.TabIndex = 1;
            // 
            // GenerateCSVbtn
            // 
            this.GenerateCSVbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GenerateCSVbtn.Location = new System.Drawing.Point(606, 358);
            this.GenerateCSVbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateCSVbtn.Name = "GenerateCSVbtn";
            this.GenerateCSVbtn.Size = new System.Drawing.Size(139, 36);
            this.GenerateCSVbtn.TabIndex = 2;
            this.GenerateCSVbtn.Text = "Generate CSV";
            this.GenerateCSVbtn.UseVisualStyleBackColor = false;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.GenerateCSVbtn);
            this.Controls.Add(this.txtDeleteThis);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagement";
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.OnLoadFormManagement);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private TextBox txtDeleteThis;
        private Button GenerateCSVbtn;
    }
}