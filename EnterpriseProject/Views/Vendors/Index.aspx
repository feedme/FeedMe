<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Vendors/Vendors.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EnterpriseProject.Models.Vendor>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#vendors_link").addClass("selected");
    });
</script>
    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Vendor Name
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td></td>
            <td>
                <%: item.aspnet_Users.UserName %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

