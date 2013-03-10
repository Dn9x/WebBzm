using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;

public partial class List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitData();
        }
    }


    private void InitData()
    { 
        ArticleBll ab = new ArticleBll();

        DataTable dt = ab.GetTags();

        string div = "";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            div += "<div class='tag_list'>" +
                         "<div class='tag_list_title' onclick='show(this)'>" + dt.Rows[i]["tag_name"].ToString() + "</div>" +
                         "<div class='tag_list_cont'>";
                        
            //獲取文章信息
            DataTable dt1 = ab.GetArticleByTag(dt.Rows[i]["id"].ToString());

            //存放id的數組
            for (int z = 0; z < dt1.Rows.Count; z++)
            {
                div += "<a href='Detail.aspx?op=" + dt1.Rows[z]["id"].ToString() + "' target='_blank'>" + dt1.Rows[z]["title"].ToString() + "</a>";
            }

            div += "</div></div>";
        }

        this.Div_List.InnerHtml = div;
    }

}
