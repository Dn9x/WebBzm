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

public partial class Dn9x_Left : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Common.AccessNote();

        if (Session["bzmname"] == null)
        {
            Response.Redirect("Enter.aspx");
        } 
        else
        {
            this.Lbl_Name.Text = Session["bzmname"].ToString();
        }
    }

    protected void Btn_LoginOut_Click(object sender, EventArgs e)
    {
        Session["bzmname"] = null;

        Response.Redirect("Enter.aspx");
    }
}
