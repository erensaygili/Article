using System;
using System.Collections.Generic;

namespace Article.Entity.Model
{
    public partial class ArticleTag
    {
        public int ArticleTagId { get; set; }
        public int? ArticleId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual Article Article { get; set; }
    }
}
