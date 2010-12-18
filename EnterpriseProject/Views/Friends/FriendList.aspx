<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.aspnet_Users>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	FriendList
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>FriendList</h2>

    <table>
        <tr>
            <th></th>
            <th>
                ApplicationId
            </th>
            <th>
                UserId
            </th>
            <th>
                UserName
            </th>
            <th>
                LoweredUserName
            </th>
            <th>
                MobileAlias
            </th>
            <th>
                IsAnonymous
            </th>
            <th>
                LastActivityDate
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.UserId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.UserId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.UserId })%>
            </td>
            <td>
                <%: item.ApplicationId %>
            </td>
            <td>
                <%: item.UserId %>
            </td>
            <td>
                <%: item.UserName %>
            </td>
            <td>
                <%: item.LoweredUserName %>
            </td>
            <td>
                <%: item.MobileAlias %>
            </td>
            <td>
                <%: item.IsAnonymous %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.LastActivityDate) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

