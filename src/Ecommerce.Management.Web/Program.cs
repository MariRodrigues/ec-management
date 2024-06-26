using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Ecommerce.Management.Web;
using Ecommerce.Management.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

builder.Services.AddTransient<EcommerceAPI>();

builder.Services.AddHttpClient("EcommerceApi", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Urls:EcommerceApi"]!);
});

builder.Services.AddHttpClient("UserApi", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Urls:UserApi"]!);
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
