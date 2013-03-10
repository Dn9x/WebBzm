<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title id="Title1" runat="server"></title>
    <link rel="icon" href="Pub/Images/favicon.ico" type="image/x-icon" />
    <link href="Pub/Styles/index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <!--文章內容層-->
        <div class='post_list'>
            <div class='post_title' id="Div_Title" runat="server"></div>
            <div class='post_content' id="Div_Content" runat="server"></div>
            <div class='post_info' id="Div_Info" runat="server"></div>
        </div>

        <!--評論層-->
        <div class="post_list" id="Div_Reply" style="display:none;">
       	  <table width="580" border="0" align="center">
        	  <tr>
        	    <td width="90" align="right" style="color:#333; font-size:16px;">名称：</td>
        	    <td colspan="2" align="left">
       	        	<input type="text" name="Txt_Name" id="Txt_Name" style="width:320px; height:20px; line-height:20px;" />
                </td>
       	    </tr>
        	  <tr>
        	    <td align="right" style="color:#333; font-size:16px;">内容：</td>
        	    <td colspan="2" align="left">
                	<textarea name="Txt_Content" id="Txt_Content" style="width:400px; height:80px;"></textarea>
                </td>
       	    </tr>
        	<tr>
        	    <td>&nbsp;</td>
        	    <td align="left"><input type="button" name="Btn_Post" id="Btn_Post" value="送出" /></td>
        	    <td align="left">&nbsp;</td>
      	    </tr>
      	  </table>
		</div>
    </div>
    </form>
    <script src="Pub/Scripts/jquery-1.4.2.min.js" type="text/javascript"></script>
    <script src="Pub/Scripts/detail.js" type="text/javascript"></script>
</body>
</html>
