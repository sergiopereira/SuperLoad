namespace SuperLoadSampleMvc.Model
{
	public class CartItem
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }

		public CartItem(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
	}
}