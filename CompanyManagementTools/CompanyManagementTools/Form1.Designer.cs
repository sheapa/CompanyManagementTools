
namespace CompanyManagementTools
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.CompanyListTab = new System.Windows.Forms.TabPage();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.dgCompanies = new System.Windows.Forms.DataGridView();
            this.EmployeeRosterTab = new System.Windows.Forms.TabPage();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.cmbRoster = new System.Windows.Forms.ComboBox();
            this.dgRoster = new System.Windows.Forms.DataGridView();
            this.ProfitLossTab = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbRevenue = new System.Windows.Forms.ComboBox();
            this.MainTab.SuspendLayout();
            this.CompanyListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).BeginInit();
            this.EmployeeRosterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoster)).BeginInit();
            this.ProfitLossTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.CompanyListTab);
            this.MainTab.Controls.Add(this.EmployeeRosterTab);
            this.MainTab.Controls.Add(this.ProfitLossTab);
            this.MainTab.Location = new System.Drawing.Point(-2, 1);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(982, 679);
            this.MainTab.TabIndex = 0;
            // 
            // CompanyListTab
            // 
            this.CompanyListTab.Controls.Add(this.btnAddCompany);
            this.CompanyListTab.Controls.Add(this.btnEditCompany);
            this.CompanyListTab.Controls.Add(this.btnDeleteCompany);
            this.CompanyListTab.Controls.Add(this.dgCompanies);
            this.CompanyListTab.Location = new System.Drawing.Point(4, 25);
            this.CompanyListTab.Name = "CompanyListTab";
            this.CompanyListTab.Padding = new System.Windows.Forms.Padding(3);
            this.CompanyListTab.Size = new System.Drawing.Size(974, 650);
            this.CompanyListTab.TabIndex = 0;
            this.CompanyListTab.Text = "Companies";
            this.CompanyListTab.UseVisualStyleBackColor = true;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(727, 621);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 3;
            this.btnAddCompany.Text = "Add";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Location = new System.Drawing.Point(808, 621);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(75, 23);
            this.btnEditCompany.TabIndex = 2;
            this.btnEditCompany.Text = "Edit";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(889, 621);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCompany.TabIndex = 1;
            this.btnDeleteCompany.Text = "Delete";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            // 
            // dgCompanies
            // 
            this.dgCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompanies.Location = new System.Drawing.Point(10, 6);
            this.dgCompanies.Name = "dgCompanies";
            this.dgCompanies.RowHeadersWidth = 51;
            this.dgCompanies.RowTemplate.Height = 24;
            this.dgCompanies.Size = new System.Drawing.Size(954, 609);
            this.dgCompanies.TabIndex = 0;
            this.dgCompanies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeeRosterTab
            // 
            this.EmployeeRosterTab.Controls.Add(this.btnAddEmployee);
            this.EmployeeRosterTab.Controls.Add(this.btnEditEmployee);
            this.EmployeeRosterTab.Controls.Add(this.btnDeleteEmployee);
            this.EmployeeRosterTab.Controls.Add(this.cmbRoster);
            this.EmployeeRosterTab.Controls.Add(this.dgRoster);
            this.EmployeeRosterTab.Location = new System.Drawing.Point(4, 25);
            this.EmployeeRosterTab.Name = "EmployeeRosterTab";
            this.EmployeeRosterTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeRosterTab.Size = new System.Drawing.Size(974, 650);
            this.EmployeeRosterTab.TabIndex = 1;
            this.EmployeeRosterTab.Text = "Employee Roster";
            this.EmployeeRosterTab.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(731, 621);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(812, 621);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmployee.TabIndex = 4;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(893, 621);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // cmbRoster
            // 
            this.cmbRoster.FormattingEnabled = true;
            this.cmbRoster.Location = new System.Drawing.Point(10, 6);
            this.cmbRoster.Name = "cmbRoster";
            this.cmbRoster.Size = new System.Drawing.Size(954, 24);
            this.cmbRoster.TabIndex = 2;
            this.cmbRoster.Text = "Please Select a Company";
            this.cmbRoster.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dgRoster
            // 
            this.dgRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoster.Location = new System.Drawing.Point(10, 36);
            this.dgRoster.Name = "dgRoster";
            this.dgRoster.RowHeadersWidth = 51;
            this.dgRoster.RowTemplate.Height = 24;
            this.dgRoster.Size = new System.Drawing.Size(954, 579);
            this.dgRoster.TabIndex = 1;
            this.dgRoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ProfitLossTab
            // 
            this.ProfitLossTab.Controls.Add(this.chartRevenue);
            this.ProfitLossTab.Controls.Add(this.cmbRevenue);
            this.ProfitLossTab.Location = new System.Drawing.Point(4, 25);
            this.ProfitLossTab.Name = "ProfitLossTab";
            this.ProfitLossTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfitLossTab.Size = new System.Drawing.Size(974, 650);
            this.ProfitLossTab.TabIndex = 2;
            this.ProfitLossTab.Text = "Profit & Loss";
            this.ProfitLossTab.UseVisualStyleBackColor = true;
            this.ProfitLossTab.Click += new System.EventHandler(this.ProfitLossTab_Click);
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(10, 37);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(954, 601);
            this.chartRevenue.TabIndex = 3;
            this.chartRevenue.Text = "chart1";
            // 
            // cmbRevenue
            // 
            this.cmbRevenue.FormattingEnabled = true;
            this.cmbRevenue.Location = new System.Drawing.Point(10, 7);
            this.cmbRevenue.Name = "cmbRevenue";
            this.cmbRevenue.Size = new System.Drawing.Size(954, 24);
            this.cmbRevenue.TabIndex = 2;
            this.cmbRevenue.Text = "Please Select a Company";
            this.cmbRevenue.SelectedIndexChanged += new System.EventHandler(this.cmbRevenue_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 676);
            this.Controls.Add(this.MainTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTab.ResumeLayout(false);
            this.CompanyListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).EndInit();
            this.EmployeeRosterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoster)).EndInit();
            this.ProfitLossTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage CompanyListTab;
        private System.Windows.Forms.DataGridView dgCompanies;
        private System.Windows.Forms.TabPage EmployeeRosterTab;
        private System.Windows.Forms.DataGridView dgRoster;
        private System.Windows.Forms.TabPage ProfitLossTab;
        private System.Windows.Forms.ComboBox cmbRoster;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.ComboBox cmbRevenue;
    }
}

