namespace ProductOrder.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double UnitPrize { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
