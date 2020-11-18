<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="project.obada.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    
    
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="E-mail :"></asp:Label>
    
    </div>
        <p>
    
        <asp:TextBox ID="txt_e" runat="server" OnTextChanged="txt_e_TextChanged"></asp:TextBox>
    
        </p>
        <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
        <p>
            <asp:TextBox ID="txt_p" runat="server" OnTextChanged="txt_p_TextChanged1"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_l" runat="server" OnClick="btn_l_Click" Text="Login" Width="116px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
