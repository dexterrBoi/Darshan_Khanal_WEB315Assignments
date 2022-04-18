using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace DarshanKhanalChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
       
      
        }
        
         public Task SendMessageToGroup(string user, string message)
        {
            return Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}