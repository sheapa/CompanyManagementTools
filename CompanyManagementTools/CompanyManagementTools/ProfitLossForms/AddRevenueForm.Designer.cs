
namespace CompanyManagementTools.ProfitLossForms
{
    partial class AddRevenueForm
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
            this.btnSaveRevenue = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.cmbCompanyRevenue = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtRevenueYear = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveRevenue
            // 
            this.btnSaveRevenue.Location = new System.Drawing.Point(312, 156);
            this.btnSaveRevenue.Name = "btnSaveRevenue";
            this.btnSaveRevenue.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRevenue.TabIndex = 0;
            this.btnSaveRevenue.Text = "Save";
            this.btnSaveRevenue.UseVisualStyleBackColor = true;
            this.btnSaveRevenue.Click += new System.EventHandler(this.btnSaveRevenue_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(231, 156);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbCompanyRevenue
            // 
            this.cmbCompanyRevenue.FormattingEnabled = true;
            this.cmbCompanyRevenue.Location = new System.Drawing.Point(85, 42);
            this.cmbCompanyRevenue.Name = "cmbCompanyRevenue";
            this.cmbCompanyRevenue.Size = new System.Drawing.Size(265, 24);
            this.cmbCompanyRevenue.TabIndex = 2;
            this.cmbCompanyRevenue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(82, 86);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // txtRevenueYear
            // 
            this.txtRevenueYear.Location = new System.Drawing.Point(153, 83);
            this.txtRevenueYear.Name = "txtRevenueYear";
            this.txtRevenueYear.Size = new System.Drawing.Size(197, 22);
            this.txtRevenueYear.TabIndex = 4;
            this.txtRevenueYear.TextChanged += new System.EventHandler(this.txtRevenueYear_TextChanged);
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(153, 128);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(197, 22);
            this.txtRevenue.TabIndex = 6;
            this.txtRevenue.TextChanged += new System.EventHandler(this.txtRevenue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Revenue";
            // 
            // AddRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 188);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRevenueYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbCompanyRevenue);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnSaveRevenue);
            this.Name = "AddRevenueForm";
            this.Text = "AddRevenueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveRevenue;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox cmbCompanyRevenue;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtRevenueYear;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Label label2;
    }
}