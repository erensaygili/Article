using System;
using System.Collections.Generic;

namespace Article.Entity.Model
{
    public partial class Article
    {
        public Article()
        {
            ArticleTag = new HashSet<ArticleTag>();
            Comment = new HashSet<Comment>();
        }

        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public int? CategoryId { get; set; }
        public int? UserId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ArticleTag> ArticleTag { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
