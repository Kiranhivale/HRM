var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
// this project started on 6/09/2026 and is a simple API project that uses .NET 8.0 and C# 13.0. It is designed to be a starting point for building web APIs with ASP.NET Core. The project includes basic configurations for Swagger/OpenAPI documentation, HTTPS redirection, and authorization middleware.