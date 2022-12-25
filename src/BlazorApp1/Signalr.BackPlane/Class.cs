using Microsoft.AspNetCore.SignalR;

namespace BlazorApp1.Signalr.BackPlane;


public class ProtoActorHubLifetimeManager<THub> : HubLifetimeManager<THub>, IDisposable where THub : Hub
{
}
