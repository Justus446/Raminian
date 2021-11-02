using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaminianAPI.Models
{
    public class ProductPhoto
    {
       

        public int sku { get; set; }

        public int ProductID { get; set; }

        public string B64Image { get; set; }
     
        [Key]
        public Guid FileID { get; set; }

        [ForeignKey("ProductID")]
        public virtual eComm_non_eComm EComm { get; set; }

    }
}
