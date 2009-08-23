<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CartItem>" %>
		<li>
			<img src="../../Content/images/prod_<%= Model.Product.Id %>.jpg" class="product-image">
			<div class="prodSummary">
				<div class="prodTitle"><%= Model.Product.Name %></div>
				<div class="prodPrice"><%= Model.Product.Price.ToString("C") %></div>
			</div>
		</li>

