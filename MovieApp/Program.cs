using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MovieApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Set up HttpClient with OMDB API base URL
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.omdbapi.com/") });

await builder.Build().RunAsync();
