<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

     <table id="buttons_table" style="font-size: 0.8em; height: 80px; border: 0pt none;" cellpadding="0">
          <tr>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                       <li>
                          <%= Html.ActionLink("Home", "Index", "Home", null, new { id="home_section", Class="blue_button", style="width:100px;" })%>
                       </li>
                    </ul>
                </td>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                       <li>
                         <%= Html.ActionLink("Friends", "Index", "Friends", null, new { id="friends_section",Class="blue_button", style="width:100px;" })%>
                       </li>
                    </ul>
                </td>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                       <li>
                       <%= Html.ActionLink("Search", "Index", "Home", null, new { Class="blue_button", style="width:100px;" })%>
                       </li>
                    </ul>
                </td>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                       <li>
                         <%= Html.ActionLink("My LunchBox", "Index", "Home", null, new { Class="blue_button", style="width:100px;" })%>
                       </li>
                    </ul>
                </td>
          </tr>
          <tr>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                    <% if (Roles.IsUserInRole("Vendor")){ %>
                        <li><%= Html.ActionLink("Menus", "Index", "Menus", null, new { id="menus_section", Class="blue_button", style="width:100px;" })%></li>
                    <% } %>
                    <% if (Roles.IsUserInRole("Customer")){ %>
                        <li><%= Html.ActionLink("Menus", "Index", "Vendors", null, new { id="menus_section", Class="blue_button", style="width:100px;" })%></li>
                    <% } %>
                    </ul>
                </td>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                    <% if (Roles.IsUserInRole("Vendor")){ %>
                        <li><%= Html.ActionLink("Orders", "Orders", "Vendors", null, new { id="orders_section", Class="blue_button", style="width:100px;" })%></li>
                    <% } %>
                    <% if (Roles.IsUserInRole("Customer")){ %>
                        <li><%= Html.ActionLink("Orders", "Index", "Orders", null, new { id = "orders_section", Class = "blue_button", style = "width:100px;" })%></li>
                    <% } %>
                    </ul>
                </td>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                       <li>
                        <%= Html.ActionLink("Profile", "Index", "Profile", new { Area = "" }, new { id="profile_section", Class = "blue_button", style = "width:100px;" })%>
                       </li>
                    </ul>
                </td>
                <td>
                    <ul id="filtering-nav" class="nav" style="margin-top: 0px; margin-bottom: 0px;">
                       <li>
                        <%: Html.ActionLink("Log Off", "LogOff", "Account", new { Area = "" }, new { Class = "black_button", style = "width:100px;" })%>
                       </li>
                    </ul>
                </td>
          </tr>
     </table>

