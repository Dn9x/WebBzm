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
using System.Security.Cryptography;

public partial class Dn9x_Enter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Common.AccessNote();
    }


    protected void Btn_Enter_Click(object sender, EventArgs e)
    {
        string name = this.Txt_Name.Value.Trim();

        string pswd = this.Txt_Pswd.Value.Trim();

        if (name != null && pswd != null)
        {
            byte[] result = System.Text.Encoding.Default.GetBytes(pswd);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            pswd = BitConverter.ToString(output).Replace("-", "");

            ArticleBll ab = new ArticleBll();

            DataTable dt = ab.GetUserByNameAndPswd(name, pswd);

            if (dt.Rows.Count != 0)
            {
                Session["bzmname"] = dt.Rows[0]["admin_name"].ToString();

                Response.Redirect("Bzm.aspx");
            }
        }
    }
}
