using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductOrder.Models
{
    public class CustomerCustomerDemo
    {
        [Key, MaxLength(5)]
        public int CustomerId { get; set; }
        [Key, MaxLength(10)]
        public string CustomerTypeId { get; set; }

        [ForeignKey("CustomerTypeId")]
        public CustomerDemographic CustomerDemographic { get; set; }
    }
}
