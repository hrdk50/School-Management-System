USE [master]
GO
/****** Object:  Database [SchoolManagementSystemDb]    Script Date: 31-03-2020 17:09:02 ******/
CREATE DATABASE [SchoolManagementSystemDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolManagementSystemDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SchoolManagementSystemDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolManagementSystemDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SchoolManagementSystemDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SchoolManagementSystemDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolManagementSystemDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolManagementSystemDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolManagementSystemDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolManagementSystemDb] SET QUERY_STORE = OFF
GO
USE [SchoolManagementSystemDb]
GO
/****** Object:  Table [dbo].[AdmissionForm]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdmissionForm](
	[AdmissionId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
	[BirthDate] [varchar](30) NOT NULL,
	[ResultStatus] [bit] NOT NULL,
	[StudentTypeId] [int] NOT NULL,
	[StandardId] [int] NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[BloodGroup] [varchar](10) NOT NULL,
	[Height] [varchar](10) NOT NULL,
	[Weight] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
 CONSTRAINT [PK_AddmissionForm] PRIMARY KEY CLUSTERED 
(
	[AdmissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fees]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fees](
	[FeesId] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[InstallmentId] [int] NOT NULL,
 CONSTRAINT [PK_Fees] PRIMARY KEY CLUSTERED 
(
	[FeesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guardian]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guardian](
	[GuardianId] [int] IDENTITY(1,1) NOT NULL,
	[FatherName] [varchar](50) NOT NULL,
	[MotherName] [varchar](50) NOT NULL,
	[FatherOccupation] [varchar](50) NOT NULL,
	[FatherSalary] [int] NOT NULL,
	[MotherOccupation] [varchar](50) NOT NULL,
	[MotherSalary] [int] NOT NULL,
	[SiblingName] [varchar](max) NOT NULL,
	[EmailId] [varchar](50) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[PinCode] [int] NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[MobileNumber] [varchar](50) NOT NULL,
	[StudentId] [int] NOT NULL,
 CONSTRAINT [PK_Guardian] PRIMARY KEY CLUSTERED 
(
	[GuardianId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Installments]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Installments](
	[InstallmentId] [int] IDENTITY(1,1) NOT NULL,
	[First] [int] NOT NULL,
	[Second] [int] NOT NULL,
	[Third] [int] NOT NULL,
	[Fourth] [int] NOT NULL,
 CONSTRAINT [PK_Installments] PRIMARY KEY CLUSTERED 
(
	[InstallmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Standard]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Standard](
	[StandardId] [int] IDENTITY(1,1) NOT NULL,
	[StandardName] [varchar](50) NOT NULL,
	[FeesId] [int] NOT NULL,
 CONSTRAINT [PK_Standard] PRIMARY KEY CLUSTERED 
(
	[StandardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentType]    Script Date: 31-03-2020 17:09:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentType](
	[StudentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[StudentsType] [bit] NOT NULL,
	[StudentTypeName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_StudentType] PRIMARY KEY CLUSTERED 
(
	[StudentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AdmissionForm]  WITH CHECK ADD  CONSTRAINT [FK_AddmissionForm_Standard] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[AdmissionForm] CHECK CONSTRAINT [FK_AddmissionForm_Standard]
GO
ALTER TABLE [dbo].[AdmissionForm]  WITH CHECK ADD  CONSTRAINT [FK_AddmissionForm_StudentType] FOREIGN KEY([StudentTypeId])
REFERENCES [dbo].[StudentType] ([StudentTypeId])
GO
ALTER TABLE [dbo].[AdmissionForm] CHECK CONSTRAINT [FK_AddmissionForm_StudentType]
GO
ALTER TABLE [dbo].[Fees]  WITH CHECK ADD  CONSTRAINT [FK_Fees_Installments] FOREIGN KEY([InstallmentId])
REFERENCES [dbo].[Installments] ([InstallmentId])
GO
ALTER TABLE [dbo].[Fees] CHECK CONSTRAINT [FK_Fees_Installments]
GO
ALTER TABLE [dbo].[Fees]  WITH CHECK ADD  CONSTRAINT [FK_Fees_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[Fees] CHECK CONSTRAINT [FK_Fees_Students]
GO
ALTER TABLE [dbo].[Guardian]  WITH CHECK ADD  CONSTRAINT [FK_Guardian_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[Guardian] CHECK CONSTRAINT [FK_Guardian_Students]
GO
ALTER TABLE [dbo].[Installments]  WITH CHECK ADD  CONSTRAINT [FK_Installments_Installments] FOREIGN KEY([InstallmentId])
REFERENCES [dbo].[Installments] ([InstallmentId])
GO
ALTER TABLE [dbo].[Installments] CHECK CONSTRAINT [FK_Installments_Installments]
GO
ALTER TABLE [dbo].[Standard]  WITH CHECK ADD  CONSTRAINT [FK_Standard_Fees] FOREIGN KEY([FeesId])
REFERENCES [dbo].[Fees] ([FeesId])
GO
ALTER TABLE [dbo].[Standard] CHECK CONSTRAINT [FK_Standard_Fees]
GO
USE [master]
GO
ALTER DATABASE [SchoolManagementSystemDb] SET  READ_WRITE 
GO
