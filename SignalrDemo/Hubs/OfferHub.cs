using Microsoft.AspNetCore.SignalR;
using SignalrDemo.Hubs;

namespace SignalRDemo.Hub
{
    public class OfferHub : Hub<IOfferHubClient>
    {
        public async Task SendOffersToUser(string offer)
        {
            await Clients.All.SendOffersToUser(offer);
        }
    }
}