<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hangman Game</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Hangman</h1>

        
                
        <br />
        <br />

        <asp:Label ID="WordResult" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="TestWord" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Test2" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="A" />
        <asp:Button ID="Button2" runat="server" Text="B" />
        <asp:Button ID="Button3" runat="server" Text="C" />
        <asp:Button ID="Button4" runat="server" Text="D" />
        <asp:Button ID="Button5" runat="server" Text="E" />
        <asp:Button ID="Button6" runat="server" Text="F" />
        <asp:Button ID="Button7" runat="server" Text="G" />
        <asp:Button ID="Button8" runat="server" Text="H" />
        <asp:Button ID="Button9" runat="server" Text="I" />
        <asp:Button ID="Button10" runat="server" Text="J" />
        <asp:Button ID="Button11" runat="server" Text="K" />
        <asp:Button ID="Button12" runat="server" Text="L" />
        <asp:Button ID="Button13" runat="server" Text="M" />
        <br />
        <br />
        <asp:Button ID="Button14" runat="server" Text="N" />
        <asp:Button ID="Button15" runat="server" Text="O" />
        <asp:Button ID="Button16" runat="server" Text="P" />
        <asp:Button ID="Button17" runat="server" Text="Q" />
        <asp:Button ID="Button18" runat="server" Text="R" />
        <asp:Button ID="Button19" runat="server" Text="S" />
        <asp:Button ID="Button20" runat="server" Text="T" />
        <asp:Button ID="Button21" runat="server" Text="U" />
        <asp:Button ID="Button22" runat="server" Text="V" />
        <asp:Button ID="Button23" runat="server" Text="W" />
        <asp:Button ID="Button24" runat="server" Text="X" />
        <asp:Button ID="Button25" runat="server" Text="Y" />
        <asp:Button ID="Button26" runat="server" Text="Z" />
        
        <asp:Button ID="ButtonWord" runat="server" Text="New Word" />
        <br />
        <br />
        <asp:Button ID="Buttonexit" runat="server" Text="Exit" />
    </div>
    </form>
</body>
</html>
