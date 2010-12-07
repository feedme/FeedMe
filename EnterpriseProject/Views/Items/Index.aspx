<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Items/Items.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Item>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#items_link").addClass("selected");
        });
	</script>
    <h2>Index</h2>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th>Actions</th>
            <th>
                Name
            </th>
            <th>
                Description
            </th>
            <th>
                Price
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.ItemId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.ItemId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.ItemId })%>
            </td>
            <td>
                <%: item.Name %>
            </td>
            <td>
                <%: item.Description %>
            </td>
            <td>
                <%: String.Format("{0:F}", item.Price) %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

