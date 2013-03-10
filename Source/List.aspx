<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" SmartNavigation="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>做夢也很累-列表</title>
    <link rel="icon" href="Pub/Images/favicon.ico" type="image/x-icon" />
    <link href="Pub/Styles/index.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        a
        {
	         color:#444444;
	         font-size:11px;
	         text-decoration:underline;
	         padding:4px;
	         width:auto;
	         margin:4px 4px;
        }

        a:hover
        {
	         color:#3399FF;
	         font-size:11px;
	         text-decoration:underline;
	         padding:4px;
	         width:auto;
	         margin:4px 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <fieldset id="head">
            <legend>做夢也很累</legend>
            <div id="Div_List" runat="server" style="width:100%; height:auto;">
            </div>
        </fieldset>
    </div>
    </form> 
    
    
    <script src="Pub/Scripts/jquery-1.4.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function show(op){
            $(op).next().toggle();
        }
    </script>
</body>
</html>
