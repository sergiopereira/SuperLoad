<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ShoppingCart>" %>
Total: <span class="totalPrice"><%= Model.Total.ToString("C") %></span>  

<% if(Model.FreeShipping) { %>
	<div class="specialOffer">Eligible for free shipping!</div>  
<% } %>
