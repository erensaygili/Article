using Article.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Article.Entity.Core
{
	public partial class DigiArticleContext : DbContext
	{
		private readonly DbContextOptions _options;
		

		public DigiArticleContext(DbContextOptions<DigiArticleContext> options)
			: base(options)
		{
			_options = options;
		}

		public virtual DbSet<Article.Entity.Model.Article> Article { get; set; }
		public virtual DbSet<ArticleTag> ArticleTag { get; set; }
		public virtual DbSet<Category> Category { get; set; }
		public virtual DbSet<Comment> Comment { get; set; }
		public virtual DbSet<User> User { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{ 
				optionsBuilder.UseSqlServer("Server=GM-ERENSA-NB;Database=DigiArticle;User Id=eren.saygili;Password=Eds.7171");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Article.Entity.Model.Article>(entity =>
			{
				entity.Property(e => e.CreateDate).HasColumnType("date");

				entity.Property(e => e.Title).HasMaxLength(50);

				entity.Property(e => e.UpdateDate).HasColumnType("date");

				entity.HasOne(d => d.Category)
					.WithMany(p => p.Article)
					.HasForeignKey(d => d.CategoryId)
					.HasConstraintName("FK_Article_Category");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Article)
					.HasForeignKey(d => d.UserId)
					.HasConstraintName("FK_Article_User");
			});

			modelBuilder.Entity<ArticleTag>(entity =>
			{
				entity.Property(e => e.CreateDate).HasColumnType("date");

				entity.Property(e => e.UpdateDate).HasColumnType("date");

				entity.HasOne(d => d.Article)
					.WithMany(p => p.ArticleTag)
					.HasForeignKey(d => d.ArticleId)
					.HasConstraintName("FK_ArticleTag_Article");
			});

			modelBuilder.Entity<Category>(entity =>
			{
				entity.Property(e => e.CategoryName).HasMaxLength(50);

				entity.Property(e => e.CreateDate).HasColumnType("date");

				entity.Property(e => e.UpdateDate).HasColumnType("date");
			});

			modelBuilder.Entity<Comment>(entity =>
			{
				entity.Property(e => e.CreateDate).HasColumnType("date");

				entity.Property(e => e.UpdateDate).HasColumnType("date");

				entity.HasOne(d => d.Article)
					.WithMany(p => p.Comment)
					.HasForeignKey(d => d.ArticleId)
					.HasConstraintName("FK_Comment_Article");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Comment)
					.HasForeignKey(d => d.UserId)
					.HasConstraintName("FK_Comment_User");
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.Property(e => e.CreateDate).HasColumnType("date");

				entity.Property(e => e.Name).HasMaxLength(50);

				entity.Property(e => e.Surname).HasMaxLength(50);

				entity.Property(e => e.UpdateDate).HasColumnType("date");

				entity.Property(e => e.UserName).HasMaxLength(50);
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
} 
