using Microsoft.AspNetCore.Components.Server.Circuits;

namespace BlazorApp1.Signalr.BackPlane;

public class TrackingCircuitHandler : CircuitHandler
{
    public override int Order => base.Order;

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken) => base.OnCircuitClosedAsync(circuit, cancellationToken);
    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken) => base.OnCircuitOpenedAsync(circuit, cancellationToken);
    public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken) => base.OnConnectionDownAsync(circuit, cancellationToken);
    public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken) => base.OnConnectionUpAsync(circuit, cancellationToken);
}
