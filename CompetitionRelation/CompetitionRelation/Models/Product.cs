using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionRelation.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(40)]
        public string ProductName { get; set; }
        [Required, MaxLength(20)]
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
