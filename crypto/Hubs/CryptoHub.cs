using Microsoft.AspNetCore.SignalR;
namespace crypto.Hubs;

    public class CryptoHub : Hub
    {
        public async Task SendMessage(string Message)
        {
            await Clients.All.SendAsync("receivemessage", Message);
        }
        //public async Task SendCryptoList()
        //{

        //}
    }