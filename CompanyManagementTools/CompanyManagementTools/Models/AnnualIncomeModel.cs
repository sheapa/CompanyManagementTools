

using System.ComponentModel.DataAnnotations;

namespace CompanyManagementTools.Models
{
    public class AnnualIncomeModel
    {
        [Key]
        public int IncomeId { get; set; }
        public int CompanyId { get; set; }
        public int IncomeYear { get; set; }
        public int YearIncome { get; set; }
    }
}
