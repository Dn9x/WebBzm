<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Post.aspx.cs" Inherits="Dn9x_Post" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>發表文章頁面</title>	
	<link rel="stylesheet" href="../Pub/Editor/themes/default/default.css" />
	<link rel="stylesheet" href="../Pub/Editor/plugins/code/prettify.css" />
	<script charset="utf-8" src="../Pub/Editor/kindeditor.js" type="text/javascript"></script>
	<script charset="utf-8" src="../Pub/Editor/lang/zh_CN.js" type="text/javascript"></script>
	<script charset="utf-8" src="../Pub/Editor/plugins/code/prettify.js" type="text/javascript"></script>
    <script type="text/javascript">        
        KindEditor.ready(function(K) {
			var editor1 = K.create('#editor_id', {
				cssPath : '../Pub/Editor/plugins/code/prettify.css',
				uploadJson : '../Pub/Editor/asp.net/upload_json.ashx',
				fileManagerJson : '../Pub/Editor/asp.net/file_manager_json.ashx',
				allowFileManager : true,
				afterCreate : function() {
					var self = this;
					K.ctrl(document, 13, function() {
						self.sync();
						K('form[name=form1]')[0].submit();
					});
					K.ctrl(self.edit.doc, 13, function() {
						self.sync();
						K('form[name=form1]')[0].submit();
					});
				}
			});
			prettyPrint();
		});
    </script>
</head>
<body>
    <form id="example" runat="server">
    <div style=" margin:10px auto; width:80%; height:auto;">
        <textarea id="editor_id" name="content" style="width:700px;height:300px;" runat="server">
        </textarea>
    </div>
    
    <div style=" margin:10px auto; width:80%; height:auto;">
        <asp:TextBox ID="Txt_Title" runat="server"></asp:TextBox>
        
        <asp:DropDownList ID="DDL_Tag" runat="server">
        </asp:DropDownList>
        
        <asp:Button ID="Btn_Send" runat="server" Text="写入" OnClick="Btn_Send_Click" />
    </div>
    
        
    </form>
</body>
</html>
