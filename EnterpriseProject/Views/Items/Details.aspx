<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Items/Items.Master" Inherits="System.Web.Mvc.ViewPage<EnterpriseProject.Models.Item>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>

        <div class="display-label">Name</div>
        <div class="display-field"><%: Model.Name %></div>
        
        <div class="display-label">Description</div>
        <div class="display-field"><%: Model.Description %></div>
        
        <div class="display-label">Price</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Price) %></div>

        <%// Html.RenderPartial("ListMenus"); %>
           <table>
        <tr>
            <th>Add to Menu</th>
            <th>
                MenuId
            </th>
            <th>
                VendorId
            </th>
            <th>
                Description
            </th>
        </tr>

    <% foreach (var item in (ViewData["menus"] as List<Menu>)) { %>
    
        <tr>
            <td>
                <%//: Html.ActionLink("Add to Menu", "AddToMenu", new { ItemId=Model.ItemId,MenuId=item.MenuId }) %>
            </td>
            <td>
                <%: item.MenuId %>
            </td>
            <td>
                <%: item.VendorId %>
            </td>
            <td>
                <%: item.Description %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.ItemId }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

