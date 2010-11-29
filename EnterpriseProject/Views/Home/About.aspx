<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
  <script type="text/javascript">
      $(document).ready(function () {
          $("#home_link").addClass("selected");
          $("#home_section").addClass("selected");
      });
</script>

<h1>About FeedMe</h1>

  <table width="100%">
    <tr style="">
        <td valign="top">
        <h3>feedMe is ........ blah blah blah blah blah blah
        <br><br><br>
        <ul>Developed by:
            <li>adf</li>
            <li>dfadf</li>
            <li>adfdf</li>
            <li>adfadf</li>
        </ul>
        </h3>
        </td>
        <td style="width:30%">
            <div id="accordion">
	            <h3><a href="#">Todays Hot Favourites</a></h3>
	            <div>
		            <p>
		            Mauris mauris ante, blandit et, ultrices a, suscipit eget, quam. Integer
		            ut neque. Vivamus nisi metus, molestie vel, gravida in, condimentum sit
		            amet, nunc. Nam a nibh. Donec suscipit eros. Nam mi. Proin viverra leo ut
		            odio. Curabitur malesuada. Vestibulum a velit eu ante scelerisque vulputate.
		            </p>
	            </div>
	            <h3><a href="#">Special Offers</a></h3>
	            <div>
		            <p>
		            Sed non urna. Donec et ante. Phasellus eu ligula. Vestibulum sit amet
		            purus. Vivamus hendrerit, dolor at aliquet laoreet, mauris turpis porttitor
		            velit, faucibus interdum tellus libero ac justo. Vivamus non quam. In
		            suscipit faucibus urna.
		            </p>
	            </div>
	            <h3><a href="#">New Items</a></h3>
	            <div>
		            <p>
		            Nam enim risus, molestie et, porta ac, aliquam ac, risus. Quisque lobortis.
		            Phasellus pellentesque purus in massa. Aenean in pede. Phasellus ac libero
		            ac tellus pellentesque semper. Sed ac felis. Sed commodo, magna quis
		            lacinia ornare, quam ante aliquam nisi, eu iaculis leo purus venenatis dui.
		            </p>
		            <ul>
			            <li>List item one</li>
			            <li>List item two</li>
			            <li>List item three</li>
		            </ul>
	            </div>
            </div>
        </td>
    </tr>
</table>
</asp:Content>
