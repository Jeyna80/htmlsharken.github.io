var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapPost("/Animalcharity", async(HttpRequest request) => 
{
     var content = await request.ReadFormAsync();
    string name = content["firstname"].ToString();
    return name;
    string name = content["lastname"].ToString();
    return name;
});
app.MapGet("/", () => "hello, world!");

app.Run();
