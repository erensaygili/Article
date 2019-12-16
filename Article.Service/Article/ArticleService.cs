using Article.Model.ArticleRequest;
using Article.Repository;
using System;
using System.Collections.Generic;

namespace Article.Service.Article
{
	public class ArticleService : IArticleService
	{
		private readonly IArticleRepository _articleRepository;

		public ArticleService(IArticleRepository articleRepository)
		{
			_articleRepository = articleRepository;
		}

		public List<ArticleResponse> ArticleList()
		{
			return _articleRepository.ArticleList();
		} 
		public bool ArticleUpdate(int articleId, ArticleResponse _articleResponse)
		{
			var update = _articleRepository.ArticleUpdate(articleId, _articleResponse);
			return update;
		}

		public bool ArticleInsert(ArticleResponse _articleResponse)
		{
			return _articleRepository.ArticleInsert(_articleResponse);
		}

		public bool ArticleDelete(int articleId)
		{
			return _articleRepository.ArticleDelete(articleId);
		}

		public ArticleRequest ArticleSearch(int articleId)
		{
			var articleData = _articleRepository.ArticleSearch(articleId);
			ArticleRequest articleRequest = new ArticleRequest();
			articleRequest.ArticleId = articleData.ArticleId;
			articleRequest.ArticleContent = articleData.ArticleContent;
			articleRequest.CategoryId = articleData.CategoryId;
			articleRequest.CreateDate = articleData.CreateDate;
			articleRequest.CreateUserId = articleData.CreateUserId;
			articleRequest.IsActive = articleData.IsActive;
			articleRequest.UpdateDate = articleData.UpdateDate;
			articleRequest.UpdateUserId = articleData.UpdateUserId;
			articleRequest.Title = articleData.Title;

			return articleRequest;
		}
	}
}
