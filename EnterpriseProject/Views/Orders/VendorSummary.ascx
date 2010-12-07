<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

You have: <%: ViewData["new_orders_size"] %>  New orders to receive
<br />
You have: <%: ViewData["received_orders_size"] %>  Orders to complete