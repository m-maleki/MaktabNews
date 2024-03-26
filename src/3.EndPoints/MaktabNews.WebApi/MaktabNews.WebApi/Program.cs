using MaktabNews.Domain.Services;
using MaktabNews.Domain.AppServices;
using Microsoft.EntityFrameworkCore;
using MaktabNews.Infrastructure.EfCore.Common;
using MaktabNews.Domain.Core.Contracts.Services;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Contracts.AppServifces;
using MaktabNews.Infrastructure.EfCore.Repositories;
using MaktabNews.Domain.Core.Contracts.AppServices;

var builder = WebApplication.CreateBuilder(args);

#region RegisterServices

builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<INewsServices, NewsServices>();
builder.Services.AddScoped<INewsAppServices, NewsAppServices>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();
builder.Services.AddScoped<ICategoryAppServices, CategoryAppServices>();

builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<ITagServices, TagServices>();
builder.Services.AddScoped<ITagAppServices, TagAppServices>();


builder.Services.AddScoped<IReporterRepository, ReporterRepository>();
builder.Services.AddScoped<IReporterServices, ReporterServices>();
builder.Services.AddScoped<IReporterAppServices, ReporterAppServices>();

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(
        "Data Source=masoud;Initial Catalog=MaktabNews;User ID=sa;Password=******;TrustServerCertificate=True;Encrypt=True"));

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

app.UseCors(Option =>
{
    Option.AllowAnyMethod();
    Option.AllowAnyHeader();
    Option.AllowAnyOrigin();
});

app.Run();
