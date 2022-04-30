using CompanyManagementTools.EmployeeForms;
using CompanyManagementTools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMainCompanyList();
            LoadComboBoxes();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProfitLossTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <item>
        /// Allows user to select company and view list of employees.
        /// </item>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> listOfEmployees = new List<Employee>();

            string selection = (cmbRoster.SelectedItem).ToString();

            using (var dbEnt = new CMTEntities1())
            {
                var EmployeeCompanySelect = from c in dbEnt.Companies
                                            where c.CompanyName == selection
                                            select c.CompanyId;
                int companyId = EmployeeCompanySelect.FirstOrDefault();

                var EmployeeListSelect = from emp in dbEnt.Employees
                                         where emp.CompanyId == companyId
                                         select emp;
                foreach (Employee employee in EmployeeListSelect)
                {
                    listOfEmployees.Add(employee);
                }
                dgRoster.DataSource = listOfEmployees.ToList();
            }
        }
        /// <item>
        /// Loads list of companies for form 1 company list tab.
        /// </item>
        private void LoadMainCompanyList()
        {
            using (var db = new CMTEntities1())
            {
                List<Company> companies = new List<Company>();

                var query = from c in db.Companies
                            orderby c.CompanyName
                            select c;
                foreach (Company company in query)
                {
                    companies.Add(company);
                }

                dgCompanies.DataSource = companies;

            }
        }

        /// <item>
        /// Loads list of companys for comboboxes on profit/loss & employee list tabs of form1.
        /// </item>
        private void LoadComboBoxes()
        {
            using (var db = new CMTEntities1())
            {

                var CompanyQuery = from c in db.Companies
                                   orderby c.CompanyName
                                   select c;
                foreach (Company company in CompanyQuery)
                {
                    cmbRoster.Items.Add(company.CompanyName);
                    cmbRevenue.Items.Add(company.CompanyName);
                }


            }

        }
        /// <item>
        /// Allows user to select company and view list of employees.
        /// </item>
        private void cmbRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Annual_Incomes> listOfRevenue = new List<Annual_Incomes>();

            //string selection = (cmbRevenue.SelectedItem).ToString();

            //using (var dbEnt = new CMTEntities1())
            //{
            //    var RevenueCompanySelect =  from c in dbEnt.Companies
            //                                where c.CompanyName == selection
            //                                select c.CompanyId;
            //    int companyId = EmployeeCompanySelect.FirstOrDefault();

            //    var EmployeeListSelect = from emp in dbEnt.Employees
            //                             where emp.CompanyId == companyId
            //                             select emp;
            //    foreach (Annual_Incomes revenue in listOfRevenue)
            //    {
            //        listOfRevenue.Add(revenue);
            //    }
            //    chartRevenue.DataSource = listOfRevenue;
            //}
        }

        public void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm edit = new AddEditEmployeeForm();
            edit.Show(btnAddEmployee);
            

        }
    }
}
