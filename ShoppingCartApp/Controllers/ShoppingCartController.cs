using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartApp.ServiceReference1;
using ShoppingCartApp.Classes;

namespace ShoppingCartApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        Service1Client wcf = new Service1Client(); // Connection to WCF
        
        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View("ShoppingCart");
        }

        private int CheckIfExisting(int id) // Checks session for existing products, increases quantity if product exists
        {
            List<CartItem> shoppingCart = (List<CartItem>)Session["shoppingCart"];
            for (int x = 0; x < shoppingCart.Count; x++)
                if (shoppingCart[x].Product.ProductID == id)
                    return x;
            return -1;
        }

        public ActionResult RemoveFromCart(int id) // Removes cart item from session
        {
            List<CartItem> shoppingCart = new List<CartItem>();
            shoppingCart.Remove(new CartItem(wcf.GetProduct(id), 1));
            Session["shoppingCart"] = shoppingCart;
            return View("ShoppingCart");
        }


        public ActionResult AddToCart(int id) // Creates new session if one is not existing, adds item to cart, uses checkifexisting method to increase quantity
        {

            if(Session["shoppingCart"] == null)
            {
                List<CartItem> shoppingCart = new List<CartItem>();
                shoppingCart.Add(new CartItem(wcf.GetProduct(id), 1));
                Session["shoppingCart"] = shoppingCart;
            } else

            {
                List<CartItem> shoppingCart = (List <CartItem>)Session["shoppingCart"];
                int index = CheckIfExisting(id);
                if (index == -1)
                    shoppingCart.Add(new CartItem(wcf.GetProduct(id), 1));
                else
                    shoppingCart[index].Quantity++;
                Session["shoppingCart"] = shoppingCart;
            }
            return View("ShoppingCart");
        }

        public ActionResult Checkout()
        {
            OrderDetail orderDetail = wcf.GetOrderDetail();
            return View();
        }
    }
}