using System.Collections.Generic;

namespace OrderApp.Entity.Concrete
{
    internal class Category : BaseModel
    {
        public List<Menu> Menus { get; set; }
        public string Name { get; set; }
    }
}
