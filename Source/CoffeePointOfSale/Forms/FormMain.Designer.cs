namespace CoffeePointOfSale.Forms;

sealed partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
<<<<<<< HEAD
            this.btnManagement.Location = new System.Drawing.Point(337, 268);
=======
            this.btnManagement.Location = new System.Drawing.Point(46, 40);
>>>>>>> 9413816b87ee774ed162a227f6caca73a7f341aa
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(140, 22);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(317, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Customer Listing ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnClickBtnCustomerListing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Jeff\'s Ordering Coffee System (JOCS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManagement);
<<<<<<< HEAD
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
=======
>>>>>>> 9413816b87ee774ed162a227f6caca73a7f341aa
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnManagement;
    private Button button1;
    private Button button2;
    private Label label1;
}