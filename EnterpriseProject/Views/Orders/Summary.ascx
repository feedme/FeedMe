<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

Total Items: <%: ViewData["size"] %>
Sub-Total: <%: ViewData["subtotal"] %>
<br />
Submitted Orders: <%: ViewData["submitted_size"] %>