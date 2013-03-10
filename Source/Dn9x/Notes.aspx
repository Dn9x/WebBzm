<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Notes.aspx.cs" Inherits="Dn9x_Notes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>访问记录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:800px; height:auto; border:1px solid #CCC; margin:20px auto; font-size:12px;">
      <table width="797" border="0" align="center" id="Acc_Tab">
        <tr>
          <td align="center" bgcolor="#33FFFF">编号</td>
          <td align="center" bgcolor="#33FFFF">URL</td>
          <td align="center" bgcolor="#33FFFF">IP</td>
          <td align="center" bgcolor="#33FFFF">DNS</td>
          <td align="center" bgcolor="#33FFFF">浏览器</td>
          <td align="center" bgcolor="#33FFFF">時間</td>
        </tr>
      </table>
    </div>
    <input type="hidden" value="0" id="Hid_Page" />
    </form>
    <script src="../Pub/Scripts/jquery-1.4.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        //自動加載
        $(document).ready(function () {
            addShow();

            //滾動條事件
            $(window).scroll(function () {
                //判斷是否是穀歌瀏覽器             
                var jH;

                if (navigator.userAgent.indexOf("Chrome") > -1) {
                    //網頁卷去的高度 兼容CH
                    jH = document.body.scrollTop;
                } else {
                    //網頁卷去的高度 兼容IE,FF,OP
                    jH = document.documentElement.scrollTop;
                }

                //網頁正文全文的高度
                var aH = document.body.scrollHeight;

                //網頁可見區域的高
                var kH = document.body.offsetHeight;

                //屏幕可用工作區高
                var yH = window.screen.availHeight;

                //alert(aH + "  " + jH + "   " + kH + "   " + yH);

                //判斷是否拉到底部
                if (kH - yH - jH < 4) {
                    addShow();
                }
            });

            function addShow() {
                var page = $("#Hid_Page").val();
                //加載初始
                $.getJSON(
                    "../Pub/Ashx/Notes.ashx",
                    { "page": page },
                    function (json, status) {
                        if (status = "success") {
                            var list = "";

                            $.each(json, function (i, item) {
                                list += "<tr>" +
                                            "<td align='center' bgcolor='#EEEEEE'>" + item.id + "</td>" +
                                            "<td align='center' bgcolor='#EEEEEE'>" + item.url + "</td>" +
                                            "<td align='center' bgcolor='#EEEEEE'>" + item.ip + "</td>" +
                                            "<td align='center' bgcolor='#EEEEEE'>" + item.dns + "</td>" +
                                            "<td align='center' bgcolor='#EEEEEE'>" + item.browser + "</td>" +
                                            "<td align='center' bgcolor='#EEEEEE'>" + item.date + "</td>" +
                                        "</tr>";
                            });

                            $("#Hid_Page").val(Number(page) + 20);

                            $("#Acc_Tab").append(list);
                        }
                    }
                );
            }
        });
    
    
    </script>

</body>
</html>
