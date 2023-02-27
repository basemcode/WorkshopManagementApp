
USE [master]
GO

ALTER DATABASE [Workshop] SET COMPATIBILITY_LEVEL = 150
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Workshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Workshop] SET ANSI_NULL_DEFAULT ON
GO

ALTER DATABASE [Workshop] SET ANSI_NULLS ON
GO

ALTER DATABASE [Workshop] SET ANSI_PADDING ON
GO

ALTER DATABASE [Workshop] SET ANSI_WARNINGS ON
GO

ALTER DATABASE [Workshop] SET ARITHABORT ON
GO

ALTER DATABASE [Workshop] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [Workshop] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [Workshop] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [Workshop] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [Workshop] SET CURSOR_DEFAULT  LOCAL
GO

ALTER DATABASE [Workshop] SET CONCAT_NULL_YIELDS_NULL ON
GO

ALTER DATABASE [Workshop] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [Workshop] SET QUOTED_IDENTIFIER ON
GO

ALTER DATABASE [Workshop] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [Workshop] SET  DISABLE_BROKER
GO

ALTER DATABASE [Workshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [Workshop] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [Workshop] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [Workshop] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [Workshop] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [Workshop] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [Workshop] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [Workshop] SET RECOVERY FULL
GO

ALTER DATABASE [Workshop] SET  MULTI_USER
GO

ALTER DATABASE [Workshop] SET PAGE_VERIFY NONE
GO

ALTER DATABASE [Workshop] SET DB_CHAINING OFF
GO

ALTER DATABASE [Workshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO

ALTER DATABASE [Workshop] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO

ALTER DATABASE [Workshop] SET DELAYED_DURABILITY = DISABLED
GO

ALTER DATABASE [Workshop] SET QUERY_STORE = OFF
GO

USE [Workshop]
GO

/****** Object:  Table [dbo].[InitialQuantityOfItems]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Items]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[ReportingPeriods]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[StockIn]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[StockInDetails]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[StockOut]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[StockOutDetails]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Users]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_Delete]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_DeployAllInitialQuantity]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_DeployInitialQuantity]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_Get]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_GetAll]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_GetAllBarcodes]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_GetByBarcode]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_GetCategories]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_GetItemsOfCategory]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_GetSubGroups]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_Insert]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_SetInitialQuantity]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_Update]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spItem_UpdateImage]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockIn_Delete]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockIn_GetAll]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockIn_Insert]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockIn_Update]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockInDetails_Delete]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockInDetails_GetAllDetailsOfStockIn]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockInDetails_Insert]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockOut_Delete]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockOut_GetAll]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockOut_Insert]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockOutDetails_Delete]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockOutDetails_GetAllDetailsOfStockOut]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spStockOutDetails_Insert]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spUsers_Delete]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spUsers_Insert]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spUsers_Login]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spUsers_Select]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[spUsers_Update]    Script Date: 16.02.2023 18:51:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [master]
GO

ALTER DATABASE [Workshop] SET  READ_WRITE
GO

/****** Object:  Database [Workshop]    Script Date: 16.02.2023 18:51:55 ******/
CREATE DATABASE [Workshop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Workshop2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Workshop2_Primary.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Workshop2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Workshop2_Primary.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT

GO

--Syntax Error: Expected DEFAULT_FULLTEXT_LANGUAGE but encountered CATALOG_COLLATION instead.
--/****** Object:  Database [Workshop]    Script Date: 16.02.2023 18:51:55 ******/
--CREATE DATABASE [Workshop]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'Workshop2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Workshop2_Primary.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'Workshop2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Workshop2_Primary.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT

GO

ALTER DATABASE [Workshop] SET ACCELERATED_DATABASE_RECOVERY = OFF  

GO

--Syntax Error: Incorrect syntax near ACCELERATED_DATABASE_RECOVERY.
--ALTER DATABASE [Workshop] SET ACCELERATED_DATABASE_RECOVERY = OFF  

GO

CREATE TABLE [dbo].[InitialQuantityOfItems](
	[Barcode] [nvarchar](100) NULL,
	[InitialQuantity] [int] NULL,
	[LatelyAddedQuantity] [int] NULL,
	[BoxesInitialQuantity] [int] NULL,
	[LatelyAddedBoxesQuantity] [int] NULL,
	[PeriodID] [int] NULL,
 CONSTRAINT [uq_InitialQuantityOfItems] UNIQUE NONCLUSTERED 
(
	[Barcode] ASC,
	[PeriodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[InitialQuantityOfItems](
--	[Barcode] [nvarchar](100) NULL,
--	[InitialQuantity] [int] NULL,
--	[LatelyAddedQuantity] [int] NULL,
--	[BoxesInitialQuantity] [int] NULL,
--	[LatelyAddedBoxesQuantity] [int] NULL,
--	[PeriodID] [int] NULL,
-- CONSTRAINT [uq_InitialQuantityOfItems] UNIQUE NONCLUSTERED 
--(
--	[Barcode] ASC,
--	[PeriodID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ItemCode] [nvarchar](100) NULL,
	[ItemCodeWithColor] [nvarchar](100) NULL,
	[Barcode] [nvarchar](100) NULL,
	[Image] [varbinary](max) NULL,
	[ItemNumberOnWB] [nvarchar](100) NULL,
	[InternalCode] [nvarchar](100) NULL,
	[ProductName] [nvarchar](100) NULL,
	[SubGroup] [nvarchar](100) NULL,
	[Color] [nvarchar](100) NULL,
	[HardboardBoxNumber] [nvarchar](100) NULL,
	[PackagingAndDimensions] [nvarchar](100) NULL,
	[GofferNumber] [nvarchar](100) NULL,
	[Category] [nvarchar](100) NULL,
	[Note] [nvarchar](max) NULL,
	[QuantityInStock] [int] NULL,
	[BoxesQuantity] [int] NULL,
	[MinimumQuantity] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[Items](
--	[ItemID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
--	[ItemCode] [nvarchar](100) NULL,
--	[ItemCodeWithColor] [nvarchar](100) NULL,
--	[Barcode] [nvarchar](100) NULL,
--	[Image] [varbinary](max) NULL,
--	[ItemNumberOnWB] [nvarchar](100) NULL,
--	[InternalCode] [nvarchar](100) NULL,
--	[ProductName] [nvarchar](100) NULL,
--	[SubGroup] [nvarchar](100) NULL,
--	[Color] [nvarchar](100) NULL,
--	[HardboardBoxNumber] [nvarchar](100) NULL,
--	[PackagingAndDimensions] [nvarchar](100) NULL,
--	[GofferNumber] [nvarchar](100) NULL,
--	[Category] [nvarchar](100) NULL,
--	[Note] [nvarchar](max) NULL,
--	[QuantityInStock] [int] NULL,
--	[BoxesQuantity] [int] NULL,
--	[MinimumQuantity] [int] NULL,
-- CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
--(
--	[ItemID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[ReportingPeriods](
	[PeriodID] [int] IDENTITY(1,1) NOT NULL,
	[Start] [date] NULL,
	[End] [date] NULL,
 CONSTRAINT [PK_ReportingPeriods] PRIMARY KEY CLUSTERED 
(
	[PeriodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[ReportingPeriods](
--	[PeriodID] [int] IDENTITY(1,1) NOT NULL,
--	[Start] [date] NULL,
--	[End] [date] NULL,
-- CONSTRAINT [PK_ReportingPeriods] PRIMARY KEY CLUSTERED 
--(
--	[PeriodID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[StockIn](
	[StockInID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[UserID] [int] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[StockInID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[StockIn](
--	[StockInID] [int] IDENTITY(1,1) NOT NULL,
--	[Date] [date] NULL,
--	[UserID] [int] NULL,
--	[Note] [nvarchar](max) NULL,
-- CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
--(
--	[StockInID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[StockInDetails](
	[StockInDetailID] [int] IDENTITY(1,1) NOT NULL,
	[StockInID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[BoxesQuantity] [int] NOT NULL,
 CONSTRAINT [PK_StockInDetails] PRIMARY KEY CLUSTERED 
(
	[StockInDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[StockInDetails](
--	[StockInDetailID] [int] IDENTITY(1,1) NOT NULL,
--	[StockInID] [int] NOT NULL,
--	[ItemID] [int] NOT NULL,
--	[Quantity] [int] NOT NULL,
--	[BoxesQuantity] [int] NOT NULL,
-- CONSTRAINT [PK_StockInDetails] PRIMARY KEY CLUSTERED 
--(
--	[StockInDetailID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[StockOut](
	[StockOutID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[UserID] [int] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED 
(
	[StockOutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[StockOut](
--	[StockOutID] [int] IDENTITY(1,1) NOT NULL,
--	[Date] [date] NULL,
--	[UserID] [int] NULL,
--	[Note] [nvarchar](max) NULL,
-- CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED 
--(
--	[StockOutID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[StockOutDetails](
	[StockOutDetailID] [int] IDENTITY(1,1) NOT NULL,
	[StockOutID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[BoxesQuantity] [int] NOT NULL,
 CONSTRAINT [PK_StockOutDetails] PRIMARY KEY CLUSTERED 
(
	[StockOutDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[StockOutDetails](
--	[StockOutDetailID] [int] IDENTITY(1,1) NOT NULL,
--	[StockOutID] [int] NOT NULL,
--	[ItemID] [int] NOT NULL,
--	[Quantity] [int] NOT NULL,
--	[BoxesQuantity] [int] NOT NULL,
-- CONSTRAINT [PK_StockOutDetails] PRIMARY KEY CLUSTERED 
--(
--	[StockOutDetailID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Privileges] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

--Syntax Error: Incorrect syntax near OPTIMIZE_FOR_SEQUENTIAL_KEY.
--CREATE TABLE [dbo].[Users](
--	[UserID] [int] IDENTITY(1,1) NOT NULL,
--	[FirstName] [nvarchar](50) NULL,
--	[MiddleName] [nvarchar](50) NULL,
--	[LastName] [nvarchar](50) NULL,
--	[Username] [nvarchar](50) NULL,
--	[Password] [nvarchar](50) NULL,
--	[Privileges] [nvarchar](50) NULL,
-- CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
--(
--	[UserID] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]



GO
