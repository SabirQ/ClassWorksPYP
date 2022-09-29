using Microsoft.AspNetCore.SignalR;

namespace SignalPractise.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string message)
        {

            await Clients.All.SendAsync("ReceiveMessage",message);
        }


        public override Task OnConnectedAsync()
        {
            string a = Context.ConnectionId;
            return base.OnConnectedAsync();
        }
    }
}
