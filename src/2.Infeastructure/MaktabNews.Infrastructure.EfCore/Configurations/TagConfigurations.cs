using MaktabNews.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabNews.Infrastructure.EfCore.Configurations
{
    public class TagConfigurations:IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(new List<Tag>
            {
                new Tag() { Id = 1, Title = "سفر" },
                new Tag() { Id = 2, Title = "طبیعت" },
                new Tag() { Id = 3, Title = "آموزش" },
                new Tag() { Id = 4, Title = "جنگل" },
                new Tag() { Id = 5, Title = "دریا" },
                new Tag() { Id = 6, Title = "مد و فشن" },
                new Tag() { Id = 7, Title = "سلامتی" },
                new Tag() { Id = 8, Title = "غذا" },
                new Tag() { Id = 9, Title = "صبحانه" },
                new Tag() { Id = 10, Title = "شام" },
            });
        }
    }
}
