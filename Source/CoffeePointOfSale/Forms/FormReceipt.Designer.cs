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
            this.recieptTxtbox = new System.Windows.Forms.TextBox();
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
            // recieptTxtbox
            // 
            this.recieptTxtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recieptTxtbox.Location = new System.Drawing.Point(330, 2);
            this.recieptTxtbox.Multiline = true;
            this.recieptTxtbox.Name = "recieptTxtbox";
            this.recieptTxtbox.Size = new System.Drawing.Size(330, 418);
            this.recieptTxtbox.TabIndex = 1;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(941, 427);
            this.Controls.Add(this.recieptTxtbox);
            this.Controls.Add(this.RecceiptMainMenubtn);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(957, 466);
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jeff\'s Coffee Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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