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
            this.recieptItems = new System.Windows.Forms.ListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.salestaxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.rpLabel = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.guidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // RecceiptMainMenubtn
            // 
            this.RecceiptMainMenubtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecceiptMainMenubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RecceiptMainMenubtn.Location = new System.Drawing.Point(137, 3);
            this.RecceiptMainMenubtn.Name = "RecceiptMainMenubtn";
            this.RecceiptMainMenubtn.Size = new System.Drawing.Size(123, 43);
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
            // recieptItems
            // 
            this.recieptItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recieptItems.FormattingEnabled = true;
            this.recieptItems.ItemHeight = 20;
            this.recieptItems.Location = new System.Drawing.Point(456, 13);
            this.recieptItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recieptItems.Name = "recieptItems";
            this.recieptItems.Size = new System.Drawing.Size(331, 344);
            this.recieptItems.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalLabel.Location = new System.Drawing.Point(456, 484);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(92, 20);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "Total: $00.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salestaxLabel
            // 
            this.salestaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salestaxLabel.AutoSize = true;
            this.salestaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salestaxLabel.Location = new System.Drawing.Point(456, 459);
            this.salestaxLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.salestaxLabel.Name = "salestaxLabel";
            this.salestaxLabel.Size = new System.Drawing.Size(118, 20);
            this.salestaxLabel.TabIndex = 22;
            this.salestaxLabel.Text = "Sales Tax: $00.00";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subtotalLabel.Location = new System.Drawing.Point(456, 432);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(123, 20);
            this.subtotalLabel.TabIndex = 21;
            this.subtotalLabel.Text = "Sub-Total: $00.00";
            // 
            // rpLabel
            // 
            this.rpLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpLabel.AutoSize = true;
            this.rpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rpLabel.Location = new System.Drawing.Point(649, 459);
            this.rpLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rpLabel.Name = "rpLabel";
            this.rpLabel.Size = new System.Drawing.Size(138, 20);
            this.rpLabel.TabIndex = 24;
            this.rpLabel.Text = "RP earned/payed: 0";
            // 
            // ccLabel
            // 
            this.ccLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ccLabel.AutoSize = true;
            this.ccLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ccLabel.Location = new System.Drawing.Point(649, 432);
            this.ccLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(159, 20);
            this.ccLabel.TabIndex = 26;
            this.ccLabel.Text = "Payment Method: Card";
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetimeLabel.AutoSize = true;
            this.datetimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datetimeLabel.Location = new System.Drawing.Point(649, 484);
            this.datetimeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(114, 20);
            this.datetimeLabel.TabIndex = 27;
            this.datetimeLabel.Text = "Date and Time: ";
            // 
            // guidLabel
            // 
            this.guidLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guidLabel.AutoSize = true;
            this.guidLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guidLabel.Location = new System.Drawing.Point(456, 509);
            this.guidLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.guidLabel.Name = "guidLabel";
            this.guidLabel.Size = new System.Drawing.Size(255, 20);
            this.guidLabel.TabIndex = 28;
            this.guidLabel.Text = "Customer\'s GUID: 165-a11-51e65-s16";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.guidLabel);
            this.Controls.Add(this.datetimeLabel);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.rpLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salestaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.recieptItems);
            this.Controls.Add(this.RecceiptMainMenubtn);
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1091, 606);
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeff\'s Coffee Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RecceiptMainMenubtn;
        private FileSystemWatcher fileSystemWatcher1;
        private ListBox recieptItems;
        private Label totalLabel;
        private Label salestaxLabel;
        private Label subtotalLabel;
        private Label pointsEarnedLabel;
        private Label paymentMethodLabel;
        private Label ccLabel;
        private Label rpLabel;
        private Label datetimeLabel;
        private Label guidLabel;
    }
}