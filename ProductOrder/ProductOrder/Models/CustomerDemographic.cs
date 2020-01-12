namespace ProductOrder.Models
{
    public class CustomerDemographic
    {
        public int Id { get; set; }
        public string CustomerDesc { get; set; }

        public CustomerCustomerDemo CustomerCustomerDemo { get; set; }
    }
}
