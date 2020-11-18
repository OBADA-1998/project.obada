<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="App.aspx.cs" Inherits="project.obada.App" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
    
    </div>
        <asp:TextBox ID="txt_n" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="E-mail :"></asp:Label>
        <br />
        <asp:TextBox ID="txt_e" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btn_g" runat="server" OnClick="btn_g_Click" Text="Go" Width="128px" />
        </p>
    </form>
</body>
</html>
