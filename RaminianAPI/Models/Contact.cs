using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaminianAPI.Models
{
    public partial class Contact
    {
        public int ID { get; set; }
        public int CustID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Cell1 { get; set; }
        public string Cell2 { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Zip { get; set; }
        public string Notes { get; set; }
        public DateTime? LastContacted { get; set; }
        public byte[] Picture { get; set; }
        public DateTime? Birthday { get; set; }
        public string OutlookID { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string PIN { get; set; }
    }
}
