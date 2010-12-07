<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Menus/Menus.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Item>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AddItems
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add Items to <%= ViewData["menutitle"] %></h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th></th>
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
                <% using (Html.BeginForm("AddItems", "Menus", new { menuId = (Guid)ViewData["menuid"], itemId = item.ItemId }))
                                   { %>
				    <input type="submit" value="Add Item" />
				<% } %>
          
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

</asp:Content>

