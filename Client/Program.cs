using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Travel_Itinerary.Client;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Travel_Itinerary.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddHttpClient("Travel_Itinerary.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
//.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

builder.Services.AddHttpClient("Travel_Itinerary.ServerAPI", (sp, client) => {
	client.BaseAddress = new
	Uri(builder.HostEnvironment.BaseAddress);
	client.EnableIntercept(sp);
})
.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Travel_Itinerary.ServerAPI"));

builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
