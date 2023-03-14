using FluentValidation;
using IntelligentFormsAPI.Application.Interfaces;
using IntelligentFormsAPI.Application.Mapper;
using IntelligentFormsAPI.Application.Models;
using IntelligentFormsAPI.Application.Models.FluentValidation;
using IntelligentFormsAPI.Application.Services;
using IntelligentFormsAPI.Infrastructure.Contexts;
using IntelligentFormsAPI.Infrastructure.Interfaces;
using IntelligentFormsAPI.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IUsersService, UsersService>();

builder.Services.AddScoped<ISubmissionsRepository, SubmissionsRepository>();
builder.Services.AddScoped<ISubmissionsService, SubmissionsService>();

builder.Services.AddScoped<IFormsRepository, FormsRepository>();
builder.Services.AddScoped<IFormsService, FormsService>();

builder.Services.AddScoped<IValidator<UserSignUpDto>, UserSignUpValidator>();


builder.Services.AddDbContext<EFContext>(options =>
    options.UseCosmos("https://f447355d-0ee0-4-231-b9ee.documents.azure.com:443/",
    "FSQsotIEON6q0I18CON0jelb5ZJFXxkfoVNvWde9FfBQxO0o5pmvgUaRLXgFYIMOvS8Eh8EG2ViJACDbGZaloA==",
    "IntelligentFormsDB"));

builder.Services.AddAutoMapper(typeof(UserProfile));
builder.Services.AddAutoMapper(typeof(FormProfile));
builder.Services.AddAutoMapper(typeof(SubmissionProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
});

builder.Services.AddAuthentication();

var app = builder.Build();

app.UseSwagger();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();


app.Run();
