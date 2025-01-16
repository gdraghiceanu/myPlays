var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure middleware to serve static files
app.UseStaticFiles();

// app.MapGet("/", () => "Hello World!");
// Map root path to index.html
app.Map("/", async context =>
{
    context.Response.Redirect("/index.html");
});

app.Run();
