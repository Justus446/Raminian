using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaminianAPI.Models
{
    public class ProdInfo
    {
        [Key]
        public int ProductID { get; set; }
        public string? SKU { get; set; }

        public string Description { get; set; }
        public int WareID { get; set; }
        public string Warehouse { get; set; }
        public string? Location { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? InStock{ get; set; }

    }
}
