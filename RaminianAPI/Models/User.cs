using System;
using System.Collections.Generic;

namespace RaminianAPI.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public bool Active { get; set; }
        public string Id { get; set; }
        public string Pin { get; set; }
        public byte[] Picture { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public DateTime? Birthday { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsOnline { get; set; }
        public string StationName { get; set; }
        public DateTime? PassDate { get; set; }
        public string Ipaddress { get; set; }
        public string UserName { get; set; }
        public string ProductVersion { get; set; }
    }
}
