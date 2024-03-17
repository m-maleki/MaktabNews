using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabNews.Domain.Core.Dtos.News
{
    public class NewsRecentDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateAt { get; set; }
        public string ImageAddress { get; set; }
    }
}
