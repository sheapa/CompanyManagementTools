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

namespace CompanyManagementTools.EmployeeForms
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
            LoadComboBox();
        }

        // Cancel Button
        private void btnEditCancelEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load company list to combobox.
        private void LoadComboBox()
        {
            using (var db = new CMTEntities1())
            {
                var CompanyQuery = from c in db.Companies
                                   orderby c.CompanyName
                                   select c;
                foreach (Company company in CompanyQuery)
                {
                    cmbEditCompanySelect.Items.Add(company.CompanyName);
                }
            }

        }

        private void cmbEditCompanySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select company from combobox
            //String conversion of combo company selection
            string companySelection = (cmbEditCompanySelect.SelectedItem).ToString();
            int companyId = 0;
            //Match combo selection company name to company name in object then store associated company Id.
            using (var dbEnt = new CMTEntities1())
            {
                companyId = dbEnt.Companies.Where(c => c.CompanyName == companySelection).Select(i => i.CompanyId).FirstOrDefault();
            }

            //Generate list of employees for selected company.
            //List<FullNameModel> listOfEmployees = new List<Employee>();
            using (var dbEnt2 = new CMTEntities1())
            {
                dbEnt2.Configuration.LazyLoadingEnabled = false;
                var listOfEmployees = dbEnt2.Employees.Where(d => d.CompanyId == companyId)
                                                      .Select(g => g.EmpFirst).ToList();

                cmbEditEmployeeSelect.DataSource = listOfEmployees;
            }

        }
    }
}
