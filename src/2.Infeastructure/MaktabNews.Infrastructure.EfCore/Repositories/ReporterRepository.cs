using MaktabNews.Domain.Core.Contracts.Repository;
using MaktabNews.Domain.Core.Dtos.Reporter;
using MaktabNews.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ReporterSummeryDto> GetSummery(int id,CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Reporters
                .Include(x=>x.ApplicationUser)
                .Where(x=>x.ApplicationUser.Id == id)
                .Select(x => new ReporterSummeryDto
                {
                    Id = x.ApplicationUserId,
                    FullName = x.FullName,
                    AboutMe = x.AboutMe,
                    ImageAddress = x.ImageAddress,
                    Address = x.Address

                }).FirstOrDefaultAsync(cancellationToken);

            return result ?? new ReporterSummeryDto();
        }

        public async Task Update(UpdateReporterDto model,CancellationToken cancellationToken)
        {
            var reporter = await _appDbContext.Reporters
                .FirstOrDefaultAsync(x => x.ApplicationUserId == model.AppUserId, cancellationToken);

            if (reporter != null)
            {
                reporter.FullName = model.FullName;
                reporter.AboutMe = model.AboutMe;
                reporter.ImageAddress = model.ImageAddress;
                reporter.Address = model.Address;
            }

            await _appDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
