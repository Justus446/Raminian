using System;
using System.Collections.Generic;

namespace RaminianAPI.Models
{
    public partial class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }
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
        public string CatName { get; set; }
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
        public double ChequeBalance { get; set; }
        public double AccountBalance { get; set; }
        public int Points { get; set; }
    }
}
