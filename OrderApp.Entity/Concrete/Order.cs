namespace OrderApp.Entity.Concrete
{
    internal class Order : BaseModel
    {
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
