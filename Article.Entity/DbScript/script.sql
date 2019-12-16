USE [DigiArticle]
GO
/****** Object:  User [eren.saygili]    Script Date: 16.12.2019 09:37:36 ******/
CREATE USER [eren.saygili] FOR LOGIN [eren.saygili] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [eren.saygili]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 16.12.2019 09:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[ArticleId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[ArticleContent] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[UserId] [int] NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NOT NULL,
	[CreateUserId] [int] NULL,
	[UpdateUserId] [int] NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArticleTag]    Script Date: 16.12.2019 09:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticleTag](
	[ArticleTagId] [int] IDENTITY(1,1) NOT NULL,
	[ArticleId] [int] NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NOT NULL,
	[CreateUserId] [int] NULL,
	[UpdateUserId] [int] NOT NULL,
 CONSTRAINT [PK_ArticleTag] PRIMARY KEY CLUSTERED 
(
	[ArticleTagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 16.12.2019 09:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NOT NULL,
	[CreateUserId] [int] NULL,
	[UpdateUserId] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 16.12.2019 09:37:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[CommentId] [int] IDENTITY(1,1) NOT NULL,
	[CommentContent] [nvarchar](max) NULL,
	[UserId] [int] NULL,
	[ArticleId] [int] NULL,
	[IsVisible] [bit] NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NOT NULL,
	[CreateUserId] [int] NULL,
	[UpdateUserId] [int] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.12.2019 09:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [date] NULL,
	[UpdateDate] [date] NOT NULL,
	[CreateUserId] [int] NULL,
	[UpdateUserId] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Article] ON 

INSERT [dbo].[Article] ([ArticleId], [Title], [ArticleContent], [CategoryId], [UserId], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (12, N'baslik1', N'yorum1', 1, 7, 1, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 7, 7)
INSERT [dbo].[Article] ([ArticleId], [Title], [ArticleContent], [CategoryId], [UserId], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (13, N'baslik2', N'yorum2', 2, 8, 1, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 8, 8)
INSERT [dbo].[Article] ([ArticleId], [Title], [ArticleContent], [CategoryId], [UserId], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (14, N'baslik3', N'yorum3', 3, 7, 1, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 8, 9)
INSERT [dbo].[Article] ([ArticleId], [Title], [ArticleContent], [CategoryId], [UserId], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (15, N'baslık4', N'yorum4', 4, 9, 0, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 9, 9)
INSERT [dbo].[Article] ([ArticleId], [Title], [ArticleContent], [CategoryId], [UserId], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (16, N'baslık5', N'yorum5', 5, 8, 0, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 8, 7)
SET IDENTITY_INSERT [dbo].[Article] OFF
SET IDENTITY_INSERT [dbo].[ArticleTag] ON 

INSERT [dbo].[ArticleTag] ([ArticleTagId], [ArticleId], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (4, 12, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 7, 7)
INSERT [dbo].[ArticleTag] ([ArticleTagId], [ArticleId], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (6, 13, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 8, 8)
INSERT [dbo].[ArticleTag] ([ArticleTagId], [ArticleId], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (7, 15, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 7, 9)
INSERT [dbo].[ArticleTag] ([ArticleTagId], [ArticleId], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (8, 12, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 9, 7)
SET IDENTITY_INSERT [dbo].[ArticleTag] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (1, N'sağlık', CAST(N'2011-11-11' AS Date), CAST(N'2011-11-11' AS Date), 1, 1)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (2, N'ekonomi', CAST(N'2000-11-12' AS Date), CAST(N'2000-11-12' AS Date), 1, 1)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (3, N'teknoloji', CAST(N'2000-11-12' AS Date), CAST(N'2000-11-12' AS Date), 2, 2)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (4, N'bilim', CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 1, 1)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (5, N'teknoloji', CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 3, 2)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([CommentId], [CommentContent], [UserId], [ArticleId], [IsVisible], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (7, N'Yorum1', 7, 12, 1, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 8, 9)
INSERT [dbo].[Comment] ([CommentId], [CommentContent], [UserId], [ArticleId], [IsVisible], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (8, N'Yorum2', 9, 12, 1, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 7, 9)
INSERT [dbo].[Comment] ([CommentId], [CommentContent], [UserId], [ArticleId], [IsVisible], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (9, N'Yorum3', 10, 15, 0, CAST(N'2011-06-09' AS Date), CAST(N'2011-06-09' AS Date), 7, 8)
SET IDENTITY_INSERT [dbo].[Comment] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [Name], [Surname], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (7, N'eren', N'eren', N'saygılı', 1, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 7, 7)
INSERT [dbo].[User] ([UserId], [UserName], [Name], [Surname], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (8, N'emre', N'emre', N'saygılı', 0, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 7, 7)
INSERT [dbo].[User] ([UserId], [UserName], [Name], [Surname], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (9, N'samet', N'samet', N'ayan', 1, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 8, 8)
INSERT [dbo].[User] ([UserId], [UserName], [Name], [Surname], [IsActive], [CreateDate], [UpdateDate], [CreateUserId], [UpdateUserId]) VALUES (10, N'mustafa', N'mustafa', N'bedir', 0, CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date), 8, 7)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_Category]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_User]
GO
ALTER TABLE [dbo].[ArticleTag]  WITH CHECK ADD  CONSTRAINT [FK_ArticleTag_Article] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Article] ([ArticleId])
GO
ALTER TABLE [dbo].[ArticleTag] CHECK CONSTRAINT [FK_ArticleTag_Article]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Article] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Article] ([ArticleId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Article]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User]
GO
