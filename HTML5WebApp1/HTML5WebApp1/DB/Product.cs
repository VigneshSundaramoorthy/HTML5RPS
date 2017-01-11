using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace HTML5WebApp1.DB
{
    [Table(Name = "Products")]
    public class Product
    {
        [Column]
        public int ProductID { get; set; }

        [Column]
        public string ProductName { get; set; }

        [Column]
        public decimal UnitPrice { get; set; }
    }
}