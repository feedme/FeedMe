<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Menus/Menus.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.MenuItem>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Details for <%=ViewData["menutitle"] %></h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th></th>
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
                <% using (Html.BeginForm("DeleteFromMenu", "Menus", new { menuid = item.Menu.MenuId, itemid = item.ItemId }))
                                   { %>
				    <input type="submit" value="Remove from Menu" />
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

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

