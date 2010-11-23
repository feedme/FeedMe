<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<EnterpriseProject.Models.Menu>>" %>

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

    <% foreach (var item in Model) { %>
    
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

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>


