<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hidden_F.aspx.cs" Inherits="project.obada.Hidden_F" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt_1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
    
    </div>
        <asp:Button ID="btn_1" runat="server" OnClick="btn_1_Click" Text="Set_Text" Width="100px" />
        <br />
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <p>
            <asp:Button ID="btn_2" runat="server" OnClick="btn_2_Click" Text="Get_Text" Width="100px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
