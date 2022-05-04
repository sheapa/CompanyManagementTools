
namespace CompanyManagementTools.EmployeeForms
{
    partial class DeleteEmployeeForm
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
            this.cmbDeleteEmployee = new System.Windows.Forms.ComboBox();
            this.btnCancelDeleteEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.cmbSelectEmpDeleteComp = new System.Windows.Forms.ComboBox();
            this.txtEmpDeleteId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbDeleteEmployee
            // 
            this.cmbDeleteEmployee.FormattingEnabled = true;
            this.cmbDeleteEmployee.Location = new System.Drawing.Point(48, 74);
            this.cmbDeleteEmployee.Name = "cmbDeleteEmployee";
            this.cmbDeleteEmployee.Size = new System.Drawing.Size(390, 24);
            this.cmbDeleteEmployee.TabIndex = 0;
            this.cmbDeleteEmployee.Text = "Please Select An Employee";
            this.cmbDeleteEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteEmployee_SelectedIndexChanged);
            // 
            // btnCancelDeleteEmployee
            // 
            this.btnCancelDeleteEmployee.Location = new System.Drawing.Point(142, 104);
            this.btnCancelDeleteEmployee.Name = "btnCancelDeleteEmployee";
            this.btnCancelDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDeleteEmployee.TabIndex = 1;
            this.btnCancelDeleteEmployee.Text = "Cancel";
            this.btnCancelDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnCancelDeleteEmployee.Click += new System.EventHandler(this.btnCancelDeleteEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(223, 104);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // cmbSelectEmpDeleteComp
            // 
            this.cmbSelectEmpDeleteComp.FormattingEnabled = true;
            this.cmbSelectEmpDeleteComp.Location = new System.Drawing.Point(48, 44);
            this.cmbSelectEmpDeleteComp.Name = "cmbSelectEmpDeleteComp";
            this.cmbSelectEmpDeleteComp.Size = new System.Drawing.Size(390, 24);
            this.cmbSelectEmpDeleteComp.TabIndex = 3;
            this.cmbSelectEmpDeleteComp.Text = "Please Select An Employee";
            this.cmbSelectEmpDeleteComp.SelectedIndexChanged += new System.EventHandler(this.cmbSelectEmpDeleteComp_SelectedIndexChanged);
            // 
            // txtEmpDeleteId
            // 
            this.txtEmpDeleteId.Location = new System.Drawing.Point(368, 137);
            this.txtEmpDeleteId.Name = "txtEmpDeleteId";
            this.txtEmpDeleteId.Size = new System.Drawing.Size(100, 22);
            this.txtEmpDeleteId.TabIndex = 4;
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 161);
            this.Controls.Add(this.txtEmpDeleteId);
            this.Controls.Add(this.cmbSelectEmpDeleteComp);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnCancelDeleteEmployee);
            this.Controls.Add(this.cmbDeleteEmployee);
            this.Name = "DeleteEmployeeForm";
            this.Text = "DeleteEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeleteEmployee;
        private System.Windows.Forms.Button btnCancelDeleteEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.ComboBox cmbSelectEmpDeleteComp;
        private System.Windows.Forms.TextBox txtEmpDeleteId;
    }
}