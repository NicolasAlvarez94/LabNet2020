USE [master]
GO
/****** Object:  Database [Empresa_Contacto]    Script Date: 7/11/2020 23:32:51 ******/
CREATE DATABASE [Empresa_Contacto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Empresa_Contacto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Empresa_Contacto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Empresa_Contacto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Empresa_Contacto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Empresa_Contacto] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Empresa_Contacto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Empresa_Contacto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET ARITHABORT OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Empresa_Contacto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Empresa_Contacto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Empresa_Contacto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Empresa_Contacto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET RECOVERY FULL 
GO
ALTER DATABASE [Empresa_Contacto] SET  MULTI_USER 
GO
ALTER DATABASE [Empresa_Contacto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Empresa_Contacto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Empresa_Contacto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Empresa_Contacto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Empresa_Contacto] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Empresa_Contacto', N'ON'
GO
ALTER DATABASE [Empresa_Contacto] SET QUERY_STORE = OFF
GO
USE [Empresa_Contacto]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 7/11/2020 23:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Genero] [varchar](1) NOT NULL,
	[Empresa] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contactos] ON 

INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (1, N'Marcos', N'Alvarez', 25, N'M', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (2, N'Marcos', N'Nicolas', 26, N'M', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (3, N'Florencia', N'Alvear', 24, N'F', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (4, N'Jorge', N'Perez', 30, N'M', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (5, N'Romina', N'Fernandez', 28, N'F', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (6, N'Daiana', N'Ramirez', 22, N'F', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (7, N'Ruben', N'Perez', 45, N'M', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (8, N'Dario', N'Damian', 24, N'M', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (9, N'Agustina', N'Fabiani', 22, N'F', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (10, N'Agustina', N'Alvear', 22, N'F', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (11, N'Daniela', N'Perez', 24, N'F', N'-')
INSERT [dbo].[Contactos] ([id], [Nombre], [Apellido], [Edad], [Genero], [Empresa]) VALUES (12, N'Cristian', N'Alvarez', 28, N'M', N'-')
SET IDENTITY_INSERT [dbo].[Contactos] OFF
USE [master]
GO
ALTER DATABASE [Empresa_Contacto] SET  READ_WRITE 
GO
