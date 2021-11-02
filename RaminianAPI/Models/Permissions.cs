using System;
using System.Collections.Generic;

namespace RaminianAPI.Models
{
    public class Permissions
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public string ControlName { get; set; }
        public string ControlValue { get; set; }
        public int? OrderNo { get; set; }
        public string Type { get; set; }
        public bool? AllowAccess { get; set; }
        public bool? AllowAdd { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? AllowDelete { get; set; }
        public bool? AllowPrint { get; set; }
    }

}
