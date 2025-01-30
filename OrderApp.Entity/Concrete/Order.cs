namespace OrderApp.Entity.Concrete
{
    public class Order : BaseModel
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
