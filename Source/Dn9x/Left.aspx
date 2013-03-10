<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Dn9x_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>导航列表</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:80px auto; width:100%; height:auto; color:#333333; text-decoration:none; cursor:pointer;">
      <table width="200" height="266" border="0" align="center">
          <tr>
            <td height="50" align="center">
                <asp:Label ID="Lbl_Name" runat="server" Text=""></asp:Label>
            </td>
          </tr>
          <tr>
            <td height="50" align="center"><a href="javascript:PageLoad('Post.aspx');" style="color:#333333; text-decoration:none; cursor:pointer;">發表文章</a></td>
          </tr>
          <tr>
            <td height="50" align="center"><a href="javascript:PageLoad('Notes.aspx');" style="color:#333333; text-decoration:none; cursor:pointer;">瀏覽記錄</a></td>
          </tr>
          <tr>
            <td height="50" align="center"><a href="../Index.aspx" target="_blank" style="color:#333333; text-decoration:none; cursor:pointer;">去前端</a></td>
          </tr>
          <tr>
            <td height="50" align="center">
                <asp:Button ID="Btn_LoginOut" runat="server" Text="登出" 
                    onclick="Btn_LoginOut_Click" />
            </td>
          </tr>
      </table>
    </div>
    </form>
    <script type="text/javascript" language="javascript">
        function PageLoad(url) {
            parent.RightMain.location.href = url;
        }
    </script>
</body>
</html>

