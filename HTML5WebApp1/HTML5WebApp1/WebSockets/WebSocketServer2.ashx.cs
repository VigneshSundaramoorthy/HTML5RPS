using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebSockets;

namespace HTML5WebApp1.WebSockets
{
    /// <summary>
    /// Summary description for WebSocketServer2
    /// </summary>
    public class WebSocketServer2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            if (context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(new MicrosoftWebSocket());
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}