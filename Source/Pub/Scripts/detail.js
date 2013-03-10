$(document).ready(function () {
    $("#Btn_Post").click(function () {
        $("#Btn_Post").attr("disabled", "disabled");

        var title = $("#Hid_Title").val();
        var name = $("#Txt_Name").val();
        var content = $("#Txt_Content").val();

        if (name != null && content != null) {
            //加載初始
            $.getJSON(
                "Pub/Ashx/Detail.ashx",
                { "title": title, "name": name, "content": content },
                function (json, status) {
                    if (status = "success") {
                        var list = "";

                        $.each(json, function (i, item) {
                            list += "<div class='post_list_post'><table width='580' height='auto' border='0' align='center'>" +
                            "<tr><td style='width:72px;' rowspan='2' align='center' valign='top'>" +
                            "<img src='Pub/Images/head.jpg' width='50' height='50' alt='" + item.uname + "' title='" + item.uname + "' /></td>" +
                            "<td align='left' style='width:498px; font-size:11px; color:#555;'>" + item.uname + "&nbsp;&nbsp;" + item.date + "</td>" +
                            "</tr><tr>" +
                            "<td align='left'>" +
                            "<div style='width:100%; font-size:12px; color:#555; height:auto; word-wrap:break-word; word-break:break-all;'>" + item.content + "</div></td>" +
                            "</tr></table></div>";
                        });

                        $(".post_list_post").remove();
                        $("#Div_Reply").css("display", "none");
                        $("#Txt_Content").val("");
                        $("#Btn_Post").removeAttr("disabled");

                        $("#main").append(list);
                    }
                }
            );
        }
    });

    //加載評論
    showPost();
});

//監控鍵盤
$(document).keypress(function (e) {
    //判断
    if (e.which == 113) {
        //得到層的狀態
        var vis1 = $("#Div_Reply").css("display");

        //判斷
        if (vis1 == "block") {
            $("#Div_Reply").css("display", "none");
        } else if (vis1 == "none") {
            $("#Div_Reply").css("display", "block");
        }
    }
});


function showPost() {
    var title = $("#Hid_Title").val();

    //加載初始
    $.getJSON(
        "Pub/Ashx/Comment.ashx",
        { "title": title },
        function (json, status) {
            if (status = "success") {
                var list = "";

                $.each(json, function (i, item) {
                    list += "<div class='post_list_post'><table width='580' height='auto' border='0' align='center'>" +
                            "<tr><td style='width:72px;' rowspan='2' align='center' valign='top'>" +
                            "<img src='Pub/Images/head.jpg' width='50' height='50' alt='" + item.uname + "' title='" + item.uname + "' /></td>" +
                            "<td align='left' style='width:498px; font-size:11px; color:#555;'>" + item.uname + "&nbsp;&nbsp;" + item.date + "</td>" +
                            "</tr><tr>" +
                            "<td align='left'>" +
                            "<div style='width:100%; font-size:12px; color:#555; height:auto; word-wrap:break-word; word-break:break-all;'>" + item.content + "</div></td>" +
                            "</tr></table></div>";
                });

                $("#main").append(list);
            }
        }
    );
}