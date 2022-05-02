using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementTools.CompanyForms
{
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }


        private void btnAddComp_Click(object sender, EventArgs e)
        {
            using (var dbEnt = new CMTEntities1())
            {
                Company cmp = new Company();
                cmp.CompanyName = txtAddCompName.Text;
                cmp.CompanyService = txtAddCompService.Text;
                cmp.CompanyAddressNumber = Int32.Parse(txtAddCompAddressNum.Text);
                cmp.CompanyStreetName = txtAddStreetName.Text;
                cmp.CompanyState = txtAddState.Text;
                cmp.CompanyZip = Int32.Parse(txtAddZip.Text);
                cmp.CompanySuite = txtAddSuite.Text;
                bool result = SaveCompany(cmp);
            };
            this.Close();
        }
        public bool SaveCompany(Company cmp)
        {
            bool result = false;
            using (CMTEntities1 _entity = new CMTEntities1())
            {
                _entity.Companies.Add(cmp);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void txtCancelAddComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
