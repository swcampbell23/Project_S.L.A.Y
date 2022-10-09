var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "merging");

app.Run();

// finally
