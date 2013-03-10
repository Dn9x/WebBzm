<%@ WebHandler Language="C#" Class="Index" %>

using System;
using System.Web;
using BLL;

public class Index : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        string result = String.Empty;

        try
        {
            string page = context.Request["page"];        
            string tid = context.Request["tag"];     

            ArticleBll ab = new ArticleBll();

            result = ab.GetArticleJson(tid, page, "10");
        }
        catch (Exception ex)
        {
            result = "[{'title':'程序出錯了','content':'錯誤信息未知！','date':'" + DateTime.Now.ToString() + "'}]";
        }

        context.Response.Write(result);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}