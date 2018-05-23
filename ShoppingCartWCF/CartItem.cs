using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCartWCF;


namespace ShoppingCartApp.Controllers
{
    public class CartItem
    {
        private Product product = new Product();

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        
        public CartItem(Product product, int quantity)
        {
            this.product = product;
            this.Quantity = quantity;
        }
    }
}