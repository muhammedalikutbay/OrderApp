using System.Data.Entity;
using OrderApp.Entity.Concrete;

namespace OrderApp.DataAccessLayer.Context
{
    public class Context
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
