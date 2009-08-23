using System.Collections.Generic;
using System.Linq;

namespace SuperLoadSampleMvc.Model
{
	public class ShoppingCart
	{
		public ShoppingCart()
		{
			Items = new List<CartItem>();
		}

		public bool FreeShipping { get { return Total > 50; } }

		public IList<CartItem> Items { get; private set; }
		public decimal Total
		{
			get { return Items.Sum(item => item.Product.Price*item.Quantity); }
		}
	}
}