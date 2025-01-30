using System.Collections.Generic;

namespace OrderApp.Entity.Concrete
{
    public class Menu : BaseModel
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
