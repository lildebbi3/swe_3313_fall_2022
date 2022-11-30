namespace CoffeePointOfSale.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // RecceiptMainMenubtn
            // 
            this.RecceiptMainMenubtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecceiptMainMenubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RecceiptMainMenubtn.Location = new System.Drawing.Point(0, 2);
            this.RecceiptMainMenubtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecceiptMainMenubtn.Name = "RecceiptMainMenubtn";
            this.RecceiptMainMenubtn.Size = new System.Drawing.Size(108, 32);
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
            this.recieptItems.ItemHeight = 15;
            this.recieptItems.Location = new System.Drawing.Point(330, 2);
            this.recieptItems.Name = "recieptItems";
            this.recieptItems.Size = new System.Drawing.Size(330, 334);
            this.recieptItems.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalLabel.Location = new System.Drawing.Point(330, 390);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(71, 15);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "Total: $00.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salestaxLabel
            // 
            this.salestaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salestaxLabel.AutoSize = true;
            this.salestaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salestaxLabel.Location = new System.Drawing.Point(330, 371);
            this.salestaxLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.salestaxLabel.Name = "salestaxLabel";
            this.salestaxLabel.Size = new System.Drawing.Size(92, 15);
            this.salestaxLabel.TabIndex = 22;
            this.salestaxLabel.Text = "Sales Tax: $00.00";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subtotalLabel.Location = new System.Drawing.Point(330, 351);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(96, 15);
            this.subtotalLabel.TabIndex = 21;
            this.subtotalLabel.Text = "Sub-Total: $00.00";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(941, 427);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salestaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.recieptItems);
            this.Controls.Add(this.RecceiptMainMenubtn);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(957, 466);
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
    }
}