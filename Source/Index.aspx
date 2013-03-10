<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>做夢也很累</title>
    <link rel="icon" href="Pub/Images/favicon.ico" type="image/x-icon" />
    <link href="Pub/Styles/index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main" runat="server">
    </div>
    <div id="page">
        <div class="page_up">
            <img src="Pub/Images/page_up_32.png" width="32" height="32" title="頂部" alt="頂部" onclick="javascript:scroll(0,0)" />
        </div>
        <div class="page_up">
            <img id="page_down" src="Pub/Images/page_down_32.png" title="下一頁" alt="下一頁" />
        </div>
    </div>
    <input type="hidden" value="10" id="Hid_Page" />
    <input type="hidden" value="EM" id="Hid_Tag" />
    </form>
    <script src="Pub/Scripts/jquery-1.4.2.min.js" type="text/javascript" language="javascript"></script>
    <script src="Pub/Scripts/index.js" type="text/javascript" language="javascript"></script>
</body>
</html>