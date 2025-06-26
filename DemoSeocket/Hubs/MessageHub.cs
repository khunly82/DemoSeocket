using Microsoft.AspNetCore.SignalR;

namespace DemoSeocket.Hubs
{
    public class MessageHub: Hub
    {
        public void NewMessage(string message)
        {
            Clients.All.SendAsync("onNewMessage", message);
        }
    }
}
