<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
						<div><% Response.Write(GetPageHTML("http://gocomics.com/luann", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/wizardofid", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/pluggers", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/pearlsbeforeswine", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/garfield", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/foxtrot", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/calvinandhobbes", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/the-born-loser", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/bc", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://gocomics.com/adamathome", ".item-comic-image")); %></div>
			<div><% Response.Write(GetPageHTML("http://www.dilbert.com", ".img-comic-link")); %></div>
			<div><% Response.Write(GetPageHTMLID("http://www.shermanslagoon.com", "comic")); %></div>
		</div>
	</form>
</body>
</html>
