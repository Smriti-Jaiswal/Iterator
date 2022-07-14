namespace WindowsIterator
{
    partial class frmCustomer
    {
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.

        private void InitializeComponent()
        {
            this.btnGetByIndex = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetByIndex
            // 
            this.btnGetByIndex.Location = new System.Drawing.Point(0, 0);
            this.btnGetByIndex.Name = "btnGetByIndex";
            this.btnGetByIndex.Size = new System.Drawing.Size(75, 23);
            this.btnGetByIndex.TabIndex = 13;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(81, 60);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(57, 25);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(166, 60);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 25);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.Location = new System.Drawing.Point(0, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(100, 23);
            this.lblIndex.TabIndex = 12;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(43, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(26, 13);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Day:";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(43, 37);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(32, 13);
            this.lblCustomerCode.TabIndex = 8;
            this.lblCustomerCode.Text = "Code:";
            this.lblCustomerCode.Click += new System.EventHandler(this.lblCustomerCode_Click);
            // 
            // txtCustomerName
            // 
            this.txtDay.Location = new System.Drawing.Point(81, 8);
            this.txtDay.Name = "txtCustomerName";
            this.txtDay.Size = new System.Drawing.Size(143, 20);
            this.txtDay.TabIndex = 9;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(81, 34);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerCode.TabIndex = 10;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 97);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblCustomerCode);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnGetByIndex);
            this.Name = "frmCustomer";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetByIndex;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtCustomerCode;
    }
}

