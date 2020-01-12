using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductOrder.Models
{
    public class CustomerDemographic
    {
        [Key]
        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
        
        public CustomerCustomerDemo CustomerCustomerDemo { get; set; }
    }
}
