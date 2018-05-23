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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DigitalXDBEntities _db = new DigitalXDBEntities();
        

        //Fetches popular products 
        public List<Product> GetTopProducts()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            var query = (from p in _db.Products
                         orderby p.Price
                         select p).Take(5);

            return query.ToList();
        }

        //Fetches all DVD  using subcategory product id
        public List<Product> GetDvds()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var query = (from p in _db.Products
                         where list.Contains(p.SubCategoryID)
                         select p);

            BasicHttpBinding httpBinding = new BasicHttpBinding();
            httpBinding.MaxReceivedMessageSize = Int32.MaxValue;
            httpBinding.MaxBufferSize = Int32.MaxValue;

            return query.ToList();

        }

        //Fetches all components  using subcategory product id
        public List<Product> GetComponents()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            IEnumerable<int> list = new List<int>() { 25, 31, 29, 30 };
            List<Product> query = (from p in _db.Products
                                   where list.Contains(p.SubCategoryID)
                                   select p).ToList();
            return query;

        }

        //Fetches all Consoles using product id
        public List<Product> GetConsoles()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            IEnumerable<int> list = new List<int>() { 21, 23 };
            List<Product> query = (from p in _db.Products
                                   where list.Contains(p.SubCategoryID)
                                   select p).ToList();
            return query;

        }

        //Fetches all games  using subcategory product id
        public List<Product> GetGames()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            IEnumerable<int> list = new List<int>() { 9, 10, 11, 12, 14, 15 };
            List<Product> query = (from p in _db.Products
                                   where list.Contains(p.SubCategoryID)
                                   select p).ToList();
            return query;

        }

        //Fetches all handbooks  using subcategory product id
        public List<Product> GetHandbooks()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            IEnumerable<int> list = new List<int>() { 27, 28 };
            List<Product> query = (from p in _db.Products
                                   where list.Contains(p.SubCategoryID)
                                   select p).ToList();
            return query;

        }

        //Fetches all pc parts  using subcategory product id
        public List<Product> GetPcParts()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            IEnumerable<int> list = new List<int>() { 26 };
            List<Product> query = (from p in _db.Products
                                   where list.Contains(p.SubCategoryID)
                                   select p).ToList();
            return query;

        }

        //Fetches product using product id
        public Product GetProduct(int id)
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            var query = (from p in _db.Products
                         where id == p.ProductID
                         select p);
            return query.SingleOrDefault();
        }

        public OrderDetail GetOrderDetail()
        {
            _db.Configuration.ProxyCreationEnabled = false; //Disables Lazy Loading
            var query = (from p in _db.OrderDetails
                         select p).SingleOrDefault();
            return query;
        }
      
    }
}
