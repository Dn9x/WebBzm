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

public partial class Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Common.AccessNote();

        if (!IsPostBack)
        {
            InitData();
        }
    }

    public void InitData()
    {
        try
        {
            string rid = Request["op"];

            ArticleBll ab = new ArticleBll();

            DataTable dt = ab.GetArticleByRid(rid);

            this.Title = dt.Rows[0]["title"].ToString();
            this.Div_Title.InnerHtml = dt.Rows[0]["title"].ToString() + "<input type='hidden' id='Hid_Title' value='" + dt.Rows[0]["rid"].ToString() + "' />";
            this.Div_Content.InnerHtml = dt.Rows[0]["content"].ToString();
            this.Div_Info.InnerHtml = dt.Rows[0]["date"].ToString() + "&nbsp;&nbsp;" + dt.Rows[0]["tag"].ToString() +
                "&nbsp;&nbsp;<a href='Web.aspx' target='_blank' class='auth_a'>" + dt.Rows[0]["uname"].ToString() + "</a>&nbsp;&nbsp;&nbsp;&nbsp;留言請按q";

        }
        catch (Exception ex)
        {
            Response.Redirect("Index.aspx");
        }
    }


}
