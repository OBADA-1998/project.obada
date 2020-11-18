<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cook.aspx.cs" Inherits="project.obada.Cook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txt_f" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Firstname"></asp:Label>
        <p>
            <asp:TextBox ID="txt_l" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Lastname"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btn_c" runat="server" OnClick="btn_c_Click" style="height: 26px" Text="Click" />
        </p>
    </form>
</body>
</html>
