using MaktabNews.Domain.Core.Dtos.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabNews.Domain.Core.Contracts.Services
{
    public interface IReporterServices
    {
        public ReporterSummeryDto GetSummery(int id);
    }
}
