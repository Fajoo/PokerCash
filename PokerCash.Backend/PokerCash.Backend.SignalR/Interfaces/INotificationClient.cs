namespace PokerCash.Backend.SignalR.Interfaces;

public interface INotificationClient
{
    Task Send(string msg);
}