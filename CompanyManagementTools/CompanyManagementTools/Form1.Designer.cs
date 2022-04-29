
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
            this.EmployeeRosterTab = new System.Windows.Forms.TabPage();
            this.ProfitLossTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.CompanyListTab.SuspendLayout();
            this.EmployeeRosterTab.SuspendLayout();
            this.ProfitLossTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.CompanyListTab.Controls.Add(this.button3);
            this.CompanyListTab.Controls.Add(this.button2);
            this.CompanyListTab.Controls.Add(this.button1);
            this.CompanyListTab.Controls.Add(this.dataGridView1);
            this.CompanyListTab.Location = new System.Drawing.Point(4, 25);
            this.CompanyListTab.Name = "CompanyListTab";
            this.CompanyListTab.Padding = new System.Windows.Forms.Padding(3);
            this.CompanyListTab.Size = new System.Drawing.Size(974, 650);
            this.CompanyListTab.TabIndex = 0;
            this.CompanyListTab.Text = "Companies";
            this.CompanyListTab.UseVisualStyleBackColor = true;
            // 
            // EmployeeRosterTab
            // 
            this.EmployeeRosterTab.Controls.Add(this.button6);
            this.EmployeeRosterTab.Controls.Add(this.button5);
            this.EmployeeRosterTab.Controls.Add(this.button4);
            this.EmployeeRosterTab.Controls.Add(this.comboBox2);
            this.EmployeeRosterTab.Controls.Add(this.dataGridView2);
            this.EmployeeRosterTab.Location = new System.Drawing.Point(4, 25);
            this.EmployeeRosterTab.Name = "EmployeeRosterTab";
            this.EmployeeRosterTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeRosterTab.Size = new System.Drawing.Size(974, 650);
            this.EmployeeRosterTab.TabIndex = 1;
            this.EmployeeRosterTab.Text = "Employee Roster";
            this.EmployeeRosterTab.UseVisualStyleBackColor = true;
            // 
            // ProfitLossTab
            // 
            this.ProfitLossTab.Controls.Add(this.chart1);
            this.ProfitLossTab.Controls.Add(this.comboBox1);
            this.ProfitLossTab.Location = new System.Drawing.Point(4, 25);
            this.ProfitLossTab.Name = "ProfitLossTab";
            this.ProfitLossTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfitLossTab.Size = new System.Drawing.Size(974, 650);
            this.ProfitLossTab.TabIndex = 2;
            this.ProfitLossTab.Text = "Profit & Loss";
            this.ProfitLossTab.UseVisualStyleBackColor = true;
            this.ProfitLossTab.Click += new System.EventHandler(this.ProfitLossTab_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 609);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(954, 579);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(954, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(954, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(954, 601);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(727, 621);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(893, 621);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(812, 621);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(731, 621);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
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
            this.EmployeeRosterTab.ResumeLayout(false);
            this.ProfitLossTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage CompanyListTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage EmployeeRosterTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage ProfitLossTab;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

