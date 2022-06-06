using projectBorrow.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Project_ManagmentSystem.Models
{
    public class SystemModel1 : DbContext
    {
        
        public SystemModel1()
            : base("name=SystemModel1")
        {
        }

       public virtual DbSet<Users> Users { get; set; }
       public virtual DbSet<Customer> Customers { get; set; }
       public virtual DbSet<premium_long> Premium_Longs { get; set; }
       public virtual DbSet<premium_monthly> Premium_Monthlies { get; set; }
        public virtual DbSet<Payement>Payements { get; set; }

    }

    
}