using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementTools.ProfitLossForms
{
    public partial class AddRevenueForm : Form
    {
        public AddRevenueForm()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            using (var db = new CMTEntities2())
            {
                var CompanyQuery = db.Companies.Select(c => c).OrderBy(n => n.CompanyName);
                foreach (Company company in CompanyQuery)
                {
                    cmbCompanyRevenue.Items.Add(company.CompanyName);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRevenueYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRevenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveRevenue_Click(object sender, EventArgs e)
        {
            // select Id of company to update
            string selection = (cmbCompanyRevenue.SelectedItem).ToString();
            int companyId = 0;

            using (var dbEnt = new CMTEntities2())
            {
                var companySelect = from c in dbEnt.Companies
                                    where c.CompanyName == selection
                                    select c.CompanyId;
                companyId = companySelect.FirstOrDefault();

                Annual_Incomes rev = new Annual_Incomes();
                rev.CompanyId = companyId;
                rev.YearIncome = Int32.Parse(txtRevenueYear.Text);
                rev.IncomeYear = Int32.Parse(txtRevenue.Text);
                bool result = SaveAnnualIncome(rev);
                this.Close();

            }
        }

        public bool SaveAnnualIncome(Annual_Incomes rev) // Update Company Details method for update a existing Record  
        {
            bool result = false;
            using (CMTEntities2 _entity = new CMTEntities2())
            {
                _entity.Annual_Incomes.Add(rev);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
