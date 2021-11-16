using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaminianAPI.Models
{
    public partial class Customer
    {
        [Key]
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string CustAddr { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string Town { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string VATNO { get; set; }
        public string PIN { get; set; }
        public string NOTES { get; set; }
        public int CatID { get; set; }
        //public string CatName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CreditLimit { get; set; }
        public int? SalesRep { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Location { get; set; }
        public int? Terms { get; set; }
        public string SendUpdates { get; set; }
        public bool Active { get; set; }
        public int Rating { get; set; }
        public string Account { get; set; }
        //public double ChequeBalance { get; set; }
        //public double AccountBalance { get; set; }
        //public int Points { get; set; }
    }
}
