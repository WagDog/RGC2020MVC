using RGC2020MVC.Model;
using System.Data.Entity;


namespace RGC2020MVC.DAL.Data
{
    // You can pass the NAME of a connection string (e.g from a web.config), and explicitly declare
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")    // Class constructor
        {            
        }

        // Any entity to be persisted must be declared here
        public DbSet<Account> Accounts { get; set; }
    }


}
