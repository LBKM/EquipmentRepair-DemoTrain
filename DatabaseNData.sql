USE [master]
GO
/****** Object:  Database [EquipmentRepair]    Script Date: 11.06.2024 0:06:37 ******/
CREATE DATABASE [EquipmentRepair]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EquipmentRepair', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EquipmentRepair.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EquipmentRepair_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EquipmentRepair_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EquipmentRepair] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EquipmentRepair].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EquipmentRepair] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EquipmentRepair] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EquipmentRepair] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EquipmentRepair] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EquipmentRepair] SET ARITHABORT OFF 
GO
ALTER DATABASE [EquipmentRepair] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EquipmentRepair] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EquipmentRepair] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EquipmentRepair] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EquipmentRepair] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EquipmentRepair] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EquipmentRepair] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EquipmentRepair] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EquipmentRepair] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EquipmentRepair] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EquipmentRepair] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EquipmentRepair] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EquipmentRepair] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EquipmentRepair] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EquipmentRepair] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EquipmentRepair] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EquipmentRepair] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EquipmentRepair] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EquipmentRepair] SET  MULTI_USER 
GO
ALTER DATABASE [EquipmentRepair] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EquipmentRepair] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EquipmentRepair] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EquipmentRepair] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EquipmentRepair] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EquipmentRepair] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EquipmentRepair] SET QUERY_STORE = OFF
GO
USE [EquipmentRepair]
GO
/****** Object:  Table [dbo].[Assignments]    Script Date: 11.06.2024 0:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Request_ID] [int] NOT NULL,
	[Executor_ID] [int] NOT NULL,
	[Date_Assigned] [datetime] NOT NULL,
	[Date_Completed] [datetime] NULL,
 CONSTRAINT [PK__Assignme__3214EC27343B9F84] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 11.06.2024 0:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Middle_Name] [varchar](50) NULL,
	[Contact_Info] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Clients__3214EC276CBBA262] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 11.06.2024 0:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Serial_Number] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Equipmen__3214EC27F01723DB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Executors]    Script Date: 11.06.2024 0:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Executors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Middle_Name] [varchar](50) NULL,
	[Contact_Info] [varchar](255) NOT NULL,
	[Position] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Executor__3214EC273A49EE41] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 11.06.2024 0:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date_Added] [datetime] NOT NULL,
	[Equipment_ID] [int] NOT NULL,
	[Malfunction_Type] [varchar](50) NOT NULL,
	[Problem_Description] [text] NOT NULL,
	[Client_ID] [int] NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Requests__3214EC27FB2C6782] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.06.2024 0:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](128) NOT NULL,
	[Role] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Users__3214EC275508193C] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Assignments] ON 

INSERT [dbo].[Assignments] ([ID], [Request_ID], [Executor_ID], [Date_Assigned], [Date_Completed]) VALUES (1, 1, 1, CAST(N'2024-06-08T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Assignments] ([ID], [Request_ID], [Executor_ID], [Date_Assigned], [Date_Completed]) VALUES (2, 2, 2, CAST(N'2024-06-08T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Assignments] ([ID], [Request_ID], [Executor_ID], [Date_Assigned], [Date_Completed]) VALUES (3, 3, 3, CAST(N'2024-06-08T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Assignments] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [Last_Name], [First_Name], [Middle_Name], [Contact_Info]) VALUES (1, N'Иванов', N'Иван', N'Иванович', N'+7 (123) 456-78-90')
INSERT [dbo].[Clients] ([ID], [Last_Name], [First_Name], [Middle_Name], [Contact_Info]) VALUES (2, N'Петров', N'Петр', N'Петрович', N'+7 (987) 654-32-10')
INSERT [dbo].[Clients] ([ID], [Last_Name], [First_Name], [Middle_Name], [Contact_Info]) VALUES (3, N'Сидоров', N'Александр', N'Викторович', N'+7 (456) 123-90-78')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipment] ON 

INSERT [dbo].[Equipment] ([ID], [Name], [Serial_Number], [Type]) VALUES (1, N'Принтер', N'ABC123', N'Офисное оборудование')
INSERT [dbo].[Equipment] ([ID], [Name], [Serial_Number], [Type]) VALUES (2, N'Сварочный аппарат', N'DEF456', N'Промышленное оборудование')
INSERT [dbo].[Equipment] ([ID], [Name], [Serial_Number], [Type]) VALUES (3, N'Ноутбук', N'GHI789', N'Компьютерная техника')
SET IDENTITY_INSERT [dbo].[Equipment] OFF
GO
SET IDENTITY_INSERT [dbo].[Executors] ON 

INSERT [dbo].[Executors] ([ID], [Last_Name], [First_Name], [Middle_Name], [Contact_Info], [Position]) VALUES (1, N'Смирнов', N'Алексей', N'Алексеевич', N'+7 (789) 321-65-40', N'Мастер по ремонту офисной техники')
INSERT [dbo].[Executors] ([ID], [Last_Name], [First_Name], [Middle_Name], [Contact_Info], [Position]) VALUES (2, N'Кузнецов', N'Максим', N'Максимович', N'+7 (654) 907-88-77', N'Сварщик')
INSERT [dbo].[Executors] ([ID], [Last_Name], [First_Name], [Middle_Name], [Contact_Info], [Position]) VALUES (3, N'Попов', N'Дмитрий', N'Андреевич', N'+7 (321) 654-99-88', N'Системный администратор')
SET IDENTITY_INSERT [dbo].[Executors] OFF
GO
SET IDENTITY_INSERT [dbo].[Requests] ON 

INSERT [dbo].[Requests] ([ID], [Date_Added], [Equipment_ID], [Malfunction_Type], [Problem_Description], [Client_ID], [Status]) VALUES (1, CAST(N'2024-06-08T00:00:00.000' AS DateTime), 1, N'F gkxve&&&', N'F gkxve&&&', 1, N'F gkxve&&&')
INSERT [dbo].[Requests] ([ID], [Date_Added], [Equipment_ID], [Malfunction_Type], [Problem_Description], [Client_ID], [Status]) VALUES (2, CAST(N'2024-06-08T00:00:00.000' AS DateTime), 2, N'Электрическая', N'Не загорается дуга', 2, N'в ожидании')
INSERT [dbo].[Requests] ([ID], [Date_Added], [Equipment_ID], [Malfunction_Type], [Problem_Description], [Client_ID], [Status]) VALUES (3, CAST(N'2024-06-08T00:00:00.000' AS DateTime), 3, N'пися попа', N'пися попа', 3, N'пися попа')
INSERT [dbo].[Requests] ([ID], [Date_Added], [Equipment_ID], [Malfunction_Type], [Problem_Description], [Client_ID], [Status]) VALUES (4, CAST(N'2024-06-01T00:00:00.000' AS DateTime), 2, N'Механическая', N'dfgdfgfd', 2, N'ого!!!')
INSERT [dbo].[Requests] ([ID], [Date_Added], [Equipment_ID], [Malfunction_Type], [Problem_Description], [Client_ID], [Status]) VALUES (5, CAST(N'2024-06-10T00:00:00.000' AS DateTime), 2, N'Механическая', N'dfdsf', 2, N'juj!!!')
INSERT [dbo].[Requests] ([ID], [Date_Added], [Equipment_ID], [Malfunction_Type], [Problem_Description], [Client_ID], [Status]) VALUES (7, CAST(N'2024-06-02T00:00:00.000' AS DateTime), 2, N'не пон', N'не пон', 1, N'не пон')
SET IDENTITY_INSERT [dbo].[Requests] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Login], [Password], [Role]) VALUES (1, N'admin', N'admin_password', N'администратор')
INSERT [dbo].[Users] ([ID], [Login], [Password], [Role]) VALUES (2, N'manager', N'manager_password', N'менеджер')
INSERT [dbo].[Users] ([ID], [Login], [Password], [Role]) VALUES (3, N'executor', N'executor_password', N'исполнитель')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__5E55825B59F8C8D0]    Script Date: 11.06.2024 0:06:37 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UQ__Users__5E55825B59F8C8D0] UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Assignments]  WITH CHECK ADD  CONSTRAINT [FK__Assignmen__Execu__412EB0B6] FOREIGN KEY([Executor_ID])
REFERENCES [dbo].[Executors] ([ID])
GO
ALTER TABLE [dbo].[Assignments] CHECK CONSTRAINT [FK__Assignmen__Execu__412EB0B6]
GO
ALTER TABLE [dbo].[Assignments]  WITH CHECK ADD  CONSTRAINT [FK__Assignmen__Reque__403A8C7D] FOREIGN KEY([Request_ID])
REFERENCES [dbo].[Requests] ([ID])
GO
ALTER TABLE [dbo].[Assignments] CHECK CONSTRAINT [FK__Assignmen__Reque__403A8C7D]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK__Requests__Client__3B75D760] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK__Requests__Client__3B75D760]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK__Requests__Equipm__3A81B327] FOREIGN KEY([Equipment_ID])
REFERENCES [dbo].[Equipment] ([ID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK__Requests__Equipm__3A81B327]
GO
USE [master]
GO
ALTER DATABASE [EquipmentRepair] SET  READ_WRITE 
GO
