using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace HTML5WebApp1.DB
{
    public class ProductSvc : IProductService
    {
        DataContext _ctx;

        public ProductSvc()
        {
            _ctx = new DataContext(ConfigurationManager.ConnectionStrings["NorthConnection"].ConnectionString);
        }
        public Product GetProductInfo(string ProductID)
        {
            return _ctx.GetTable<Product>().FirstOrDefault(x => x.ProductID == Convert.ToInt32(ProductID));
        }
    }
}