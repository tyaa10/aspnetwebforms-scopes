<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><input name="login" type="text" placeholder="login" /></div>
            <div><input name="password" type="password" placeholder="password" /></div>
            <div><input type="submit" value="submit" /></div>
        </div>
        <div>
            <%
                if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(password))
                {
                    Response.Write($"<span>login: {login}; </span>");
                    Response.Write($"<span>password: {password}</span>");
                }
            %>
        </div>
        <div>Last login: <%=lastLogin %></div>
        <div><asp:Button runat="server" ID="remove_cookies" Text="remove cookies" OnClick="remove_cookies_Click"></asp:Button></div>
        <div id="ind1Div" runat="server">indicator 1</div>
        <asp:PlaceHolder ID="ind2Placeholder" runat="server"></asp:PlaceHolder>
    </form>
</body>
</html>
