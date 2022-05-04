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
    public partial class DeleteEmployeeForm : Form
    {
        public DeleteEmployeeForm()
        {
            InitializeComponent();
            LoadComboBox();
            txtEmpDeleteId.Visible = false;
        }

        private void LoadComboBox()
        {
            using (var db = new CMTEntities2())
            {
                var CompanyQuery = db.Companies.Select(c => c).OrderBy(n => n.CompanyName);
                foreach (Company company in CompanyQuery)
                {
                    cmbSelectEmpDeleteComp.Items.Add(company.CompanyName);
                }


            }
        }

        private void cmbSelectEmpDeleteComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select company from combobox
            //String conversion of combo company selection
            string companySelection = (cmbSelectEmpDeleteComp.SelectedItem).ToString();
            int companyId = 0;
            //Match combo selection company name to company name in object then store associated company Id.
            using (var dbEnt = new CMTEntities2())
            {
                companyId = dbEnt.Companies.Where(c => c.CompanyName == companySelection)
                                           .Select(i => i.CompanyId).FirstOrDefault();
            }

            //Generate list of employees for selected company.
            var employeeTupleList = new List<Tuple<int, string>>();
            using (var dbEnt2 = new CMTEntities2())
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
                cmbDeleteEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbDeleteEmployee.DataSource = employeeDisplayList;

            }

        }

        private void cmbDeleteEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select company from combobox
            //String conversion of combo company selection
            string companySelection = (cmbSelectEmpDeleteComp.SelectedItem).ToString();
            int companyId = 0;
            //Match combo selection company name to company name in object then store associated company Id.
            using (var dbEnt = new CMTEntities2())
            {
                companyId = dbEnt.Companies.Where(c => c.CompanyName == companySelection)
                                           .Select(i => i.CompanyId).FirstOrDefault();
            }

            //Generate list of employees for selected company.
            var employeeTupleList = new List<Tuple<int, string>>();
            using (var dbEnt2 = new CMTEntities2())
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
                    if (tupe.Item2 == cmbDeleteEmployee.Text)
                    {
                        int empId = tupe.Item1;
                        using (var dbEnt = new CMTEntities2())
                        {
                            Employee employeeData = dbEnt.Employees.Where(c => c.EmployeeId == empId)
                                                       .Select(i => i).FirstOrDefault();
                            txtEmpDeleteId.Text = (employeeData.EmployeeId).ToString();
                        }
                    }
                }
            }

        }

        private void btnCancelDeleteEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string selection = (cmbDeleteEmployee.SelectedItem).ToString();
            Employee emp = new Employee();
            using (var dbEnt = new CMTEntities2())
            {
                emp.EmployeeId = Int32.Parse(txtEmpDeleteId.Text);

                bool result = DeleteEmployeeDetails(emp);
                this.Close();

            }
        }
        public bool DeleteEmployeeDetails(Employee Emp)
        {
            bool result = false;
            using (CMTEntities2 _entity = new CMTEntities2())
            {
                Employee _employee = _entity.Employees.Where(x => x.EmployeeId == Emp.EmployeeId )
                                                    .Select(x => x).FirstOrDefault();
                _entity.Employees.Remove(_employee);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
