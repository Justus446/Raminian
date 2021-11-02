using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaminianAPI.Models
{
    public partial class Warehouses
    {
        [Key]
        public int WareId { get; set; }
        public string WareName { get; set; }
        public string Location { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
