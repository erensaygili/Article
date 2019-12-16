using System;
using System.Collections.Generic;

namespace Article.Entity.Model
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public int? UserId { get; set; }
        public int? ArticleId { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
    }
}
