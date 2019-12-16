using Article.Model.ArticleRequest;
using System;
using System.Collections.Generic;

namespace Article.Repository
{
	public interface IArticleRepository
	{
		List<ArticleResponse> ArticleList();
		bool ArticleUpdate(int articleId, ArticleResponse _articleResponse);
		bool ArticleInsert(ArticleResponse _articleResponse);
		bool ArticleDelete(int articleId);
		Article.Entity.Model.Article ArticleSearch(int articleId);
		 
	}
}
