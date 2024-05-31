using MaktabNews.Domain.Core.Dtos.Reporter;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabNews.Domain.Core.Contracts.Services
{
    public interface IReporterServices
    {
        Task<ReporterSummeryDto> GetSummery(int id, CancellationToken cancellationToken);
        Task Update(UpdateReporterDto model, CancellationToken cancellationToken);
        Task<string> UploadImageProfile(IFormFile FormFile, CancellationToken cancellationToken);
    }
}
