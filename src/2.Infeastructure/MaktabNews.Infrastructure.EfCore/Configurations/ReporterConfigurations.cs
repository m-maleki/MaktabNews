using MaktabNew.Domain.Core.Entities;
using MaktabNew.Domain.Core.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabNews.Infrastructure.EfCore.Configurations
{
    public class ReporterConfigurations : IEntityTypeConfiguration<Reporter>
    {
        public void Configure(EntityTypeBuilder<Reporter> builder)
        {
            builder.HasData(new List<Reporter>()
            {
                new Reporter()
                {
                    Id = 2,
                    FullName = "علی محمدی",
                    ImageAddress = "~/assets/img/author/1.jpg"
                },
                new Reporter()
                {
                    Id = 3,
                    FullName = "سحر رمضانی",
                    ImageAddress = "~/assets/img/author/2.jpg"
                },

            });
        }
    }
}
