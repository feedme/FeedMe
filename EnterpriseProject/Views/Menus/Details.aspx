<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Menus/Menus.Master" Inherits="System.Web.Mvc.ViewPage<EnterpriseProject.Models.Menu>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">MenuId</div>
        <div class="display-field"><%: Model.MenuId %></div>
        
        <div class="display-label">VendorId</div>
        <div class="display-field"><%: Model.VendorId %></div>
        
        <div class="display-label">Description</div>
        <div class="display-field"><%: Model.Description %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.MenuId }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

