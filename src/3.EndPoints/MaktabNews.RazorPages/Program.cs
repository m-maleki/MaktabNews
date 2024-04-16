using MaktabNews.Domain.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Services;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Infrastructure.EfCore.Repositories;
using MaktabNews.Redis;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<INewsServices, NewsServices>();
builder.Services.AddScoped<INewsAppServices, NewsAppServices>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();
builder.Services.AddScoped<ICategoryAppServices, CategoryAppServices>();

builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<ITagServices, TagServices>();
builder.Services.AddScoped<ITagAppServices, TagAppServices>();


builder.Services.AddScoped<IReporterRepository, ReporterRepository>();
builder.Services.AddScoped<IReporterServices, ReporterServices>();
builder.Services.AddScoped<IReporterAppServices, ReporterAppServices>();

builder.Services.AddScoped<IRedisCacheServices, RedisCacheServices>();

// Add services to the container.



builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
    options.ConfigurationOptions = new ConfigurationOptions
    {
        Password = string.Empty,
        DefaultDatabase = 10,
        ConnectTimeout = 5000,
    };
    options.ConfigurationOptions.EndPoints.Add("localhost:6379");
});


builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(
        "Data Source=masoud;Initial Catalog=MaktabNews;User ID=sa;Password=25915491;TrustServerCertificate=True;Encrypt=True"));

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
