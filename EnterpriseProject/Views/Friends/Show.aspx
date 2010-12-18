<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Friends/Friends.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Your Friends
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% foreach (var item in Model) { %>
        <div id="friendlist">
            <div>
                <h6 style="float:left;color:#999;"><%: item.UserName %></h6>
            </div>
        </div>
    <% } %>

 
</asp:Content>

