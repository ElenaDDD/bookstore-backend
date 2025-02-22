var builder = WebApplication.CreateBuilder(args);


//add services
builder.Services.AddControllers();

var app = builder.Build();

//add map
app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Redirect("/api/Books");
});

app.Run();
