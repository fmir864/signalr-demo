namespace SignalrDemo.Hubs
{
    public interface IOfferHubClient
    {
        Task SendOffersToUser(string offer);
    }
}