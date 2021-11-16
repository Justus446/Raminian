using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RaminianAPI.Models
{
    public class eComm_non_eComm 
    {   
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        //public int ProductID { get; set; }
        public int sku { get; set; }
        
        public string description { get; set; }
        //[NotMapped] 
        //public string offername { get; set; }
        //public string Units { get; set; }

        
        [Column(TypeName ="decimal(18,2)")]
        public decimal? price { get; set; }

        //[Column(TypeName = "decimal(18,2)")]
        //public decimal? offerprice { get; set; }
        //public DateTime? OfferStart { get; set; }
        //public DateTime? OfferExpiry { get; set; }
        //public int? qty { get; set; }
        //public int? weight { get; set; }
        //public int is_in_stock { get; set; }
        //public int manage_stock { get; set; }
        //public string category { get; set; }
        //public string department { get; set; }
        //public string Breadcrumb { get; set; }
        //public string Barcode { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal? L1Price { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal? L2Price { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal? L3Price { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal? L4Price { get; set; }
        //public int? WareID { get; set; }
        ////public string ImageList { get; set; }
        ////public string B64Image { get; set; }
        //public DateTime LastMove { get; set; }
        //public DateTime ModifiedDate { get; set; }

        //public string VATCode { get; set; }
        //public double VATPercent { get; set; }
        //public string Tags { get; set; }
        //public string Location { get; set; }

//        public virtual List<ProductPhoto> ProductPhotos { get; set; }

    }
}
