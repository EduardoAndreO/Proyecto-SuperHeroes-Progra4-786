using SuperHeroes;
using SuperHeroes.Service;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//BD Conexion
builder.Services.AddSqlServer<context>("Data Source=localhost; Initial Catalog=SuperHeroes;user id=sa;password=Programaci0n$;Encrypt=False");
builder.Services.AddScoped<IsuperheroService, superheroService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
