
namespace CompanyManagementTools.EmployeeForms
{
    partial class AddEditEmployeeForm
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
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.btnCancelEmployee = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.calendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.lblEmployeeStart = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cmbEployeeCompany = new System.Windows.Forms.ComboBox();
            this.lblEmployeeCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.Location = new System.Drawing.Point(523, 260);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeSave.TabIndex = 6;
            this.btnEmployeeSave.Text = "Save";
            this.btnEmployeeSave.UseVisualStyleBackColor = true;
            this.btnEmployeeSave.Click += new System.EventHandler(this.btnEmployeeSave_Click);
            // 
            // btnCancelEmployee
            // 
            this.btnCancelEmployee.Location = new System.Drawing.Point(442, 260);
            this.btnCancelEmployee.Name = "btnCancelEmployee";
            this.btnCancelEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEmployee.TabIndex = 5;
            this.btnCancelEmployee.Text = "Cancel";
            this.btnCancelEmployee.UseVisualStyleBackColor = true;
            this.btnCancelEmployee.Click += new System.EventHandler(this.btnCancelEmployee_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 83);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 83);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(223, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // calendarStartDate
            // 
            this.calendarStartDate.Location = new System.Drawing.Point(336, 41);
            this.calendarStartDate.Name = "calendarStartDate";
            this.calendarStartDate.TabIndex = 4;
            // 
            // lblEmployeeStart
            // 
            this.lblEmployeeStart.AutoSize = true;
            this.lblEmployeeStart.Location = new System.Drawing.Point(394, 15);
            this.lblEmployeeStart.Name = "lblEmployeeStart";
            this.lblEmployeeStart.Size = new System.Drawing.Size(138, 17);
            this.lblEmployeeStart.TabIndex = 6;
            this.lblEmployeeStart.Text = "Employee Start Date";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(223, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 124);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(101, 162);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(223, 22);
            this.txtSalary.TabIndex = 3;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(17, 162);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 17);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Salary";
            // 
            // cmbEployeeCompany
            // 
            this.cmbEployeeCompany.FormattingEnabled = true;
            this.cmbEployeeCompany.Location = new System.Drawing.Point(101, 41);
            this.cmbEployeeCompany.Name = "cmbEployeeCompany";
            this.cmbEployeeCompany.Size = new System.Drawing.Size(223, 24);
            this.cmbEployeeCompany.TabIndex = 0;
            this.cmbEployeeCompany.Text = "Please Select a Company";
            this.cmbEployeeCompany.SelectedIndexChanged += new System.EventHandler(this.cmbEployeeCompany_SelectedIndexChanged);
            // 
            // lblEmployeeCompany
            // 
            this.lblEmployeeCompany.AutoSize = true;
            this.lblEmployeeCompany.Location = new System.Drawing.Point(19, 44);
            this.lblEmployeeCompany.Name = "lblEmployeeCompany";
            this.lblEmployeeCompany.Size = new System.Drawing.Size(67, 17);
            this.lblEmployeeCompany.TabIndex = 12;
            this.lblEmployeeCompany.Text = "Company";
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.Controls.Add(this.lblEmployeeCompany);
            this.Controls.Add(this.cmbEployeeCompany);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblEmployeeStart);
            this.Controls.Add(this.calendarStartDate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnCancelEmployee);
            this.Controls.Add(this.btnEmployeeSave);
            this.Name = "AddEditEmployeeForm";
            this.Text = "AddEditEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeSave;
        private System.Windows.Forms.Button btnCancelEmployee;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.MonthCalendar calendarStartDate;
        private System.Windows.Forms.Label lblEmployeeStart;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cmbEployeeCompany;
        private System.Windows.Forms.Label lblEmployeeCompany;
    }
}