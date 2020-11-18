<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="querystring.aspx.cs" Inherits="project.obada.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="txtn" runat="server">
    <div id="txt_">
    
        <asp:Label ID="Label1" runat="server" Text="Enter your text :"></asp:Label>
    
    </div>
        <p>
    
        <asp:TextBox ID="txt_n" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Trance" Width="126px" />
        </p>
    </form>
</body>
</html>
