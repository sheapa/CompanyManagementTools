using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CompanyManagementTools.CompanyForms
{
    public partial class UpdateCompanyForm : Form
    {
        public UpdateCompanyForm()
        {
            InitializeComponent();
            LoadComboBox();
        }

        // load list of companies for combobox
        private void LoadComboBox()
        {
            using (var db = new CMTEntities2())
            {
                var CompanyQuery = db.Companies.Select(c => c).OrderBy(n => n.CompanyName);
                foreach (Company company in CompanyQuery)
                {
                    cmbEditCompanySelect.Items.Add(company.CompanyName);
                }


            }
        }

        // Auto-Populate text fieldw with existing data.
        private void cmbEditCompanySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = (cmbEditCompanySelect.SelectedItem).ToString();
            
            using (var dbEnt = new CMTEntities2())
            {
                var companyData = dbEnt.Companies.Where(c => c.CompanyName == selection).Select(d => d).ToList();

                foreach (var company in companyData)
                {
                    txtAddCompName.Text = company.CompanyName;
                    txtAddCompService.Text = company.CompanyService;
                    txtAddCompAddressNum.Text = (company.CompanyAddressNumber).ToString();
                    txtAddStreetName.Text = company.CompanyStreetName;
                    txtAddState.Text = company.CompanyState;
                    txtAddZip.Text = (company.CompanyZip).ToString();
                    txtAddSuite.Text = company.CompanySuite;
                }
                
            }

        }
        
        private void btnAddComp_Click(object sender, EventArgs e)
        {

            // select Id of company to update
            string selection = (cmbEditCompanySelect.SelectedItem).ToString();
            int companyId = 0;

            using (var dbEnt = new CMTEntities2())
            {
                var companySelect = from c in dbEnt.Companies
                                            where c.CompanyName == selection
                                            select c.CompanyId;
                companyId = companySelect.FirstOrDefault();

                
            }
            // Aling text values with update fields.
            Company cmp = new Company();
            cmp.CompanyName = txtAddCompName.Text;
            cmp.CompanyService = txtAddCompService.Text;
            cmp.CompanyAddressNumber = Int32.Parse(txtAddCompAddressNum.Text);
            cmp.CompanyStreetName = txtAddStreetName.Text;
            cmp.CompanyState = txtAddState.Text;
            cmp.CompanyZip = Int32.Parse(txtAddZip.Text);
            cmp.CompanySuite = txtAddSuite.Text;
            cmp.CompanyId = companyId;
            bool result = UpdateCompanyDetails(cmp);
            this.Close();

        }
        public bool UpdateCompanyDetails(Company cmp) // Update Company Details method for update a existing Record  
        {
            bool result = false;
            using (CMTEntities2 _entity = new CMTEntities2())
            {
                Company _comp = _entity.Companies.Where(x => x.CompanyId == cmp.CompanyId)
                                                 .Select(x => x).FirstOrDefault();
                _comp.CompanyName = cmp.CompanyName;
                _comp.CompanyService = cmp.CompanyService;
                _comp.CompanyAddressNumber = cmp.CompanyAddressNumber;
                _comp.CompanyStreetName = cmp.CompanyStreetName;
                _comp.CompanyState = cmp.CompanyState;
                _comp.CompanyZip = cmp.CompanyZip;
                _comp.CompanySuite = cmp.CompanySuite;

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
