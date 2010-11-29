<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Profile/Profile.Master" Inherits="System.Web.Mvc.ViewPage<EnterpriseProject.Models.ProfileCommon>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Profile
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#profile_link").addClass("selected");
        $("#profile_section").addClass("selected");
    });
</script>
    <h1>Your Profile(<%= Html.ActionLink("Edit", "Edit", "Profile")%>)</h1>

    <fieldset style="font-size:1.2em;">
        <legend>Your Profile</legend>
       
        <div align=right>
        <table width="65%">
        <tr>
        <td class="textOutputBlue">FirstName</td>
        <td class="textOutputNoh"><%: Model.FirstName %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">LastName</td>
        <td class="textOutputNoh"><%: Model.LastName %></td>       
        </tr>
        <tr>
        <td class="textOutputBlue">Preferences</td>
        <td class="textOutputNoh"><%: Model.Preferences%></td>
        </tr>
        <tr>
        <td class="textOutputBlue">Phone</td>
        <td class="textOutputNoh"><%: Model.Phone %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">Address</td>
        <td class="textOutputNoh"><%: Model.Address %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">City</td>
        <td class="textOutputNoh"><%: Model.City %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">County</td>
        <td class="textOutputNoh"><%: Model.County %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">UserName</td>
        <td class="textOutputNoh"><%: Model.UserName %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">LastActivityDate</td>
        <td class="textOutputNoh"><%: String.Format("{0:g}", Model.LastActivityDate) %></td>
        </tr>
        <tr>
        <td class="textOutputBlue">LastUpdatedDate</td>
        <td class="textOutputNoh"><%: String.Format("{0:g}", Model.LastUpdatedDate) %></td>
        </tr>
        </table>
        </div>
    </fieldset>
    


</asp:Content>

