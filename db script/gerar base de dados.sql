USE [Estudos]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 02/06/2020 22:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 02/06/2020 22:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[AuthorId] [int] NOT NULL
) ON [PRIMARY]
GO

USE [Estudos]
GO

insert into Author (Id, Name, Email)
values
(1,'author_01','author_01@example.com'),
(2,'author_02','author_02@example.com'),
(3,'author_03','author_03@example.com'),
(4,'author_04','author_04@example.com'),
(5,'author_05','author_05@example.com')
go