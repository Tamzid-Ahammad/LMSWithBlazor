using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LMS.Client.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddScoped(sp => new HttpClient());


builder.Services.AddScoped<BookService>();

await builder.Build().RunAsync();
