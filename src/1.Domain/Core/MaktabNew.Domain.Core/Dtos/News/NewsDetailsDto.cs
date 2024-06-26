﻿using MaktabNews.Domain.Core.Dtos.Comment;

namespace MaktabNews.Domain.Core.Dtos.News
{
    public class NewsDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ReporterName { get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateAtFa { get; set; }
        public string NewsImageAddress { get; set; }
        public string ReporterImageAddress { get; set; }
        public List<Entities.Tag> Tags { get; set; } = new List<Entities.Tag>();
        public List<CommentViewDto> Comments { get; set; } = new List<CommentViewDto>();
        public int ReporterId { get; set; }
    }
}
