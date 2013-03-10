<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Enter.aspx.cs" Inherits="Dn9x_Enter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>登錄</title>
    <link rel="icon" href="../Pub/Images/favicon.ico" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:100%; height:auto; top:45%; left:0px; position:absolute;">
        <table width="300" height="155" border="0" align="center" style="margin-top:20px;">
          <tr>
            <td width="76" height="40" align="right">名稱</td>
            <td width="214" align="left">
              <input type="text" name="Txt_Name" id="Txt_Name" runat="server" />
            </td>
          </tr>
          <tr>
            <td height="40" align="right">密碼</td>
            <td align="left"><input type="password" name="Txt_Pswd" id="Txt_Pswd" runat="server" /></td>
          </tr>
          <tr>
            <td height="40">&nbsp;</td>
            <td align="left">
                <asp:Button ID="Btn_Enter" runat="server" Text="登錄" onclick="Btn_Enter_Click" />&nbsp;&nbsp;
                <input type="button" name="button2" id="button2" value="關閉" />
            </td>
          </tr>
        </table>
    </div>
    </form>
</body>
</html>
