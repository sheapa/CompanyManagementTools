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
    public partial class DeleteCompanyForm : Form
    {
        public DeleteCompanyForm()
        {
            InitializeComponent();
            LoadComboBox();
        }
        // load combo box with list of companies
        private void LoadComboBox()
        {
            using (var db = new CMTEntities2())
            {
                var CompanyQuery = db.Companies.Select(c => c).OrderBy(n => n.CompanyName);
                foreach (Company company in CompanyQuery)
                {
                    cmbDeleteComp.Items.Add(company.CompanyName);
                }


            }
        }
        //select company to delete
        private void cmbDeleteComp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        // Deltet Company details from table
        public bool DeleteCompanyDetails(Company cmp)  
        {
            bool result = false;
            using (CMTEntities2 _entity = new CMTEntities2())
            {
                Company _company = _entity.Companies.Where(x => x.CompanyId == cmp.CompanyId).Select(x => x).FirstOrDefault();
                _entity.Companies.Remove(_company);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnCancelDeleteComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteComp_Click(object sender, EventArgs e)
        {
            string selection = (cmbDeleteComp.SelectedItem).ToString();
            Company cmp = new Company();
            using (var dbEnt = new CMTEntities2())
            {
                var companyData = dbEnt.Companies.Where(c => c.CompanyName == selection)
                                                 .Select(d => d).ToList();

                foreach (var comp in companyData)
                {
                    cmp.CompanyName = comp.CompanyName;
                    cmp.CompanyService = comp.CompanyService;
                    cmp.CompanyAddressNumber = comp.CompanyAddressNumber;
                    cmp.CompanyStreetName = comp.CompanyStreetName;
                    cmp.CompanyState = comp.CompanyState;
                    cmp.CompanyZip = comp.CompanyZip;
                    cmp.CompanySuite = comp.CompanySuite;
                    cmp.CompanyId = comp.CompanyId;
                }

                bool result = DeleteCompanyDetails(cmp);
                this.Close();

            }
        }
    }
}
