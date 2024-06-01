using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS;Initial Catalog=EasyCashDb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; } //CustomerAccount c# tarafındaki sınıf ismi,CustomerAccounts ise sql tarafındaki tablo ismi
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

    }

    //migration oluşturma  Package Manager Console-clear->add -migration mig1   (default project dataaccess) 
    //update-database ile sql de tablolar oluşur 
}
