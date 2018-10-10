<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="countLabel"><%= count %></asp:Label>
            <asp:Button runat="server" Text="+" ID="countButton" OnClick="countButton_Click" />
        </div>
        <div>
            <asp:ListView ID="itemsListView" runat="server" ItemPlaceholderID="itemsListViewContent">
                <LayoutTemplate>
                    <ul runat="server" id="itemsListViewContent">
                        
                    </ul>
                </LayoutTemplate>
                <ItemTemplate>
                    <li>
                        <a href="Details.aspx?id=<%# DataBinder.Eval(Container.DataItem, "id") %>" ><%# DataBinder.Eval(Container.DataItem, "title") %></a>  
                    </li>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
