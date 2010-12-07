<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Orders/Orders.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.OrderItem>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Details of your Order</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <% if (ViewData["orderstatus"].ToString() == "new")
            { %>
            <th></th>
            <% } %>
            <th>
                Vendor
            </th>
            <th>
                Item
            </th>
            <th>
                Price
            </th>
            <th>
                Quantity
            </th>
            <th>
                Item Total
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
           <% if (ViewData["orderstatus"].ToString() == "new")
           { %>
            <td>
                <%: Html.ActionLink("Change Quantity", "ChangeQuantity", new { id = item.OrderItemId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id = item.OrderItemId })%>
            </td>
            <%} %> 
            <td>
                <%: item.Item.Vendor.aspnet_Users.UserName%>
            </td>
            <td>
                <%: item.Item.Name %>
            </td>
            <td>
                <%: item.Item.Price %>
            </td>
            <td>
                <%: item.Quantity %>
            </td>
            <td>
                <%: item.Quantity * item.Item.Price %>
            </td>
        </tr>
    
    <% } %>
        <% if (ViewData["orderstatus"].ToString() == "new")
           { %>
        <tr class="sub-total">
            <th colspan="4"></th>
            <th>
                Sub-Total
            </th>
            <th>
                <%: ViewData["subtotal"]%>
            </th>
        </tr>
        <%}
           else
           { %>
        <tr class="sub-total">
            <th colspan="3"></th>
            <th>
                Sub-Total
            </th>
            <th>
                <%: ViewData["subtotal"]%>
            </th>
        </tr>
        <%} %>
    </table>
    </div>
    <br />
    <div align="right">
        <% if (ViewData["orderstatus"].ToString() == "new")
           { %>
        <% using (Html.BeginForm("PlaceOrder", "Orders", new {  Id = (Guid)ViewData["orderid"]}))
            { %>
		    <input type="submit" value="Submit Order" />
	    <% } %>
        <% } %>
    </div>
</asp:Content>

