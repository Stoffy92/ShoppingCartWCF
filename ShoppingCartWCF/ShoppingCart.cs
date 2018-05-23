using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartWCF
{
    public class ShoppingCart // A place to store products
    {
        private List<WishListItem> CartItems { get; set; }

        public ShoppingCart()
        {
            CartItems = new List<WishListItem>();
        }

        private int CartItemIndex(int id)
        {
            foreach(WishListItem cartItem in CartItems)
            {
                if(cartItem.WishListID == id)
                {
                    return CartItems.IndexOf(cartItem);
                }
            }
            return -1;
        }

        public void Insert(WishListItem cartItem)
        {

        }
    }
}