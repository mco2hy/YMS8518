using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Models
{
    public class CustomerCustomerDemo
    {
        [MaxLength(5)]
        public int Id { get; set; }
        [MaxLength(10)]
        public string CustomerDemographicID { get; set; }
        public CustomerDemographic CustomerDemographic { get; set; }
    }
}
