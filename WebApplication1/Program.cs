var builder = WebApplication.CreateBuilder(args);


//add services
builder.Services.AddCors(options =>
    options.AddPolicy("myCors", builder => {
        builder
        .WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    }
    )
);
builder.Services.AddControllers();


var app = builder.Build();


app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors("myCors");
//add map
app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Redirect("/api/Books");
});

app.Run();
