USE [master]
GO
/****** Object:  Database [VIDEO_CLUB_PELICULAS]    Script Date: 26/3/2022 11:01:07 a. m. ******/
CREATE DATABASE [VIDEO_CLUB_PELICULAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VIDEO_CLUB_PELICULAS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VIDEO_CLUB_PELICULAS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VIDEO_CLUB_PELICULAS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VIDEO_CLUB_PELICULAS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VIDEO_CLUB_PELICULAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET  MULTI_USER 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET QUERY_STORE = OFF
GO
USE [VIDEO_CLUB_PELICULAS]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 26/3/2022 11:01:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] NOT NULL,
	[nombre] [varchar](20) NULL,
 CONSTRAINT [categoria_pk] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 26/3/2022 11:01:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[tipoFactura] [varchar](20) NOT NULL,
	[nroFactura] [int] NOT NULL,
	[CodPelicula] [int] NOT NULL,
	[fecha_prevista_devolucion] [varchar](20) NULL,
	[fecha_real_devolucion] [varchar](20) NULL,
 CONSTRAINT [detalle_pk] PRIMARY KEY CLUSTERED 
(
	[tipoFactura] ASC,
	[nroFactura] ASC,
	[CodPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 26/3/2022 11:01:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[tipo_factura] [varchar](20) NOT NULL,
	[numero_factura] [int] NOT NULL,
	[fecha] [varchar](20) NULL,
	[nroSocio] [int] NULL,
	[total] [float] NULL,
 CONSTRAINT [factura_pk] PRIMARY KEY CLUSTERED 
(
	[tipo_factura] ASC,
	[numero_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 26/3/2022 11:01:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[cod_pelicula] [int] NOT NULL,
	[nombre] [varchar](20) NULL,
	[precio] [float] NULL,
	[idCategoria] [int] NULL,
 CONSTRAINT [pelicula_pk] PRIMARY KEY CLUSTERED 
(
	[cod_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 26/3/2022 11:01:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socios](
	[nro_socio] [int] NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[dni] [int] NULL,
	[calle] [varchar](30) NULL,
	[nro_calle] [int] NULL,
 CONSTRAINT [nrosocio_pk] PRIMARY KEY CLUSTERED 
(
	[nro_socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [detalle_codPelicula_fk] FOREIGN KEY([CodPelicula])
REFERENCES [dbo].[Peliculas] ([cod_pelicula])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [detalle_codPelicula_fk]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [detalle_tipoFac_fk] FOREIGN KEY([tipoFactura], [nroFactura])
REFERENCES [dbo].[Facturas] ([tipo_factura], [numero_factura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [detalle_tipoFac_fk]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [factura_fk] FOREIGN KEY([nroSocio])
REFERENCES [dbo].[Socios] ([nro_socio])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [factura_fk]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [categoria_fk] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [categoria_fk]
GO
USE [master]
GO
ALTER DATABASE [VIDEO_CLUB_PELICULAS] SET  READ_WRITE 
GO
