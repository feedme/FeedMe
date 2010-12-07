<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Profile/Profile.Master" Inherits="System.Web.Mvc.ViewPage<EnterpriseProject.Models.ProfileCommon>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            <div align=center>
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.FirstName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.FirstName) %>
                    <%: Html.ValidationMessageFor(model => model.FirstName) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.LastName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.LastName) %>
                    <%: Html.ValidationMessageFor(model => model.LastName) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Preferences) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Preferences) %>
                    <%: Html.ValidationMessageFor(model => model.Preferences) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Phone) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Phone) %>
                    <%: Html.ValidationMessageFor(model => model.Phone) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Address) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Address) %>
                    <%: Html.ValidationMessageFor(model => model.Address) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.City) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.City) %>
                    <%: Html.ValidationMessageFor(model => model.City) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.County) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.County) %>
                    <%: Html.ValidationMessageFor(model => model.County) %>
                </div>
            
                <p>
                    <input type="submit" value="Create" />
                </p>
            </div>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

