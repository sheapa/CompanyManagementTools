using CompanyManagementTools.CompanyForms;
using CompanyManagementTools.EmployeeForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            if (dgRoster.Rows.Count > 0)
            {
               
            }

        }

        private void ProfitLossTab_Click(object sender, EventArgs e)
        {

        }

       
        /// <item>
        /// Allows user to select company and view list of employees.
        /// </item>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            List<Employee> listOfEmployees = new List<Employee>();

            string selection = (cmbRoster.SelectedItem).ToString();
            int companyId = 0;

            using (var dbEnt = new CMTEntities1())
            {
                var EmployeeCompanySelect = from c in dbEnt.Companies
                                            where c.CompanyName == selection
                                            select c.CompanyId;
                companyId = EmployeeCompanySelect.FirstOrDefault();

            }

            using (var dbEnt2 = new CMTEntities1())
            {
                dbEnt2.Configuration.LazyLoadingEnabled = false;
                listOfEmployees = dbEnt2.Employees.Where(d => d.CompanyId == companyId).Select(g => g).ToList();
                                       
            }

            dgRoster.DataSource = listOfEmployees;

        }
        /// <item>
        /// Loads list of companies for form 1 company list tab.
        /// </item>
        public void LoadMainCompanyList()
        {
            List<Company> companies = new List<Company>();
            using (var db = new CMTEntities1())
            {
               db.Configuration.LazyLoadingEnabled = false;
               companies = db.Companies.Select(x => x).OrderBy(company => company.CompanyName).ToList();
            }
            dgCompanies.DataSource = companies;
           
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
        
        }

        public void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm add = new AddEditEmployeeForm();
            add.ShowDialog(btnAddEmployee);
            load_dgRoster();

        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployeeForm edit = new EditEmployeeForm();
            edit.ShowDialog(btnEditEmployee);
            load_dgRoster();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyForm add = new AddCompanyForm();
            add.ShowDialog(btnAddCompany);
            LoadMainCompanyList();
        }

        private void btnRefreshCompanies_Click(object sender, EventArgs e)
        {
            LoadMainCompanyList();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            UpdateCompanyForm edit = new UpdateCompanyForm();
            edit.ShowDialog(btnEditCompany);
            LoadMainCompanyList();
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            DeleteCompanyForm delete = new DeleteCompanyForm();
            delete.ShowDialog(btnDeleteCompany);
            LoadMainCompanyList();
        }

        private void load_dgRoster()
        {
            List<Employee> listOfEmployees = new List<Employee>();

            string selection = (cmbRoster.SelectedItem).ToString();
            int companyId = 0;

            using (var dbEnt = new CMTEntities1())
            {
                var EmployeeCompanySelect = from c in dbEnt.Companies
                                            where c.CompanyName == selection
                                            select c.CompanyId;
                companyId = EmployeeCompanySelect.FirstOrDefault();

            }

            using (var dbEnt2 = new CMTEntities1())
            {
                dbEnt2.Configuration.LazyLoadingEnabled = false;
                listOfEmployees = dbEnt2.Employees.Where(d => d.CompanyId == companyId).Select(g => g).ToList();

            }

            dgRoster.DataSource = listOfEmployees;
        }
    }
}
