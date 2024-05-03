using MaktabNews.Domain.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Entities.Configs;
using MaktabNews.Domain.Services;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Infrastructure.EfCore.Repositories;
using MaktabNews.RazorPages.Infrastructure;
using MaktabNews.Redis;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
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

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();

builder.Services.AddSingleton(siteSettings);

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = siteSettings.RedisConfiguration.ConnectionString;
    options.ConfigurationOptions = new ConfigurationOptions
    {
        Password = string.Empty,
        DefaultDatabase = 10,
        ConnectTimeout = 5000,
    };
    options.ConfigurationOptions.EndPoints.Add(siteSettings.RedisConfiguration.ConnectionString);
});

builder.Logging.ClearProviders();

builder.Host.ConfigureLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();

}).UseSerilog((context, config) =>
{
    config.WriteTo.Seq(siteSettings.LogConfiguration.SeqAddress, LogEventLevel.Error);
});

builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(siteSettings.SqlConfiguration.ConnectionsString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.CustomExceptionHandlingMiddleware();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


app.DetectVpnMiddleware();

app.Run();
