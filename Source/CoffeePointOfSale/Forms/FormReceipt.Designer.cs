﻿namespace CoffeePointOfSale.Forms
{
    partial class FormReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.RecceiptMainMenubtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.recieptTxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // RecceiptMainMenubtn
            // 
            this.RecceiptMainMenubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RecceiptMainMenubtn.Location = new System.Drawing.Point(14, 15);
            this.RecceiptMainMenubtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecceiptMainMenubtn.Name = "RecceiptMainMenubtn";
            this.RecceiptMainMenubtn.Size = new System.Drawing.Size(150, 80);
            this.RecceiptMainMenubtn.TabIndex = 0;
            this.RecceiptMainMenubtn.Text = "MainMenu";
            this.RecceiptMainMenubtn.UseVisualStyleBackColor = false;
            this.RecceiptMainMenubtn.Click += new System.EventHandler(this.RecceiptMainMenubtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // recieptTxtbox
            // 
            this.recieptTxtbox.Location = new System.Drawing.Point(471, 4);
            this.recieptTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recieptTxtbox.Multiline = true;
            this.recieptTxtbox.Name = "recieptTxtbox";
            this.recieptTxtbox.Size = new System.Drawing.Size(470, 694);
            this.recieptTxtbox.TabIndex = 1;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.recieptTxtbox);
            this.Controls.Add(this.RecceiptMainMenubtn);
            this.Margin = new System.Windows.Forms.Padding(4, 11, 4, 11);
            this.Name = "FormReceipt";
            this.Text = "Jeff\'s Coffee Shop";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RecceiptMainMenubtn;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox recieptTxtbox;
    }
}