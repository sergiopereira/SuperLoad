<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IList<Product>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Let's Shop
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="cartSummary">
		Your shopping cart
		<div id="cartTotal">
		<% Html.RenderAction<ShoppingController>(c => c.CartTotal(null)); %>
		</div>
    </div>

    <h2>Here are our products</h2>
    <p>
		Choose from the catalog and add them to your shopping cart.
    </p>
    <hr />
    
    <div id="rightColumn">
		Items in your cart:
		<ul id="cart">
			<li id="empty">(empty)</li>
		</ul>
    </div>
    <div id="products">
		<% foreach (var product in Model) { %>
		<div id="product_<%= product.Id %>" class="product">
			<img src="../../Content/images/prod_<%= product.Id %>.jpg" align="left" />
			<div class="title"><%= product.Name %></div>
			<div class="prodPrice" ><%= product.Price.ToString("C") %></div>
			Qty: <input type="text" size="2"  maxlength="3" class="quantity" value="1"/>
			<input type="button" value="Add to cart" class="addButton" />
		</div>
		<%	} %>
		
    </div>
    <script>
    	$(document).ready(function() {

    		$('.addButton').click(function() {
    			var prod = $(this).parent('.product');
    			var prodId = prod.attr('id').split('_')[1];
    			var qty = prod.find('.quantity').val();

    			$.superLoad({
    				url: '<%= Url.Action("AddItem") %>',
    				type: 'POST',
    				data: { product: prodId, quantity: qty },
    				success: function() { $('#empty').remove(); }
    			});
    			
    		});
    		
    		
    	});
    </script>

</asp:Content>
