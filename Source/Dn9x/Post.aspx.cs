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

public partial class Dn9x_Post : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Common.AccessNote();

        if (Session["bzmname"] == null)
        {
            Response.Redirect("Enter.aspx");
        }

        if (!IsPostBack)
        {
            InitTags();
        }
    }


    private void InitTags()
    {
        try
        {
            ArticleBll ab = new ArticleBll();

            DataTable dt = ab.GetTags();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.DDL_Tag.Items.Add(new ListItem(dt.Rows[i]["tag_name"].ToString(), dt.Rows[i]["id"].ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }


    protected void Btn_Send_Click(object sender, EventArgs e)
    {
        try
        {
            string title = this.Txt_Title.Text.Trim();
            string tag = this.DDL_Tag.SelectedValue;
            string content = this.editor_id.Value.Trim();

            ArticleBll ab = new ArticleBll();

            string result = ab.AddArticle(title, content, tag);

            if (result == "1")
            {
                this.Txt_Title.Text = "";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
