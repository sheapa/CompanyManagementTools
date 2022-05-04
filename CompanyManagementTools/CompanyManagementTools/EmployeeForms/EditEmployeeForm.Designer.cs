
namespace CompanyManagementTools.EmployeeForms
{
    partial class EditEmployeeForm
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
            this.lblCompanySelect = new System.Windows.Forms.Label();
            this.cmbEditCompanySelect = new System.Windows.Forms.ComboBox();
            this.txtEditSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployeeStart = new System.Windows.Forms.Label();
            this.calendarEditStartDate = new System.Windows.Forms.MonthCalendar();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnEditCancelEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployeeSave = new System.Windows.Forms.Button();
            this.lblEmpSelect = new System.Windows.Forms.Label();
            this.cmbEditEmployeeSelect = new System.Windows.Forms.ComboBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCompanySelect
            // 
            this.lblCompanySelect.AutoSize = true;
            this.lblCompanySelect.Location = new System.Drawing.Point(14, 46);
            this.lblCompanySelect.Name = "lblCompanySelect";
            this.lblCompanySelect.Size = new System.Drawing.Size(67, 17);
            this.lblCompanySelect.TabIndex = 24;
            this.lblCompanySelect.Text = "Company";
            // 
            // cmbEditCompanySelect
            // 
            this.cmbEditCompanySelect.FormattingEnabled = true;
            this.cmbEditCompanySelect.Location = new System.Drawing.Point(99, 43);
            this.cmbEditCompanySelect.Name = "cmbEditCompanySelect";
            this.cmbEditCompanySelect.Size = new System.Drawing.Size(223, 24);
            this.cmbEditCompanySelect.TabIndex = 0;
            this.cmbEditCompanySelect.Text = "Please Select a Company";
            this.cmbEditCompanySelect.SelectedIndexChanged += new System.EventHandler(this.cmbEditCompanySelect_SelectedIndexChanged);
            // 
            // txtEditSalary
            // 
            this.txtEditSalary.Location = new System.Drawing.Point(99, 198);
            this.txtEditSalary.Name = "txtEditSalary";
            this.txtEditSalary.Size = new System.Drawing.Size(223, 22);
            this.txtEditSalary.TabIndex = 4;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 198);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 17);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(99, 160);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(223, 22);
            this.txtEditLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 160);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmployeeStart
            // 
            this.lblEmployeeStart.AutoSize = true;
            this.lblEmployeeStart.Location = new System.Drawing.Point(392, 17);
            this.lblEmployeeStart.Name = "lblEmployeeStart";
            this.lblEmployeeStart.Size = new System.Drawing.Size(138, 17);
            this.lblEmployeeStart.TabIndex = 18;
            this.lblEmployeeStart.Text = "Employee Start Date";
            // 
            // calendarEditStartDate
            // 
            this.calendarEditStartDate.Location = new System.Drawing.Point(334, 43);
            this.calendarEditStartDate.Name = "calendarEditStartDate";
            this.calendarEditStartDate.TabIndex = 5;
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(99, 119);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(223, 22);
            this.txtEditFirstName.TabIndex = 2;
            this.txtEditFirstName.TextChanged += new System.EventHandler(this.txtEditFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 119);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name";
            // 
            // btnEditCancelEmployee
            // 
            this.btnEditCancelEmployee.Location = new System.Drawing.Point(440, 262);
            this.btnEditCancelEmployee.Name = "btnEditCancelEmployee";
            this.btnEditCancelEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancelEmployee.TabIndex = 6;
            this.btnEditCancelEmployee.Text = "Cancel";
            this.btnEditCancelEmployee.UseVisualStyleBackColor = true;
            this.btnEditCancelEmployee.Click += new System.EventHandler(this.btnEditCancelEmployee_Click);
            // 
            // btnEditEmployeeSave
            // 
            this.btnEditEmployeeSave.Location = new System.Drawing.Point(521, 262);
            this.btnEditEmployeeSave.Name = "btnEditEmployeeSave";
            this.btnEditEmployeeSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmployeeSave.TabIndex = 7;
            this.btnEditEmployeeSave.Text = "Save";
            this.btnEditEmployeeSave.UseVisualStyleBackColor = true;
            this.btnEditEmployeeSave.Click += new System.EventHandler(this.btnEditEmployeeSave_Click);
            // 
            // lblEmpSelect
            // 
            this.lblEmpSelect.AutoSize = true;
            this.lblEmpSelect.Location = new System.Drawing.Point(14, 85);
            this.lblEmpSelect.Name = "lblEmpSelect";
            this.lblEmpSelect.Size = new System.Drawing.Size(70, 17);
            this.lblEmpSelect.TabIndex = 26;
            this.lblEmpSelect.Text = "Employee";
            // 
            // cmbEditEmployeeSelect
            // 
            this.cmbEditEmployeeSelect.FormattingEnabled = true;
            this.cmbEditEmployeeSelect.Location = new System.Drawing.Point(99, 82);
            this.cmbEditEmployeeSelect.Name = "cmbEditEmployeeSelect";
            this.cmbEditEmployeeSelect.Size = new System.Drawing.Size(223, 24);
            this.cmbEditEmployeeSelect.TabIndex = 1;
            this.cmbEditEmployeeSelect.Text = "Please Select an Employee";
            this.cmbEditEmployeeSelect.SelectedIndexChanged += new System.EventHandler(this.cmbEditEmployeeSelect_SelectedIndexChanged);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(99, 227);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 22);
            this.txtEmpId.TabIndex = 27;
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtEmpId_TextChanged);
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(99, 255);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(100, 22);
            this.txtCompanyId.TabIndex = 28;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblEmpSelect);
            this.Controls.Add(this.cmbEditEmployeeSelect);
            this.Controls.Add(this.lblCompanySelect);
            this.Controls.Add(this.cmbEditCompanySelect);
            this.Controls.Add(this.txtEditSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtEditLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblEmployeeStart);
            this.Controls.Add(this.calendarEditStartDate);
            this.Controls.Add(this.txtEditFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnEditCancelEmployee);
            this.Controls.Add(this.btnEditEmployeeSave);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanySelect;
        private System.Windows.Forms.ComboBox cmbEditCompanySelect;
        private System.Windows.Forms.TextBox txtEditSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmployeeStart;
        private System.Windows.Forms.MonthCalendar calendarEditStartDate;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnEditCancelEmployee;
        private System.Windows.Forms.Button btnEditEmployeeSave;
        private System.Windows.Forms.Label lblEmpSelect;
        private System.Windows.Forms.ComboBox cmbEditEmployeeSelect;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtCompanyId;
    }
}