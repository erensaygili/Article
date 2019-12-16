using Article.Model.ArticleRequest;
using System;
using System.Collections.Generic;

namespace Article.Service.Article
{
	public interface IArticleService
	{
		List<ArticleResponse> ArticleList();
		bool ArticleUpdate(int articleId, ArticleResponse _articleResponse);
		bool ArticleInsert(ArticleResponse _articleResponse);
		bool ArticleDelete(int articleId);
		ArticleRequest ArticleSearch(int articleId);
	}
}
