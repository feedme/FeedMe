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

    <h2 style="text-align:center">Showing all users (non-friends)</h2>
    <% foreach (var item in Model) { %>
        <div id="friendlist">
            <div style="float:left;width:50%">
                <h6 style="color:#999;"><%: item.UserName %></h6>
            </div>
            <div style="float:right;width:50%">
                <h6>
                    <%: Html.ActionLink("Add as friend", "Add", "Friends", new { UserId = item.ProviderUserKey}, null)%>
                </h6>
            </div>
        </div>
    <% } %>

</asp:Content>
