using Article.Model.ArticleRequest;
using Article.Service.Article;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Article.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class ArticleController : ControllerBase
	{
		private readonly IArticleService _articleService;
		public ArticleController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		[HttpGet("get-article-list")]
		public IActionResult GetArticleList()
		{
			var articleList = _articleService.ArticleList();

			if (articleList.Any())
			{
				return Ok(articleList);
			}

			return BadRequest();
		}

		[Produces("application/json")]
		[HttpGet("search/{articleId}")]
		public IActionResult ArticleSearch(int articleId)
		{
			try
			{
				var articleSearch = _articleService.ArticleSearch(articleId);
				return Ok(articleSearch);

			}
			catch (Exception)
			{

				return BadRequest();
			}

		}
		[Consumes("application/json")]
		[Produces("application/json")]
		[HttpPost("create")]
		public IActionResult ArticleInsert([FromBody] ArticleResponse _articleResponse)
		{
			try
			{
				_articleService.ArticleInsert(_articleResponse);

				return Ok();
			}
			catch (Exception)
			{
				return BadRequest();
			}

		}

		[Consumes("application/json")]
		[Produces("application/json")]
		[HttpPut("update/{articleId}")]
		public IActionResult ArticleUpdate(int articleId, ArticleResponse _articleResponse)
		{
			try
			{
				_articleService.ArticleUpdate(articleId, _articleResponse);
				return Ok();
			}
			catch (Exception)
			{
				return BadRequest();
			}

		}

		[Consumes("application/json")]
		[Produces("application/json")]
		[HttpDelete("delete")]
		public IActionResult ArticleDelete(int articleId)
		{
			try
			{
				_articleService.ArticleDelete(articleId);
				return Ok();
			}
			catch (Exception)
			{
				return BadRequest();
			}

		}
	}
}
