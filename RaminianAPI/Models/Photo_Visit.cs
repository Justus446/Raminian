using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaminianAPI.Models
{
    public class Photo_Visit
    {
        [Key]
        public int NameID { get; set; }
        public string B64Image { get; set; }
        public string Location { get; set; } //Example 57.345545,101.543534
        public int UserID { get; set; }
        public string Comment { get; set; }
    }
}
