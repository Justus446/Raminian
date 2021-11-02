using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaminianAPI.Models
{
    public class Order
    {
        [Key]
        public int NameID { get; set; }
        public string Location { get; set; }
        public List<eComm_non_eComm> Products { get; set; }
        public bool IsSale{ get; set; }

    }
}
