using GitHubUserInfoDemo;
using GitHubUserInfoDemo.Data;
using GitHubUserInfoDemo.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddGitHubService(new Uri(builder.Configuration.GetSection("GitHubSettings:BaseApiUrl").Value));
builder.Services.AddDbContext<GitHubUserInfoEFDataContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
    ); 
builder.Services.AddTransient<IGitHubUserInfoDataService, GitHubUserInfoDataService>();
builder.Services.AddTransient<IGitHubResponseProcessorService, GitHubResponseProcessorService>();

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
