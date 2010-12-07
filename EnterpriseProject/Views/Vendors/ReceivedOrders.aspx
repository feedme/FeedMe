<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Vendors/Vendors.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Order>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ReceivedOrders
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#received_orders_link").addClass("selected");
        $("#menus_section").removeClass("selected");
        $("#orders_section").addClass("selected");
    });
</script>
    <h1>ReceivedOrders</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th></th>
            <th>
                User
            </th>
            <th>
                Status
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.OrderId }) %> |
                <%: Html.ActionLink("Details", "OrderDetails", new { id=item.OrderId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.OrderId })%>
            </td>
            <td>
                <%: item.aspnet_Users.UserName %>
            </td>
            <td>
                <%: item.Status %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>


</asp:Content>

