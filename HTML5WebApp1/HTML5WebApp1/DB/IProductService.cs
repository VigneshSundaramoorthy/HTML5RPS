using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HTML5WebApp1.DB
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebGet(UriTemplate="Product/{productID}",ResponseFormat = WebMessageFormat.Json)]
        Product GetProductInfo(string ProductID);
    }
}
