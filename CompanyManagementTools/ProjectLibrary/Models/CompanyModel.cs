using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectLibrary.Models
{
    public class CompanyModel
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyService { get; set; }
        public int CompanyAddressNumber { get; set; }
        public string CompanyStreetName { get; set; }
        public string CompanyState { get; set; }
        public int CompanyZip { get; set; }
        public string CompanySuite { get; set; }
        //public DateTime foundation { get; set; }
    }
}
