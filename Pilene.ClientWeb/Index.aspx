<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Pilene.ClientWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBoxHelloWorld" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonHelloWorld" runat="server" Text="Button" OnClick="ButtonHelloWorld_Click" />
        <br />
        <asp:Label ID="LabelHelloWorld" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
