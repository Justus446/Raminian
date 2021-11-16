using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaminianAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace RaminianAPI
{
    public class ApiDBContext:DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options)
            : base(options)
        {

        }
       

        public DbSet<eComm_non_eComm> Ecommerce { get; set; }


        public DbSet<RaminianAPI.Models.Contact> Contacts { get; set; }
       

        public DbSet<RaminianAPI.Models.Customer> Customer { get; set; }
       

        public DbSet<RaminianAPI.Models.Order> Order { get; set; }
       

        public DbSet<RaminianAPI.Models.Permissions> Permissions { get; set; }
       

        public DbSet<RaminianAPI.Models.User> Users { get; set; }
       

        public DbSet<RaminianAPI.Models.Warehouses> Warehouses { get; set; }
       

        public DbSet<RaminianAPI.Models.ProductPhoto> ProductPhoto { get; set; }

        public DbSet<ProdInfo> ProdInfo { get; set; }

    }
}
