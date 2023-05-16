using Entities;
using Microsoft.AspNetCore.SignalR;

namespace Dogtrick.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) 
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
