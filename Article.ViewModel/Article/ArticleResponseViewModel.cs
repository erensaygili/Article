using Article.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.ViewModel.ArticleViewModel
{
	public class ArticleResponseViewModel
	{
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
		 
	}
}
