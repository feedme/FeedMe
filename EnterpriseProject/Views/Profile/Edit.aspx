<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Profile/Profile.Master" Inherits="System.Web.Mvc.ViewPage<EnterpriseProject.Models.ProfileCommon>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#edit_link").addClass("selected");
        $("#profile_section").addClass("selected");
    });
</script>
    <h1>Edit your Profile</h1>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Edit Profile Fields</legend>
            
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
                    <%: Html.LabelFor(model => model.Bio) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Bio) %>
                    <%: Html.ValidationMessageFor(model => model.Bio) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Phone) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Phone) %>
                    <%: Html.ValidationMessageFor(model => model.Phone) %>
                </div>
            
                <div class="editor-label">
                    <%: Html.LabelFor(model => model.Street) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(model => model.Street) %>
                    <%: Html.ValidationMessageFor(model => model.Street) %>
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
                    <input type="submit" value="Save" />
                </p>
            </div>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

