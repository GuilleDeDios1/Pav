USE [master]
GO
/****** Object:  Database [ProyectoTPI]    Script Date: 04/10/2022 9:41:57 ******/
CREATE DATABASE [ProyectoTPI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoTPI', FILENAME = N'D:\ArchivoDePrograma\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProyectoTPI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoTPI_log', FILENAME = N'D:\ArchivoDePrograma\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProyectoTPI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectoTPI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoTPI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoTPI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoTPI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoTPI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoTPI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoTPI] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoTPI] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProyectoTPI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoTPI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoTPI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoTPI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoTPI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoTPI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoTPI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoTPI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoTPI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectoTPI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoTPI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoTPI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoTPI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoTPI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoTPI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoTPI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoTPI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoTPI] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoTPI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoTPI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoTPI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoTPI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoTPI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoTPI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProyectoTPI] SET QUERY_STORE = OFF
GO
USE [ProyectoTPI]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_Barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_Barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro_cliente] [varchar](50) NOT NULL,
	[nombre_cliente] [varchar](50) NOT NULL,
	[calle] [varchar](50) NULL,
	[nro_calle] [varchar](50) NULL,
	[id_localidad] [int] NULL,
	[id_barrio] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Llamadas]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Llamadas](
	[cod_nacional_emisor] [int] NOT NULL,
	[cod_area_emisor] [int] NOT NULL,
	[nro_telefono_emisor] [int] NOT NULL,
	[fecha_hora_inicio] [int] NOT NULL,
	[duracion] [int] NULL,
	[cod_nacional_receptor] [int] NULL,
	[cod_area_receptor] [int] NULL,
	[nro_telefono_receptor] [int] NULL,
	[cod_tipo_comunicacion] [int] NULL,
	[cod_banda_horaria] [int] NULL,
 CONSTRAINT [llamada_fk] PRIMARY KEY CLUSTERED 
(
	[cod_nacional_emisor] ASC,
	[cod_area_emisor] ASC,
	[nro_telefono_emisor] ASC,
	[fecha_hora_inicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codigo_postal] [int] NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[cod_servicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[costo_mensual] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[cod_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios_Contratados]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios_Contratados](
	[id_servicios_contratados] [int] NOT NULL,
	[nro_telefono] [int] NULL,
	[fecha_desde] [date] NULL,
	[fecha_hasta] [date] NULL,
	[id_servicio] [int] NULL,
 CONSTRAINT [PK_Servicios_Contratados] PRIMARY KEY CLUSTERED 
(
	[id_servicios_contratados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefonos]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos](
	[nro_telefono] [int] NOT NULL,
	[nro_cliente] [int] NULL,
 CONSTRAINT [PK_Telefonos] PRIMARY KEY CLUSTERED 
(
	[nro_telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 04/10/2022 9:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] NOT NULL,
	[usuario] [varchar](max) NOT NULL,
	[password] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_Barrio])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Barrios]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Localidad]
GO
ALTER TABLE [dbo].[Servicios_Contratados]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_Contratados_Servicios] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[Servicios] ([cod_servicio])
GO
ALTER TABLE [dbo].[Servicios_Contratados] CHECK CONSTRAINT [FK_Servicios_Contratados_Servicios]
GO
ALTER TABLE [dbo].[Telefonos]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Cliente] FOREIGN KEY([nro_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Telefonos] CHECK CONSTRAINT [FK_Telefonos_Cliente]
GO
USE [master]
GO
ALTER DATABASE [ProyectoTPI] SET  READ_WRITE 
GO
