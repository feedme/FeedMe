<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Vendors/Vendors.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.OrderItem>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	OrderDetails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#orders_link").addClass("selected");
        $("#menus_section").removeClass("selected");
        $("#orders_section").addClass("selected");
    });
</script>
    <h1>OrderDetails for <%: ViewData["user"] %></h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th></th>
            <th>
                Item Name
            </th>
            <th>
                Quantity
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.OrderItemId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.OrderItemId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.OrderItemId })%>
            </td>
            <td>
                <%: item.Item.Name %>
            </td>
            <td>
                <%: item.Quantity %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>

</asp:Content>

