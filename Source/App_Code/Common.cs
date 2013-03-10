using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;

/// <summary>
/// Common 
/// </summary>
public class Common
{
    public Common()
    {
        //
        // TODO: 
        //
    }

    public static void AccessNote()
    {
        try
        {
            string ip = HttpContext.Current.Request.UserHostAddress;

            string url = HttpContext.Current.Request.Url.AbsoluteUri;

            string dns = HttpContext.Current.Request.UserHostName;

            string brow1 = HttpContext.Current.Request.Browser.Browser;
            string brow2 = HttpContext.Current.Request.Browser.Version;
            string brow3 = HttpContext.Current.Request.Browser.Type;
            string brow = brow1 + brow2 + " " + brow3;

            ArticleBll ab = new ArticleBll();

            ab.SaveAccess(url, ip, dns, brow);
        }
        catch (Exception ex)
        {

        }
    }
}
