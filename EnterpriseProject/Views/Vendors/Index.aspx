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
    <h1>Choose a Vendor</h1>

    <div align="center">
    <table class="output_table" cellspacing="0">
        <tr>
            <th>Actions</th>
            <th>
                Vendor Name
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                 <% using (Html.BeginForm("List", "Menus", new { id=item.VendorId}))
                                   { %>
				    <input type="submit" value="View Menus" />
				<% } %>
            </td>
            <td>
                <%: item.aspnet_Users.UserName %>
            </td>
        </tr>
    
    <% } %>

    </table>
    </div>

</asp:Content>

