using MaktabNew.Domain.Core.Enum;
using MaktabNews.Domain.Core.Entities;
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
                    ImageAddress = "/assets/img/author/1.jpg",
                    Address = "تهران، خیابان بهشتی",
                    AboutMe = "من دیوید اسمیت هستم، شوهر و پدر، عاشق عکاسی، سفر و طبیعت هستم. من به عنوان نویسنده و وبلاگ نویس با 5 سال سابقه کار می کنم."
                },
                new Reporter()
                {
                    Id = 3,
                    FullName = "سحر رمضانی",
                    ImageAddress = "/assets/img/author/2.jpg",
                    Address = "تهران، خیابان بهشتی",
                    AboutMe = "من دیوید اسمیت هستم، شوهر و پدر، عاشق عکاسی، سفر و طبیعت هستم. من به عنوان نویسنده و وبلاگ نویس با 5 سال سابقه کار می کنم."
                },
                new Reporter()
                {
                    Id = 4,
                    FullName = "مریم اکبری",
                    ImageAddress = "/assets/img/author/3.jpg",
                    Address = "تهران، خیابان بهشتی",
                    AboutMe = "من دیوید اسمیت هستم، شوهر و پدر، عاشق عکاسی، سفر و طبیعت هستم. من به عنوان نویسنده و وبلاگ نویس با 5 سال سابقه کار می کنم."
                },

            });
        }
    }
}
