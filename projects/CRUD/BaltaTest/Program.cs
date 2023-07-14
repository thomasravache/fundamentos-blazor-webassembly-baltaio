using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BaltaTest;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Procura o elemento html dentro do index.html que tem o id "app"
builder.RootComponents.Add<App>("#app");

// Permite que o título da página seja trocada com o <PageTitle></PageTitle> no Index.razor
builder.RootComponents.Add<HeadOutlet>("head::after");

// Existe essa forma abaixo de habilitar requisições HTTP e também com um pacote chamado REST Sharp
builder.Services.AddScoped(IServiceProvider => new HttpClient { BaseAddress = AppState.BaseUri });

await builder.Build().RunAsync();
