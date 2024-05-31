using MaktabNew.Domain.Core.Enum;
using MaktabNews.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabNews.Infrastructure.EfCore.Configurations
{
    public class VisitorConfigurations : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {

            builder.HasMany(x => x.Comments)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.VisitorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.ApplicationUser)
                .WithOne(x => x.Visitor);


            builder.HasData(new List<Visitor>()
            {
                new Visitor()
                {
                    Id = 4,
                    FullName = "مریم اکبری",
                    ImageAddress = "/assets/img/author/3.jpg",
                    Address = "تهران، خیابان بهشتی",
                    AboutMe = "من دیوید اسمیت هستم، شوهر و پدر، عاشق عکاسی، سفر و طبیعت هستم. من به عنوان نویسنده و وبلاگ نویس با 5 سال سابقه کار می کنم.",
                    ApplicationUserId = 4
                }
            });
        }
    }
}
