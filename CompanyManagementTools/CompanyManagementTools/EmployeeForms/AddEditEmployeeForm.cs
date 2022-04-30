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
    public partial class AddEditEmployeeForm : Form
    {
        public AddEditEmployeeForm()
        {
            InitializeComponent();
            LoadComboBox();
        }
     

        private void cmbEployeeCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBox()
        {
            using (var db = new CMTEntities1())
            {
                var CompanyQuery = from c in db.Companies
                                   orderby c.CompanyName
                                   select c;
                foreach (Company company in CompanyQuery)
                {
                    cmbEployeeCompany.Items.Add(company.CompanyName);
                }
            }

        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            string selection = (cmbEployeeCompany.SelectedItem).ToString();


            using (var dbEnt = new CMTEntities1())
            {
                var EmployeeCompanySelect = from c in dbEnt.Companies
                                            where c.CompanyName == selection
                                            select c.CompanyId;
                int companyId = EmployeeCompanySelect.FirstOrDefault();

                Employee emp = new Employee();
                emp.CompanyId = companyId;
                emp.EmpFirst = txtFirstName.Text;
                emp.EmpLast = txtLastName.Text;
                emp.EmpSalary = Int32.Parse(txtSalary.Text);
                emp.EmpStart = calendarStartDate.SelectionStart;
                bool result = SaveEmployee(emp);
                //ShowStatus(result, "Save");
            };
            this.Close();
        }

        public bool SaveEmployee(Employee emp)
        {
            bool result = false;
            using (CMTEntities1 _entity = new CMTEntities1())
            {
                _entity.Employees.Add(emp);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
       
    }
}   
