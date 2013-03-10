<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>做夢也很累-列表</title>
    <link rel="icon" href="Pub/Images/favicon.ico" type="image/x-icon" />
    <link href="Pub/Styles/index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="Tv_List" runat="server" ImageSet="Simple" ShowLines="True" Font-Names="Arial,Tahoma,Verdana" RootNodeStyle-Font-Size="16px" RootNodeStyle-ForeColor="#333333" ParentNodeStyle-Font-Size="14px" ParentNodeStyle-ForeColor="#333333" NodeStyle-Font-Size="12px" NodeStyle-ForeColor="#333333" HoverNodeStyle-ForeColor="blue">
        </asp:TreeView>
    </div>
    </form>
</body>
</html>
