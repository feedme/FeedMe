<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Friends/Friends.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Friends
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#list_friends_link").addClass("selected");
        });
	</script>

    <h2 style="text-align:center">Showing all users</h2>
    <% foreach (var item in Model) { %>
        <div id="friendlist">
            <div id="profile_photo">
                <h7 style="color:#999">Profile flick</h7>
            </div>
            <div style="float:left;padding-left:10px;">
                <h7 style="color:#999;text-align:center">Bio and all that jazz</h7>
            </div>
            <div style="float:right">
                <h7 style="color:#999;"><%: item.UserName %></h7>
                <br /><br />
                <%: Html.ActionLink("Add as friend - TODO", "", "", null) %>
            </div>
        </div>
    <% } %>

</asp:Content>
