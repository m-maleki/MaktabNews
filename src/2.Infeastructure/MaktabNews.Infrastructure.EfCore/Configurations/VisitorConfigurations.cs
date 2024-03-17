using MaktabNew.Domain.Core.Entities;
using MaktabNew.Domain.Core.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabNews.Infrastructure.EfCore.Configurations
{
    public class VisitorConfigurations : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {
            builder.HasData(new List<Visitor>()
            {
                new Visitor()
                {
                    Id = 4,
                    FullName = "علی محمدی",
                    Email = "Ali.Mohammadi@Gmail.com",
                    Password = "1qaz!QAZ",
                    UserRole = UserRole.Visitor,
                    ImageAddress = "~/assets/img/user/2.jpg"
                }
            });
        }
    }
}
