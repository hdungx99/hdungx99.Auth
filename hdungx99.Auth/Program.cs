using hdungx99.Auth.AppBuilder;
using hdungx99.Auth.AppServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices();

var app = builder.Build();

app.UseBuilder(app.Environment.IsDevelopment());

app.MapGet("/", () => "Hello World!");

await app.RunAsync();
