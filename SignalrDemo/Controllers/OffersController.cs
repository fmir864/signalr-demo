using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalrDemo.Hubs;
using SignalrDemo.Models;
using SignalRDemo.Hub;

namespace SignalrDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IHubContext<OfferHub, IOfferHubClient> _hubContext;

        public OffersController(IHubContext<OfferHub, IOfferHubClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task Send(Offer offer)
        {
            await _hubContext.Clients.All.SendOffersToUser(offer.Name);
        }
    }
}