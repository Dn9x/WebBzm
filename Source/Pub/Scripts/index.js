$(document).ready(function () {
    //處理分頁
    if (isIE6() || isIE7()) {
        $("#page").css("position", "absolute");
    }

    TagList('EM');

    //下一頁
    $("#page_down").click(function () {
        var page = $("#Hid_Page").val();
        var tag = $("#Hid_Tag").val();

        //加載初始
        $.getJSON(
            "Pub/Ashx/Index.ashx",
            { "page": page, "tag": tag },
            function (json, status) {
                if (status = "success") {
                    var list = "";

                    $.each(json, function (i, item) {
                        list += "<div class='post_list'><div class='post_title'><a href='Detail.aspx?op=" + item.rid + "' target='_blank' class='detail_a'>" + item.title + "</a></div>" +
                            "<div class='post_content'>" + item.content + "</div>" +
                            "<div class='post_info'>" + item.date + "&nbsp;&nbsp;" +
                            "<a class='auth_a' href='javascript:TagList(" + item.tid + ")'>" + item.tag + "</a>" +
                            "&nbsp&nbsp<a href='Web.aspx' target='_blank' class='auth_a'>" + item.uname + "</a>" +
                            "&nbsp&nbsp<a href='List.aspx' target='_blank' class='auth_a'>Tags</a></div></div>";
                    });

                    $("#Hid_Page").val(Number(page) + 10);

                    $("#main").append(list);
                }
            }
        );
    });
});

/*判斷各個瀏覽器*/
function isIE6() {
    try {
        return navigator.userAgent.split(";")[1].toLowerCase().indexOf("msie 6.0") == "-1" ? false : true;
    } catch (ex) {
        return false;
    }
}
function isIE7() {
    try {
        return navigator.userAgent.split(";")[1].toLowerCase().indexOf("msie 7.0") == "-1" ? false : true;
    } catch (ex) {
        return false;
    }
}

function TagList(op) {
    $.getJSON(
        "Pub/Ashx/Index.ashx",
        { "page": "0", "tag":op},
        function (json, status) {
            if (status = "success") {
                var list = "";

                $.each(json, function (i, item) {
                    list += "<div class='post_list'><div class='post_title'><a href='Detail.aspx?op=" + item.rid + "' target='_blank' class='detail_a'>" + item.title + "</a></div>" +
                            "<div class='post_content'>" + item.content + "</div>" +
                            "<div class='post_info'>" + item.date + "&nbsp;&nbsp;" +
                            "<a href='javascript:TagList(" + item.tid + ")' class='auth_a'>" + item.tag + "</a>" +
                            "&nbsp&nbsp<a href='Web.aspx' target='_blank' class='auth_a'>" + item.uname + "</a>" +
                            "&nbsp&nbsp<a href='List.aspx' target='_blank' class='auth_a'>Tags</a></div></div>";
                });

                $("#Hid_Tag").val(op);
                $("#main").html(list);
            }
        }
    );

}