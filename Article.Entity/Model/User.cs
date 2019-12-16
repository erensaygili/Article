using System;
using System.Collections.Generic;

namespace Article.Entity.Model
{
    public partial class User
    {
        public User()
        {
            Article = new HashSet<Article>();
            Comment = new HashSet<Comment>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? CreateUserId { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<Article> Article { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
