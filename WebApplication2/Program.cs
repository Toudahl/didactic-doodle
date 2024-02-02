var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    ApplicationName = "MyApplication",
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();