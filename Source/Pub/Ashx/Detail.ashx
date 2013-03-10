<%@ WebHandler Language="C#" Class="Detail" %>

using System;
using System.Web;
using BLL;

public class Detail : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        string result = String.Empty;

        try
        {
            string rid = context.Request["title"];         
            string name = context.Request["name"];        
            string content = context.Request["content"];   

            if (rid != null && name != null && content != null)
            {
                ArticleBll ab = new ArticleBll();

                result = ab.AddComment(rid, name, content);

                if (result == "1")
                {
                    result = ab.GetCommentByRid(rid);
                }
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