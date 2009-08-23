using System.Collections.Generic;
using System.Web.Mvc;
using JQuerySuperLoad;
using SuperLoadSampleMvc.Model;

namespace SuperLoadSampleMvc.Controllers
{
    public class ShoppingController : Controller
    {
        //
        // GET: /Shopping/

		public ActionResult Index()
		{
			var products = new List<Product>();
			for(int i=1; i<= 10; i++)
			{
				products.Add(GetProduct(i));
			}

			return View(products);
		}

		[AcceptVerbs(HttpVerbs.Post)]
    	public ActionResult AddItem(int product, int quantity)
        {
        	var sku = GetProduct(product);
			var item = new CartItem(sku, quantity);
        	var cart = GetCurrentCart();
			cart.Items.Add(item);

			//add all the separate action results that we want into 
			// a SuperLoad result, mapping each one to the right selector and update type.
        	return new SuperLoadResult(
        		new SuperLoadAjaxContent("#cartTotal", SuperLoadCommand.Update, () => CartTotal(cart)),
        		new SuperLoadAjaxContent("#cart", SuperLoadCommand.Append, () => CartItem(item))
				/* 
				 you can also try other types of updates, like
				 SuperLoadCommand.Prepend OR SuperLoadCommand.Custom("replaceWith")
				 */
        		);
        }


    	public ActionResult CartItem(CartItem item)
        {
        	return PartialView("CartItem", item);
        }

		public ActionResult CartTotal(ShoppingCart cart)
        {
			if(cart == null) 
				cart = new ShoppingCart();

			return PartialView("CartTotal", cart);
        }

    	private ShoppingCart GetCurrentCart()
    	{
    		var cart = (ShoppingCart)Session["cart"];
			if(cart == null)
			{
				Session["cart"] = cart = new ShoppingCart();
			}
    		return cart;
    	}

    	private Product GetProduct(int productId)
    	{
    		//dummy method.. should go to the database
    		return new Product {Id = productId, Name = "Product " + productId, Price = 1.11m*productId};
    	}

    }
}
