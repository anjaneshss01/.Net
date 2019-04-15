<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_HelloWorld.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
            <br />
            <asp:label ID="lblCountry" runat="server" Text="Country"></asp:label><br />
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ShipCountry" DataValueField="ShipCountry"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindDB_ConnectionString %>" SelectCommand="select distinct(ShipCountry) From orders;
"></asp:SqlDataSource>
            <br />
            <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
            <asp:RadioButton ID="Male" runat="server" Text="Male" GroupName="Gender"/>
            <asp:RadioButton ID="Female" runat="server" Text="Female" GroupName="Gender"/>
            <br />
            <asp:Label ID="lblLanguages" runat="server" Text="Languages Known:"></asp:Label>
            <asp:CheckBox ID="cboxjava" runat="server" Text="Java"/>
            <asp:CheckBox ID="cboxCsharp" runat="server" Text="C#" />
            <asp:CheckBox ID="cboxPython" runat="server" Text="Python" />
            <br /><br /><br />

            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        </div>
      
    </form>
</body>
</html>
