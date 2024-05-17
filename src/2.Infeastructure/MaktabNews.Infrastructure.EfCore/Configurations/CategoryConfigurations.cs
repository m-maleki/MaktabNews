using MaktabNews.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabNews.Infrastructure.EfCore.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(new List<Category>()
            {
                new Category() { Id = 1, Title = "سیاسی" },
                new Category() { Id = 2, Title = "بین المللی" },
                new Category() { Id = 3, Title = "اجتماعی" },
                new Category() { Id = 4, Title = "فرهنگی" },
                new Category() { Id = 5, Title = "ورزشی" }
            });
        }
    }
}
