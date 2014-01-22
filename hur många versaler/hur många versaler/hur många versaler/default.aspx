<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="hur_många_versaler._default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="headerLabel" runat="server"><h1>Hur Många Versaler?</h1></asp:Label>
            <asp:TextBox ID="CapsTextBox" Textmode="multiline" Columns="50" rows="10" runat="server" ViewStateMode="Enabled"></asp:TextBox>
            <asp:Button ID="CapsButton" runat="server" Text="Bestäm antal versaler" ViewStateMode="Enabled" OnClick="CapsButton_Click" />
            <asp:Label ID="CapsLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
