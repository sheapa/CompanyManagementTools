//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyManagementTools
{
    using System;
    using System.Collections.Generic;
    
    public partial class Annual_Incomes
    {
        public int IncomeId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public int IncomeYear { get; set; }
        public int YearIncome { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
