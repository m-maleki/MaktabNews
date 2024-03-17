using MaktabNew.Domain.Core.Entities;
using MaktabNew.Domain.Core.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabNews.Infrastructure.EfCore.Configurations
{
    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasData(new List<Admin>()
            {
                new Admin()
                {
                    Id = 1,
                    FullName = "مسعود ملکی",
                    Email = "Maleki.jm@gmail.com",
                    Password = "1qaz!QAZ",
                    UserRole = UserRole.Admin,
                    ImageAddress = "~/assets/img/user/1.jpg"
                }
            });
        }
    }
}
