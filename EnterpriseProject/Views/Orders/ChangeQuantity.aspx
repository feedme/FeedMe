<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Orders/Orders.Master" Inherits="System.Web.Mvc.ViewPage<EnterpriseProject.Models.OrderItem>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Quantity) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Quantity) %>
                <%: Html.ValidationMessageFor(model => model.Quantity) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

