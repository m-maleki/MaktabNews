using Serilog;
using Serilog.Events;
using MaktabNews.Redis;
using StackExchange.Redis;
using MaktabNews.Domain.Services;
using MaktabNews.Domain.AppServices;
using Microsoft.EntityFrameworkCore;
using MaktabNews.RazorPages.Infrastructure;
using MaktabNews.Domain.Core.Entities.Configs;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.AppServices;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Infrastructure.EfCore.Repositories;
using MaktabNew.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

#region Register Services


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

builder.Services.AddScoped<IAccountAppServices, AccountAppServices>();



#endregion

#region Configuration


var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var siteSettings = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();

builder.Services.AddSingleton(siteSettings);

#endregion

#region CacheConfiguration

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

#endregion

#region LogConfiguration

builder.Logging.ClearProviders();

builder.Host.ConfigureLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();

}).UseSerilog((context, config) =>
{
    config.WriteTo.Seq(siteSettings.LogConfiguration.SeqAddress, LogEventLevel.Error);
});

#endregion

#region EfConfiguration

builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(siteSettings.SqlConfiguration.ConnectionsString));

#endregion

#region IdentityConfiguration

builder.Services.AddIdentity<ApplicationUser,IdentityRole<int>>
    (options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddRoles<IdentityRole<int>>()
    .AddEntityFrameworkStores<AppDbContext>();

#endregion



builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();


app.DetectVpnMiddleware();

app.Run();
