using Blazored.LocalStorage;
using GameTracker;
using GameTracker.Interfaces.FaceItInterfaces;
using GameTracker.Services.FaceItServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IFaceItInfoService, FaceItInfoService>();
builder.Services.AddScoped<IFaceItStatsService, FaceItStatsService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("FaceitClient", client =>
{
    client.BaseAddress = new Uri("https://open.faceit.com/data/v4/");
    client.DefaultRequestHeaders.Add("Authorization", "Bearer c270aaf6-113f-4af1-8b11-65911b3faaae");
});

await builder.Build().RunAsync();
