using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BFS_SisControl.Client;
using BFS_SisControl.Client.Servicos;
using BFS_SisControl.Client.Servicos.ServicoPessoa;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IServicoPessoa, ServicoPessoa>();

await builder.Build().RunAsync();
