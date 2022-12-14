USE [master]
GO
/****** Object:  Database [Mundial_2022]    Script Date: 28/09/2022 13:35:23 ******/
CREATE DATABASE [Mundial_2022]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mundial_2022', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Mundial_2022.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mundial_2022_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Mundial_2022_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Mundial_2022] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mundial_2022].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mundial_2022] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mundial_2022] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mundial_2022] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mundial_2022] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mundial_2022] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mundial_2022] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Mundial_2022] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mundial_2022] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mundial_2022] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mundial_2022] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mundial_2022] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mundial_2022] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mundial_2022] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mundial_2022] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mundial_2022] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Mundial_2022] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mundial_2022] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mundial_2022] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mundial_2022] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mundial_2022] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mundial_2022] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mundial_2022] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mundial_2022] SET RECOVERY FULL 
GO
ALTER DATABASE [Mundial_2022] SET  MULTI_USER 
GO
ALTER DATABASE [Mundial_2022] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mundial_2022] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mundial_2022] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mundial_2022] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mundial_2022] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Mundial_2022] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Mundial_2022', N'ON'
GO
ALTER DATABASE [Mundial_2022] SET QUERY_STORE = OFF
GO
USE [Mundial_2022]
GO
/****** Object:  Table [dbo].[Bombo]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bombo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[No_Bombo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estad_Gol]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estad_Gol](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Jugad] [varchar](10) NULL,
	[No_Ronda] [int] NULL,
	[No_Bombo] [int] NULL,
	[Cod_Selecc] [varchar](5) NULL,
	[Min_Gol] [int] NULL,
	[Asist_gol] [varchar](60) NULL,
	[tipo_gol] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estad_Partido]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estad_Partido](
	[Cod_Selecc] [varchar](5) NULL,
	[No_Ronda] [int] NULL,
	[No_Bombo] [int] NULL,
	[Goles] [int] NULL,
	[Tarj_Amari] [int] NULL,
	[Tarj_Roja] [int] NULL,
	[Tiro_alArco] [int] NULL,
	[Tiro_Desv] [int] NULL,
	[Tiro_Esquina] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plantilla]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plantilla](
	[Cod_Jugad] [varchar](10) NOT NULL,
	[Cod_Selecc] [varchar](5) NULL,
	[Nom_Jugad] [varchar](60) NULL,
	[Apell_Jugad] [varchar](60) NULL,
	[Date_Naci] [date] NULL,
	[Club_Jugad] [varchar](60) NULL,
	[Min_play] [int] NULL,
	[Goles_Jugad] [int] NULL,
	[Asist_Jugad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Jugad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ronda]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ronda](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Ronda] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rondas]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rondas](
	[No_Ronda] [int] NULL,
	[No_Bombo] [int] NULL,
	[Cod_Selecc] [varchar](5) NULL,
	[Goles_Ronda] [int] NULL,
	[Tiro_alArco] [int] NULL,
	[Tiro_Desv] [int] NULL,
	[Tarj_Amari] [int] NULL,
	[Tarj_Roja] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seleccion]    Script Date: 28/09/2022 13:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seleccion](
	[Cod_Selecc] [varchar](5) NOT NULL,
	[Nom_Selecc] [varchar](60) NULL,
	[Entrenador] [varchar](60) NULL,
	[No_Bombo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Selecc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Estad_Gol]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Gol_Bombo] FOREIGN KEY([No_Bombo])
REFERENCES [dbo].[Bombo] ([ID])
GO
ALTER TABLE [dbo].[Estad_Gol] CHECK CONSTRAINT [FK_Estad_Gol_Bombo]
GO
ALTER TABLE [dbo].[Estad_Gol]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Gol_Plantilla] FOREIGN KEY([Cod_Jugad])
REFERENCES [dbo].[Plantilla] ([Cod_Jugad])
GO
ALTER TABLE [dbo].[Estad_Gol] CHECK CONSTRAINT [FK_Estad_Gol_Plantilla]
GO
ALTER TABLE [dbo].[Estad_Gol]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Gol_Ronda] FOREIGN KEY([No_Ronda])
REFERENCES [dbo].[Ronda] ([ID])
GO
ALTER TABLE [dbo].[Estad_Gol] CHECK CONSTRAINT [FK_Estad_Gol_Ronda]
GO
ALTER TABLE [dbo].[Estad_Gol]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Gol_Seleccion] FOREIGN KEY([Cod_Selecc])
REFERENCES [dbo].[Seleccion] ([Cod_Selecc])
GO
ALTER TABLE [dbo].[Estad_Gol] CHECK CONSTRAINT [FK_Estad_Gol_Seleccion]
GO
ALTER TABLE [dbo].[Estad_Partido]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Partido_Bombo] FOREIGN KEY([No_Bombo])
REFERENCES [dbo].[Bombo] ([ID])
GO
ALTER TABLE [dbo].[Estad_Partido] CHECK CONSTRAINT [FK_Estad_Partido_Bombo]
GO
ALTER TABLE [dbo].[Estad_Partido]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Partido_Ronda] FOREIGN KEY([No_Ronda])
REFERENCES [dbo].[Ronda] ([ID])
GO
ALTER TABLE [dbo].[Estad_Partido] CHECK CONSTRAINT [FK_Estad_Partido_Ronda]
GO
ALTER TABLE [dbo].[Estad_Partido]  WITH CHECK ADD  CONSTRAINT [FK_Estad_Partido_Seleccion] FOREIGN KEY([Cod_Selecc])
REFERENCES [dbo].[Seleccion] ([Cod_Selecc])
GO
ALTER TABLE [dbo].[Estad_Partido] CHECK CONSTRAINT [FK_Estad_Partido_Seleccion]
GO
ALTER TABLE [dbo].[Plantilla]  WITH CHECK ADD  CONSTRAINT [FK_Plantilla_Seleccion] FOREIGN KEY([Cod_Selecc])
REFERENCES [dbo].[Seleccion] ([Cod_Selecc])
GO
ALTER TABLE [dbo].[Plantilla] CHECK CONSTRAINT [FK_Plantilla_Seleccion]
GO
ALTER TABLE [dbo].[Rondas]  WITH CHECK ADD  CONSTRAINT [FK_Rondas_Bombo] FOREIGN KEY([No_Bombo])
REFERENCES [dbo].[Bombo] ([ID])
GO
ALTER TABLE [dbo].[Rondas] CHECK CONSTRAINT [FK_Rondas_Bombo]
GO
ALTER TABLE [dbo].[Rondas]  WITH CHECK ADD  CONSTRAINT [FK_Rondas_Ronda] FOREIGN KEY([No_Ronda])
REFERENCES [dbo].[Ronda] ([ID])
GO
ALTER TABLE [dbo].[Rondas] CHECK CONSTRAINT [FK_Rondas_Ronda]
GO
ALTER TABLE [dbo].[Rondas]  WITH CHECK ADD  CONSTRAINT [FK_Rondas_Seleccion] FOREIGN KEY([Cod_Selecc])
REFERENCES [dbo].[Seleccion] ([Cod_Selecc])
GO
ALTER TABLE [dbo].[Rondas] CHECK CONSTRAINT [FK_Rondas_Seleccion]
GO
USE [master]
GO
ALTER DATABASE [Mundial_2022] SET  READ_WRITE 
GO
