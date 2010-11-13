<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<EnterpriseProject.Models.LogOnModel>" %>
    <div style="margin-top:-20px;">
    <% using (Html.BeginForm("LogOn", "Account"))
       { %>
        <%: Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again.") %>
        <div>
           <table cellpadding="3" cellspacing="0">
            <tr>
                <td>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.UserName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </div>
                </td>
                <td>
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Password) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
                </td>
                <td>
                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.RememberMe) %>
                    <%: Html.LabelFor(m => m.RememberMe) %>
                </div>
                </td>
                </tr>
                <tr>
                <td colspan="1">
                <%= Html.ActionLink("Register", "Register", "Account", new { Area = "" },null)%>
                </td>
                <td colspan="2" valign="top">
                <p style="font-size:0.7em;">
                    <input type="submit" value="Log On" />
                </p>
                </td>
                </tr>
                </table>
        </div>
    <% } %>
    </div>
    



