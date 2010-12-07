<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Orders/Orders.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Order>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#orders_link").addClass("selected");
    });
</script>
    <h1>Your Orders</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th></th>
            <th>
                Vendor
            </th>
            <th>
                Status
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td> 
                <%: Html.ActionLink("Details", "Details", new { id=item.OrderId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.OrderId })%>
            </td>
            <td>
                <%: item.Vendor.aspnet_Users.UserName %>
            </td>
            <td>
                <%: item.Status %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

