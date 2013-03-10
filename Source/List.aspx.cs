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
            InitParent();
        }
    }


    private void InitParent()
    {
        this.Tv_List.Nodes.Add(new TreeNode("做夢也很累", "1"));

        this.Tv_List.ExpandDepth();

        ArticleBll ab = new ArticleBll();

        DataTable dt = ab.GetTags();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            this.Tv_List.Nodes[0].ChildNodes.Add(new TreeNode(dt.Rows[i]["tag_name"].ToString(), dt.Rows[i]["id"].ToString()));

            DataTable dt1 = ab.GetArticleByTag(dt.Rows[i]["id"].ToString());

            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                this.Tv_List.Nodes[0].ChildNodes[i].ChildNodes.Add(new TreeNode(dt1.Rows[j]["title"].ToString(), dt1.Rows[j]["id"].ToString()));
            }
        }
    }

}
