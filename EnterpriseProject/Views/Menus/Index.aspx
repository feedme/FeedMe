<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Menus/Menus.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Menu>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#menus_link").addClass("selected");
        });
	</script>
    <h1><%=ViewData["vendorname"] %> Menus</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th>Actions</th>
            <th>
                Menu Title
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.MenuId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.MenuId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.MenuId })%> |
                <%: Html.ActionLink("Add Items", "AddItems", new { id=item.MenuId })%>
            </td>
            <td>
                <%: item.Description %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

