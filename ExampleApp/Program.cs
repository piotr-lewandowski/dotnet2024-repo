using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Data;

var builder = WebApplication.CreateBuilder(args);

// builder.Configuration.AddJsonFile("appsettings.json").AddEnvironmentVariables();

// Add services to the container.
builder.Services.AddRazorPages();

// You can set the connection string in appsettings.json or as an environment variable:
// ConnectionStrings__WebApiDatabase="Host=localhost;Port=5432;Database=WebApiDatabase;Username=postgres;Password=postgres"
builder.Services.AddDbContext<CommentContext>(options =>
{
    options.UseNpgsql("name=ConnectionStrings:WebApiDatabase");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
