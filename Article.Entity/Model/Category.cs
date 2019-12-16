using System;
using System.Collections.Generic;

namespace Article.Entity.Model
{
    public partial class Category
    {
        public Category()
        {
            Article = new HashSet<Article>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<Article> Article { get; set; }
    }
}
