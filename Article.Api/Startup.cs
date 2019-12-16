using Article.Common;
using Article.Entity.Core;
using Article.Repository;
using Article.Service.Article;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Article.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DigiArticleContext>(options => options.UseSqlServer(
				Configuration.GetConnectionString(ProjectConst.ConnectionString.EntityConnectionString)));

			services.AddSingleton(Configuration);

			services.AddScoped<IDataContext, DataContext>();
			services.AddScoped<IArticleService, ArticleService>();
			services.AddScoped<IArticleRepository, ArticleRepository>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
			services.AddCors();

			services.AddSwaggerGen((options) =>
			{
				options.SwaggerDoc("v1", new Info { Title = "Article Api", Version = "V1" });
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{

			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Article");
			});
		 
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}


			app.UseMvc();
		}
	}
}
