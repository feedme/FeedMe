<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Menus/Menus.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.MenuItem>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Show
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Show Menu <%=ViewData["menutitle"] %> Items</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th>Add to Order</th>
            <th>
                Item Name
            </th>
            <th>
                Item Description
            </th>
            <th>
                Menu Name
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <% using (Html.BeginForm("AddItemToOrder", "Orders", new {  itemId = item.ItemId,menuId=item.MenuId }))
                                   { %>
                    <input type="text" id="quantity" name="quantity" />
				    <input type="submit" value="Add Item" />
				<% } %>
            </td>
            <td>
                <%: item.Item.Name %>
            </td>
             <td>
                <%: item.Item.Description %>
            </td>
            <td>
                <%: item.Menu.Description %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>


</asp:Content>

