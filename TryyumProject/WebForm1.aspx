<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TryyumProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter No 1:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            ENter No 2:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <p>
            Resut is
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="Button2" runat="server" Text="Go to other Page" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Subtract" />
            <asp:Button ID="Button4" runat="server" Text="Go to other Page witrh values using QueryString" OnClick="Button4_Click" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Go to Other Page using Cookies" />
            <asp:Button ID="Button6" runat="server" Text="Button" />
            <asp:Button ID="Button7" runat="server" Text="Button" />
        </p>
        <p>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        </p>
    </form>
</body>
</html>
