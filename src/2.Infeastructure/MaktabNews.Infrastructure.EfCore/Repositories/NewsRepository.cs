using Framework;
using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Comment;
using MaktabNews.Domain.Core.Dtos.News;
using MaktabNews.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly AppDbContext _appDbContext;

        public NewsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<NewsSummeryDto> GetAll()
        {

            var result = _appDbContext.News
                .Select(x => new NewsSummeryDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    CategoryName = x.Category.Title,
                    ReporterName = x.Reporter.FullName,
                    CreateAt = x.CreateAt,
                    CreateAtFa = x.CreateAt.ToPersianString("dddd, dd MMMM,yyyy"),
                    NewsImageAddress = x.ImageAddress,
                    ReporterImageAddress = x.Reporter.ImageAddress
                }).ToList();

            return result;
        }

        public NewsDetailsDto GetDetails(int id)
        {
            var result = _appDbContext.News
                .Select(x => new NewsDetailsDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    CategoryName = x.Category.Title,
                    ReporterName = x.Reporter.FullName,
                    CreateAt = x.CreateAt,
                    CreateAtFa = x.CreateAt.ToPersianString("dddd, dd MMMM,yyyy"),
                    NewsImageAddress = x.ImageAddress,
                    ReporterImageAddress = x.Reporter.ImageAddress,
                    Tags = x.Tags,
                    Description = x.Description,
                    ReporterId = x.ReporterId,
                    Comments = x.Comments.Select(x => new CommentViewDto()
                    {
                        Id = x.Id,
                        CreateAt = x.CreateAt,
                        Description = x.Description,
                        VisitorName = x.User.FullName,
                        VisitorImageAddress = x.User.ImageAddress,
                        CreateAtFa = x.CreateAt.ToPersianString("dddd, dd MMMM,yyyy"),
                    }).ToList()
                }).FirstOrDefault(x => x.Id == id);


            if (result is { })
            {
                return result;
            }
            else
            {
                throw new Exception("News not found");
            }
        }

        public List<NewsRecentDto> GetRecent(int count)
        {
            var result = _appDbContext.News
                .Select(x => new NewsRecentDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageAddress = x.ImageAddress,
                    CreateAt = x.CreateAt,
                    CreateAtFa = x.CreateAt.ToPersianString("dddd, dd MMMM,yyyy"),
                })
                .OrderByDescending(x=>x.CreateAt)
                .Take(count)
                .ToList();

            return result;
        }
    }
}
