using Article.Entity.Core;
using Article.Model.ArticleRequest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Article.Repository
{
	public class ArticleRepository : IArticleRepository
	{
		private readonly DigiArticleContext _context;

		public ArticleRepository(DigiArticleContext context)
		{
			_context = context;
		}


		public bool ArticleInsert(ArticleResponse _articleResponse)
		{
			var articleInsert = new Article.Entity.Model.Article()
			{
				ArticleId = _articleResponse.ArticleId,
				ArticleContent = _articleResponse.ArticleContent,
				CategoryId = _articleResponse.CategoryId,
				CreateDate = _articleResponse.CreateDate,
				CreateUserId = _articleResponse.CreateUserId,
				IsActive = _articleResponse.IsActive,
				Title = _articleResponse.Title,
				UpdateDate = _articleResponse.UpdateDate,
				UpdateUserId = _articleResponse.UpdateUserId,
				UserId = _articleResponse.UserId,
			};

			_context.Article.Add(articleInsert);
			_context.SaveChanges();

			return true;
		}

		public List<ArticleResponse> ArticleList()
		{
			var list = _context.Article;

			return list.Select(s => new ArticleResponse
			{
				ArticleContent = s.ArticleContent,
				ArticleId = s.ArticleId,
				CategoryId = s.CategoryId,
				CreateDate = s.CreateDate,
				CreateUserId = s.CreateUserId,
				IsActive = s.IsActive,
				Title = s.Title,
				UpdateDate = s.UpdateDate,
				UpdateUserId = s.UpdateUserId,
				UserId = s.UserId
			})
			.ToList();
		}

		public Article.Entity.Model.Article ArticleSearch(int articleId)
		{
			var search = _context.Article.Where(s => s.ArticleId == articleId).Select(s => new Article.Entity.Model.Article()
			{ 
				ArticleContent = s.ArticleContent,
				ArticleId = s.ArticleId,
				CategoryId = s.CategoryId,
				CreateDate = s.CreateDate,
				CreateUserId = s.CreateUserId,
				IsActive = s.IsActive,
				Title = s.Title,
				UpdateDate = s.UpdateDate,
				UpdateUserId = s.UpdateUserId,
				UserId = s.UserId
			}).SingleOrDefault();

			return search;
		}

		public bool ArticleUpdate(int id, ArticleResponse _articleResponse)
		{
			var updateArticle = _context.Article.FirstOrDefault(s => s.ArticleId == id);
			updateArticle.ArticleId = _articleResponse.ArticleId;
			updateArticle.Title = _articleResponse.Title;
			updateArticle.ArticleContent = _articleResponse.ArticleContent;
			updateArticle.CategoryId = _articleResponse.CategoryId;
			updateArticle.UserId = _articleResponse.UserId;
			updateArticle.IsActive = _articleResponse.IsActive;
			updateArticle.CreateDate = _articleResponse.CreateDate;
			updateArticle.UpdateDate = _articleResponse.UpdateDate;
			updateArticle.CreateUserId = _articleResponse.CreateUserId;
			updateArticle.UpdateUserId = _articleResponse.UpdateUserId;
			_context.SaveChanges();
			return true;
		}

		public bool ArticleDelete(int articleId)
		{
			var delete = _context.Article.Find(articleId);
			_context.Article.Remove(delete);
			_context.SaveChanges();
			return true;
		}
	}
}
