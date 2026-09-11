using Swashbuckle.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using projeto1;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

var DefaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(
            new JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.UseInlineDefinitionsForEnums();
});
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<JogosService>();
builder.Services.AddScoped<JogoRepository>();
builder.Services.AddDbContext<DbGames>(Options => Options.UseSqlServer(DefaultConnection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   
    app.UseSwagger();
     app.UseSwaggerUI();
    app.MapOpenApi();
}


app.MapControllers();
app.UseHttpsRedirection();
    

app.Run();

