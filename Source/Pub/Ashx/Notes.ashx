<%@ WebHandler Language="C#" Class="Notes" %>

using System;
using System.Web;
using BLL;

public class Notes : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        
        string page = context.Request["page"];

        string result = "";

        ArticleBll ab = new ArticleBll();

        result = ab.GetAccessList(page, "50");

        context.Response.Write(result);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}