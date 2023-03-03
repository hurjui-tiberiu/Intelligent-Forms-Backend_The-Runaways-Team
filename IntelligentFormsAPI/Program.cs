using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Services;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using IntelligentFormsAPI.Infrastructure.Repositories;
using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton(new CosmosClient("https://f447355d-0ee0-4-231-b9ee.documents.azure.com:443/",
    "FSQsotIEON6q0I18CON0jelb5ZJFXxkfoVNvWde9FfBQxO0o5pmvgUaRLXgFYIMOvS8Eh8EG2ViJACDbGZaloA=="));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAuthentication();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

/*app.UseAuthorization();
app.UseAuthentication();*/

app.MapControllers();

app.Run();
