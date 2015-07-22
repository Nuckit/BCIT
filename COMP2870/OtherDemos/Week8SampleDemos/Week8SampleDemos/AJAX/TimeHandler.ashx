<%@ WebHandler Language="C#" Class="TimeHandler" %>

using System;
using System.Web;

public class TimeHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write(DateTime.Now.ToString("T"));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}