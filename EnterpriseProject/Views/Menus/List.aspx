<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Menus/Menus.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Menu>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>List <%= ViewData["vendorname"] %>'s Menus</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th>Actions</th>
            <th>
                Description
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Show Menu", "Show", new { id=item.MenuId })%>
            </td>
            <td>
                <%: item.Description %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>

</asp:Content>

