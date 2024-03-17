using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Reporter;
using MaktabNews.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MaktabNews.Infrastructure.EfCore.Repositories
{
    public class ReporterRepository : IReporterRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReporterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ReporterSummeryDto GetSummery(int id)
        {
            var result = _appDbContext.Reporters
                .Select(x => new ReporterSummeryDto
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    AboutMe = x.AboutMe,
                    ImageAddress = x.ImageAddress
                }).FirstOrDefault(x=>x.Id == id);

            return result ?? new ReporterSummeryDto();
        }
    }
}
