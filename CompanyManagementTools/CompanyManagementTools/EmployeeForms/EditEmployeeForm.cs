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
            txtEmpId.Visible = false;
        }

        // Cancel Button
        private void btnEditCancelEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Load company list to combobox.
        private void LoadComboBox()
        {
            List<Company> companyList = new List<Company>();
            using (var db = new CMTEntities1())
            {
                var CompanyQuery = from c in db.Companies
                                   orderby c.CompanyName
                                   select c;
                foreach (Company company in CompanyQuery)
                {
                    //cmbEditCompanySelect.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbEditCompanySelect.Items.Add(company.CompanyName);
                }
            }

        }

        private  void  cmbEditCompanySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select company from combobox
            //String conversion of combo company selection
            string companySelection = (cmbEditCompanySelect.SelectedItem).ToString();
            int companyId = 0;
            //Match combo selection company name to company name in object then store associated company Id.
            using (var dbEnt = new CMTEntities1())
            {
                companyId = dbEnt.Companies.Where(c => c.CompanyName == companySelection)
                                           .Select(i => i.CompanyId).FirstOrDefault();
            }

            //Generate list of employees for selected company.
            var employeeTupleList = new List<Tuple<int, string>>();
            using (var dbEnt2 = new CMTEntities1())
            {
                dbEnt2.Configuration.LazyLoadingEnabled = false;
                var listOfEmployees = dbEnt2.Employees.Where(d => d.CompanyId == companyId)
                                                      .Select(g => new { FirstName = g.EmpFirst, LastName = g.EmpLast, EmpId = g.EmployeeId }).ToList();

                // create tuple list of employee full names paired with Id
                foreach (var emp in listOfEmployees)
                {
                    string first = (emp.FirstName).Trim();
                    string last = (emp.LastName).Trim();
                    string fullName = $"{first} {last}";
                    var IdentityTuple = new Tuple<int, string>(emp.EmpId, fullName);

                    employeeTupleList.Add(IdentityTuple);
                }
                // create list of full names to display in employee combobox
                List<string> employeeDisplayList = new List<string>();
                foreach (var employee in employeeTupleList)
                {
                    employeeDisplayList.Add(employee.Item2);
                }
                cmbEditEmployeeSelect.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEditEmployeeSelect.DataSource = employeeDisplayList;

            }
            string employeeSelection = (cmbEditEmployeeSelect.SelectedItem).ToString();

            foreach (var tupe in employeeTupleList)
            {
                if (tupe.Item2 == employeeSelection)
                {
                    int empId = tupe.Item1;
                    using (var dbEnt = new CMTEntities1())
                    {
                        Employee employeeData = dbEnt.Employees.Where(c => c.EmployeeId == empId)
                                                   .Select(i => i).FirstOrDefault();
                        txtEditFirstName.Text = employeeData.EmpFirst;
                        txtEditLastName.Text = employeeData.EmpLast;
                        txtEditSalary.Text = (employeeData.EmpSalary).ToString();
                        txtEmpId.Text = (employeeData.EmployeeId).ToString();
                    }
                }
            }

        }

       
//***********************************Auto Populates Employee Details Lots of Repeat Code**************************************************************************//
        private void cmbEditEmployeeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            // Select company from combobox
            //String conversion of combo company selection
            string companySelection = (cmbEditCompanySelect.SelectedItem).ToString();
            int companyId = 0;
            //Match combo selection company name to company name in object then store associated company Id.
            using (var dbEnt = new CMTEntities1())
            {
                companyId = dbEnt.Companies.Where(c => c.CompanyName == companySelection)
                                           .Select(i => i.CompanyId).FirstOrDefault();
            }

            //Generate list of employees for selected company.
            var employeeTupleList = new List<Tuple<int, string>>();
            using (var dbEnt2 = new CMTEntities1())
            {
                dbEnt2.Configuration.LazyLoadingEnabled = false;
                var listOfEmployees = dbEnt2.Employees.Where(d => d.CompanyId == companyId)
                                                      .Select(g => new { FirstName = g.EmpFirst, LastName = g.EmpLast, EmpId = g.EmployeeId }).ToList();

                // create tuple list of employee full names paired with Id
                foreach (var emp in listOfEmployees)
                {
                    string first = (emp.FirstName).Trim();
                    string last = (emp.LastName).Trim();
                    string fullName = $"{first} {last}";
                    var IdentityTuple = new Tuple<int, string>(emp.EmpId, fullName);

                    employeeTupleList.Add(IdentityTuple);
                }
                // create list of full names to display in employee combobox
                List<string> employeeDisplayList = new List<string>();
                foreach (var employee in employeeTupleList)
                {
                    employeeDisplayList.Add(employee.Item2);
                }

                foreach (var tupe in employeeTupleList)
                {
                    if (tupe.Item2 == cmbEditEmployeeSelect.Text)
                    {
                        int empId = tupe.Item1;
                        using (var dbEnt = new CMTEntities1())
                        {
                            Employee employeeData = dbEnt.Employees.Where(c => c.EmployeeId == empId)
                                                       .Select(i => i).FirstOrDefault();
                            txtEditFirstName.Text = employeeData.EmpFirst;
                            txtEditLastName.Text = employeeData.EmpLast;
                            txtEditSalary.Text = (employeeData.EmpSalary).ToString();
                            txtEmpId.Text = (employeeData.EmployeeId).ToString();
                        }
                    }
                }
            }
        }
//**************************************************************************************************************************************************************//
        private void btnEditEmployeeSave_Click(object sender, EventArgs e)
        {

        }

        private void txtEditFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
