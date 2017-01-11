using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTML5WebApp1.WebSockets
{
    internal class MicrosoftWebSocket : WebSocketHandler
    {
        static WebSocketCollection client = new WebSocketCollection();
        string name = string.Empty;

        public MicrosoftWebSocket()
        {

        }

        public override void OnOpen()
        {
            name = this.WebSocketContext.QueryString["chatName"];
            client.Add(this);
            client.Broadcast(name + " has connected");
        }

        public override void OnMessage(string message)
        {
            client.Broadcast(string.Format("{0} said {1}", name, message));
        }

        public override void OnClose()
        {
            client.Remove(this);
            client.Broadcast(string.Format("{0} has gone away", name));
        }
    }
}
