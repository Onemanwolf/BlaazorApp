using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WinWireApp;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("WinWireApp", client => client.BaseAddress = new Uri("https://todo-api.redgrass-633dc5ff.eastus.azurecontainerapps.io/"));
builder.Services.AddScoped<IDataAccess, DataAccessService>();


await builder.Build().RunAsync();
