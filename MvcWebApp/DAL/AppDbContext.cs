using MvcWebApp.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebApp.DAL {
    public class AppDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
    }
}