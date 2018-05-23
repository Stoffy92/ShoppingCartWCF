using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

namespace ShoppingCartWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Methods used 

        [OperationContract]
        List<Product> GetDvds(); 

        [OperationContract]
        List<Product> GetTopProducts();

        [OperationContract]
        List<Product> GetComponents();

        [OperationContract]
        List<Product> GetGames();

        [OperationContract]
        List<Product> GetHandbooks();

        [OperationContract]
        List<Product> GetPcParts();

        [OperationContract]
        List<Product> GetConsoles();

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        OrderDetail GetOrderDetail();

    }


   
}
