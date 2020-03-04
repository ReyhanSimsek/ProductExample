using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.Entity;

namespace EMutfakWebApi.Models
{
    public class EMutfakContext : DbContext
    {
        public EMutfakContext() : base("name = emutfakconnection")
        {

        }
        public DbSet<Products> Product { get; set; }
    }


}
