using BlazorApp1.Data;
using BlazorApp1.Signalr.BackPlane;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.SignalR;
using Boost.Proto.Actor.Hosting;
using Boost.Proto.Actor.Hosting.Cluster;
using Microsoft.AspNetCore.Components.Server.Circuits;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseProtoActorCluster((option, sp) =>
{
    option.Name = "poc";
});

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddSingleton(typeof(HubLifetimeManager<>), typeof(ProtoActorHubLifetimeManager<>));
builder.Services.AddSingleton<CircuitHandler, TrackingCircuitHandler>();
builder.Services.AddServerSideBlazor().AddHubOptions(option =>
{
    option.EnableDetailedErrors = true;
});
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
