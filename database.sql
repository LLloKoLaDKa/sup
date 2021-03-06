USE [master]
GO
/****** Object:  Database [SUP]    Script Date: 16.12.2021 18:47:55 ******/
CREATE DATABASE [SUP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SUP', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SUP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SUP_log', FILENAME = N'D:\Programs\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SUP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SUP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SUP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SUP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SUP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SUP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SUP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SUP] SET ARITHABORT OFF 
GO
ALTER DATABASE [SUP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SUP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SUP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SUP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SUP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SUP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SUP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SUP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SUP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SUP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SUP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SUP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SUP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SUP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SUP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SUP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SUP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SUP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SUP] SET  MULTI_USER 
GO
ALTER DATABASE [SUP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SUP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SUP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SUP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SUP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SUP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SUP] SET QUERY_STORE = OFF
GO
USE [SUP]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[SecondName] [varchar](50) NULL,
	[LastName] [varchar](50) NOT NULL,
	[Type] [uniqueidentifier] NOT NULL,
	[IsRemoved] [bit] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTypes]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[IsRemoved] [bit] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectWorks]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectWorks](
	[Id] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
	[EmployeeId] [uniqueidentifier] NOT NULL,
	[DateStart] [datetime] NOT NULL,
	[DateEnd] [datetime] NULL,
 CONSTRAINT [PK_ProjectWorks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[Id] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](max) NULL,
	[PerformerId] [uniqueidentifier] NULL,
	[TesterId] [uniqueidentifier] NULL,
	[State] [uniqueidentifier] NOT NULL,
	[IsRemoved] [bit] NOT NULL,
	[NumberTask] [int] NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskStates]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskStates](
	[Id] [uniqueidentifier] NOT NULL,
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TaskStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacations]    Script Date: 16.12.2021 18:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacations](
	[Id] [uniqueidentifier] NOT NULL,
	[EmployeeId] [uniqueidentifier] NOT NULL,
	[DateStart] [datetime] NOT NULL,
	[DateEnd] [datetime] NOT NULL,
	[Comment] [varchar](max) NULL,
	[IsRemoved] [bit] NOT NULL,
 CONSTRAINT [PK_Vacations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'55a92828-b1d9-4c8b-9835-0c417252a11c', N'Александр', NULL, N'Муравлюк', N'b6c90d1c-6055-4023-b957-6c6f193eb261', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'9eafae6e-510d-4497-850d-0e5c813a5d7f', N'Анастасия', NULL, N'Гостева', N'b6c90d1c-6055-4023-b957-6c6f193eb261', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'3f50d676-d42e-42db-8574-5890303fa00b', N'Иван', NULL, N'Гаврилов', N'ee2553f9-7206-4de1-a1f7-0a6d822af245', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'd87eb291-f3b5-4811-a673-595fe467cfd2', N'Вадим', NULL, N'Аминов', N'b6c90d1c-6055-4023-b957-6c6f193eb261', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'e5d02e76-f7e8-409f-9c17-9d5eadf2a6c3', N'Виталий', N'Сергеевич', N'Иванов', N'a38c5681-0320-4cd5-b6da-1065c37730a0', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'df39a26a-f109-4cbc-8592-bd809082cd47', N'Яков', NULL, N'Ржаной', N'b6c90d1c-6055-4023-b957-6c6f193eb261', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'8cd2afbf-d772-4da9-9e58-c3a336b93a8a', N'Дмитрий', NULL, N'Пирзяев', N'ee2553f9-7206-4de1-a1f7-0a6d822af245', 0)
INSERT [dbo].[Employees] ([Id], [FirstName], [SecondName], [LastName], [Type], [IsRemoved]) VALUES (N'1c6e26cf-fe8e-4fd6-9923-d15dc5782bd4', N'Алексей', NULL, N'Туленков', N'ee2553f9-7206-4de1-a1f7-0a6d822af245', 0)
GO
INSERT [dbo].[EmployeeTypes] ([Id], [Title], [Salary]) VALUES (N'ee2553f9-7206-4de1-a1f7-0a6d822af245', N'Senior Full-Stack', 100000)
INSERT [dbo].[EmployeeTypes] ([Id], [Title], [Salary]) VALUES (N'a38c5681-0320-4cd5-b6da-1065c37730a0', N'Junior Full-Stack', 50000)
INSERT [dbo].[EmployeeTypes] ([Id], [Title], [Salary]) VALUES (N'b6c90d1c-6055-4023-b957-6c6f193eb261', N'Middle Full-Stack', 70000)
GO
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'9ab3ad44-0e67-4cfe-a622-1c735ed6810c', N'Комета', N'комета', 1)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'GetBrokers', N'Система для брокера', 0)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'24d8d1bf-df68-496d-a527-4475a5acc0cd', N'PelletsDelivery', N'Доставка пеллет', 0)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'92d38904-7717-447a-8da7-45adb1aecabc', N'SMMS', N'Система управления соц. сетями', 0)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'85f3027a-1bd4-4eac-90c5-522211c31ff5', N'WaterIS', N'Доставка воды', 0)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'd4f75d6d-8eaa-4d55-ab98-7314f18831d9', N'Комета', N'Система для спортивного комплекса', 1)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'9dbbe7b5-57bb-437b-9a54-b66e32998845', N'Kometa', N'Спортивный компекс', 1)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'11d1dbda-dccb-449f-bd81-d4ae1a2cb1e7', N'Levsha', N'Интернет-магазин материалов', 0)
INSERT [dbo].[Projects] ([Id], [Name], [Description], [IsRemoved]) VALUES (N'7532028a-00de-4216-9691-fc55254413f2', N'Rollex', N'Суши и роллы', 0)
GO
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'03abd106-6873-4325-95ac-20b0f8fb350a', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'e5d02e76-f7e8-409f-9c17-9d5eadf2a6c3', CAST(N'2021-12-08T20:50:52.787' AS DateTime), NULL)
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'b6c6f9fd-c692-4070-a8be-35903dd59311', N'9dbbe7b5-57bb-437b-9a54-b66e32998845', N'1c6e26cf-fe8e-4fd6-9923-d15dc5782bd4', CAST(N'2021-12-05T18:41:02.727' AS DateTime), CAST(N'2021-12-05T18:41:44.010' AS DateTime))
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'fdb6c99a-24f5-424e-b034-898276546039', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'8cd2afbf-d772-4da9-9e58-c3a336b93a8a', CAST(N'2021-12-05T18:14:13.043' AS DateTime), NULL)
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'd761a7c3-4f79-4c18-922d-89ead9859681', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'3f50d676-d42e-42db-8574-5890303fa00b', CAST(N'2021-12-05T18:16:00.363' AS DateTime), NULL)
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'0edae60a-358e-4399-ade5-982281305537', N'9dbbe7b5-57bb-437b-9a54-b66e32998845', N'1c6e26cf-fe8e-4fd6-9923-d15dc5782bd4', CAST(N'2021-12-05T18:37:38.217' AS DateTime), CAST(N'2021-12-05T18:40:19.380' AS DateTime))
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'06d6bdb6-79b4-4d77-b562-af0c164cbc63', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'e5d02e76-f7e8-409f-9c17-9d5eadf2a6c3', CAST(N'2021-12-05T18:23:37.537' AS DateTime), CAST(N'2021-12-08T20:48:57.703' AS DateTime))
INSERT [dbo].[ProjectWorks] ([Id], [ProjectId], [EmployeeId], [DateStart], [DateEnd]) VALUES (N'28ff0d5f-fae8-484d-b7ce-fc5cf5c84c3e', N'24d8d1bf-df68-496d-a527-4475a5acc0cd', N'e5d02e76-f7e8-409f-9c17-9d5eadf2a6c3', CAST(N'2021-12-05T18:00:24.897' AS DateTime), NULL)
GO
INSERT [dbo].[Tasks] ([Id], [ProjectId], [Title], [Description], [PerformerId], [TesterId], [State], [IsRemoved], [NumberTask]) VALUES (N'543324f7-0ab1-4a61-8b50-28daf3905423', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'Фьючерсы', N'Добавить новый тип бумаг', N'8cd2afbf-d772-4da9-9e58-c3a336b93a8a', NULL, N'a95103de-0215-45ba-abf4-d76754d388c1', 0, 3)
INSERT [dbo].[Tasks] ([Id], [ProjectId], [Title], [Description], [PerformerId], [TesterId], [State], [IsRemoved], [NumberTask]) VALUES (N'cfc1d58a-0825-44cf-adc2-5c45709926b7', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'Тестовая', N'тест', NULL, NULL, N'a95103de-0215-45ba-abf4-d76754d388c1', 1, 4)
INSERT [dbo].[Tasks] ([Id], [ProjectId], [Title], [Description], [PerformerId], [TesterId], [State], [IsRemoved], [NumberTask]) VALUES (N'3b3995a5-7f10-4e3c-b02e-60653894c265', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'Пользователи', N'Справочник пользователей', N'3f50d676-d42e-42db-8574-5890303fa00b', N'3f50d676-d42e-42db-8574-5890303fa00b', N'6a81d05e-ee85-4446-895a-b07019dcf0b3', 0, 2)
INSERT [dbo].[Tasks] ([Id], [ProjectId], [Title], [Description], [PerformerId], [TesterId], [State], [IsRemoved], [NumberTask]) VALUES (N'd1236a35-768d-4864-80d2-7712c10af1a6', N'a6a1d332-4299-456c-8e2e-1d53fb754922', N'Авторизация', N'Добавить атрибут авторизации', N'3f50d676-d42e-42db-8574-5890303fa00b', NULL, N'a95103de-0215-45ba-abf4-d76754d388c1', 0, 1)
INSERT [dbo].[Tasks] ([Id], [ProjectId], [Title], [Description], [PerformerId], [TesterId], [State], [IsRemoved], [NumberTask]) VALUES (N'5dfe8e0b-7edd-4d50-b52e-b48fe529ffbf', N'9dbbe7b5-57bb-437b-9a54-b66e32998845', N'тестовая', N'тест', N'1c6e26cf-fe8e-4fd6-9923-d15dc5782bd4', N'1c6e26cf-fe8e-4fd6-9923-d15dc5782bd4', N'a95103de-0215-45ba-abf4-d76754d388c1', 1, 1)
GO
INSERT [dbo].[TaskStates] ([Id], [State]) VALUES (N'6a81d05e-ee85-4446-895a-b07019dcf0b3', N'Завершено')
INSERT [dbo].[TaskStates] ([Id], [State]) VALUES (N'a95103de-0215-45ba-abf4-d76754d388c1', N'Бэклог')
INSERT [dbo].[TaskStates] ([Id], [State]) VALUES (N'53b8db15-40e2-4bfa-aecd-ebd7029dd0fc', N'В работе')
GO
INSERT [dbo].[Vacations] ([Id], [EmployeeId], [DateStart], [DateEnd], [Comment], [IsRemoved]) VALUES (N'e6865267-50f3-439d-bec0-0ff380f69e1e', N'1c6e26cf-fe8e-4fd6-9923-d15dc5782bd4', CAST(N'2021-12-13T00:00:00.000' AS DateTime), CAST(N'2021-12-17T00:00:00.000' AS DateTime), N'Причина: 5 дней', 0)
INSERT [dbo].[Vacations] ([Id], [EmployeeId], [DateStart], [DateEnd], [Comment], [IsRemoved]) VALUES (N'c3c86b7f-b657-4c37-9a37-31e070427f50', N'e5d02e76-f7e8-409f-9c17-9d5eadf2a6c3', CAST(N'2021-12-04T17:41:53.673' AS DateTime), CAST(N'2021-12-18T17:41:53.673' AS DateTime), N'Тестовый отпуск', 1)
INSERT [dbo].[Vacations] ([Id], [EmployeeId], [DateStart], [DateEnd], [Comment], [IsRemoved]) VALUES (N'61c3d964-93bf-44a5-83c2-77be194db7ce', N'e5d02e76-f7e8-409f-9c17-9d5eadf2a6c3', CAST(N'2021-12-29T00:00:00.000' AS DateTime), CAST(N'2021-12-30T00:00:00.000' AS DateTime), N'Учебный отпуск', 0)
INSERT [dbo].[Vacations] ([Id], [EmployeeId], [DateStart], [DateEnd], [Comment], [IsRemoved]) VALUES (N'c1cbdb26-9604-48b2-8a6d-be88e9292739', N'df39a26a-f109-4cbc-8592-bd809082cd47', CAST(N'2021-12-04T17:26:24.527' AS DateTime), CAST(N'2021-12-18T17:26:24.527' AS DateTime), N'Ежегодный отпуск', 0)
GO
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [DF_Employees_IsRemoved]  DEFAULT ((0)) FOR [IsRemoved]
GO
ALTER TABLE [dbo].[Projects] ADD  CONSTRAINT [DF_Projects_isremoved]  DEFAULT ((0)) FOR [IsRemoved]
GO
ALTER TABLE [dbo].[Tasks] ADD  CONSTRAINT [DF_Tasks_isremoved]  DEFAULT ((0)) FOR [IsRemoved]
GO
ALTER TABLE [dbo].[Vacations] ADD  CONSTRAINT [DF_Vacations_isremoved]  DEFAULT ((0)) FOR [IsRemoved]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_EmployeeTypes] FOREIGN KEY([Type])
REFERENCES [dbo].[EmployeeTypes] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_EmployeeTypes]
GO
ALTER TABLE [dbo].[ProjectWorks]  WITH CHECK ADD  CONSTRAINT [FK_ProjectWorks_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[ProjectWorks] CHECK CONSTRAINT [FK_ProjectWorks_Employees]
GO
ALTER TABLE [dbo].[ProjectWorks]  WITH CHECK ADD  CONSTRAINT [FK_ProjectWorks_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
GO
ALTER TABLE [dbo].[ProjectWorks] CHECK CONSTRAINT [FK_ProjectWorks_Projects]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Performer] FOREIGN KEY([PerformerId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Performer]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Projects]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_TaskStates] FOREIGN KEY([State])
REFERENCES [dbo].[TaskStates] ([Id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_TaskStates]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Tester] FOREIGN KEY([TesterId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Tester]
GO
ALTER TABLE [dbo].[Vacations]  WITH CHECK ADD  CONSTRAINT [FK_Vacations_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Vacations] CHECK CONSTRAINT [FK_Vacations_Employees]
GO
USE [master]
GO
ALTER DATABASE [SUP] SET  READ_WRITE 
GO
