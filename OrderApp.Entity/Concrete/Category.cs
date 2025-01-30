using System.Collections.Generic;

namespace OrderApp.Entity.Concrete
{
    public class Category : BaseModel
    {
        public List<Menu> Menus { get; set; }
        public string Name { get; set; }
    }
}
