using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton(new CosmosClient("https://f447355d-0ee0-4-231-b9ee.documents.azure.com:443/",
    "FSQsotIEON6q0I18CON0jelb5ZJFXxkfoVNvWde9FfBQxO0o5pmvgUaRLXgFYIMOvS8Eh8EG2ViJACDbGZaloA=="));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
