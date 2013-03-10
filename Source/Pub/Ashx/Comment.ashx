<%@ WebHandler Language="C#" Class="Comment" %>

using System;
using System.Web;
using BLL;

public class Comment : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        
        string result = String.Empty;

        try
        {
            string rid = context.Request["title"];   

            if (rid != null)
            {
                ArticleBll ab = new ArticleBll();

                result = ab.GetCommentByRid(rid);
            }
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