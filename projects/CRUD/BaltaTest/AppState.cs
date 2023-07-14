namespace BaltaTest;

/* Classes estáticas funcionam como uma espécie de Singleton,
     quando iniciar essa classe vai viver até o app ser destruido
 */

// Tudo que é estático é global
/*
    Em aplicações de servidor (API ASP.NET, Blazor Server por exemplo)
    isso nunca poderia acontecer
    pois isso ficaria compartilhado pra todos os usuários 
*/
/* 
    Como o Blazor WASM roda no lado do client, não tem esse problema
    e usar essa classe como um estado global, análogo ao redux e context do react
*/
public static class AppState
{
    public static string LoggedUser { get; set; } = string.Empty;
    public static Uri BaseUri { get; private set; } = new Uri("http://localhost:5095/");
}