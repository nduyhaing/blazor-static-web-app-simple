using blazor_static_web_app_simple;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
 new HttpClient
 {
     BaseAddress =  new Uri(builder.HostEnvironment.BaseAddress)
 }
);

await builder.Build().RunAsync();
