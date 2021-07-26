USE [master]
GO
/****** Object:  Database [db_Upload]    Script Date: 25/07/2021 09:34:29 p. m. ******/
CREATE DATABASE [db_Upload]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbUpload', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbUpload.mdf' , SIZE = 139264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbUpload_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbUpload_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_Upload] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Upload].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Upload] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_Upload] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_Upload] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_Upload] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_Upload] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_Upload] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_Upload] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_Upload] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_Upload] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_Upload] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_Upload] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_Upload] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_Upload] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_Upload] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_Upload] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_Upload] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_Upload] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_Upload] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_Upload] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_Upload] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_Upload] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_Upload] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_Upload] SET RECOVERY FULL 
GO
ALTER DATABASE [db_Upload] SET  MULTI_USER 
GO
ALTER DATABASE [db_Upload] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_Upload] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_Upload] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_Upload] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_Upload] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_Upload] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_Upload', N'ON'
GO
ALTER DATABASE [db_Upload] SET QUERY_STORE = OFF
GO
USE [db_Upload]
GO
/****** Object:  Table [dbo].[tb_Categoria]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Categoria](
	[Id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Categoria] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Orden]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Orden](
	[Id_Orden] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Orden] [varchar](20) NOT NULL,
	[IdCategoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Registro]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter TABLE [dbo].[tb_Registro](
	[Id_Registro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Registro] [varchar](100) NOT NULL,
	[Fecha_Registro] [date] NOT NULL,
	[Archivo_Registro] [image] NULL,
	[IdCategoria] [int] NOT NULL,
	ALTER TABLE [dbo].[tb_Registro]  WITH CHECK ADD  CONSTRAINT [fk_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[tb_Categoria] ([Id_Categoria])
GO
ALTER TABLE [dbo].[tb_Orden]  WITH CHECK ADD  CONSTRAINT [fk_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[tb_Categoria] ([Id_Categoria])
GO
ALTER TABLE [dbo].[tb_Orden] CHECK CONSTRAINT [fk_Categoria]
GO
ALTER TABLE [dbo].[tb_Registro]  WITH CHECK ADD  CONSTRAINT [fk_Orden] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[tb_Categoria] ([Id_Categoria])
GO
ALTER TABLE [dbo].[tb_Registro] CHECK CONSTRAINT [fk_Orden]
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarCategorias]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_ListarCategorias]
as
begin
	select Nombre_Categoria
	from tb_Categoria order by  Id_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarOrdenCategoria]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[SP_ListarOrdenCategoria]
as
begin
	SELECT        tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria, count(tb_Registro2.IdCategoria) AS Total
FROM            tb_Registro2 INNER JOIN
                         tb_Categoria ON tb_Registro2.IdCategoria = tb_Categoria.Id_Categoria INNER JOIN
                         tb_Orden ON tb_Categoria.Id_Categoria = tb_Orden.IdCategoria
						 GROUP BY tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarRegistro]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[SP_ListarRegistro]
as
begin
	SELECT        Nombre_Registro, Fecha_Registro
FROM            tb_Registro2
end
GO

SELECT        tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria, count(tb_Orden.Id_Orden) As Total
FROM            tb_Orden INNER JOIN
                         tb_Categoria ON tb_Orden.IdCategoria = tb_Categoria.Id_Categoria
GROUP BY tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria

SELECT        tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria, count(tb_Registro2.IdCategoria) AS Total
FROM            tb_Registro2 INNER JOIN
                         tb_Categoria ON tb_Registro2.IdCategoria = tb_Categoria.Id_Categoria INNER JOIN
                         tb_Orden ON tb_Categoria.Id_Categoria = tb_Orden.IdCategoria
						 GROUP BY tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria

	SELECT        tb_Orden.IdCategoria, tb_Orden.Nombre_Orden, tb_Categoria.Nombre_Categoria
FROM            tb_Orden INNER JOIN
                         tb_Categoria ON tb_Orden.IdCategoria = tb_Categoria.Id_Categoria

/****** Object:  StoredProcedure [dbo].[SP_ListarRegistroOrden]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[SP_ListarRegistroCategoria]
@BusqRegistCategoria int
as
begin
	SELECT        tb_Registro2.Id_Registro, tb_Registro2.Nombre_Registro, tb_Registro2.Fecha_Registro, tb_Registro2.Archivo_Registro, tb_Categoria.Id_Categoria, tb_Registro2.IdCategoria as IdReg_Cat
FROM            tb_Categoria INNER JOIN
                         tb_Registro2 ON tb_Categoria.Id_Categoria = tb_Registro2.IdCategoria
						 where tb_Registro2.IdCategoria = @BusqRegistCategoria
end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevaCategoria]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[SP_nuevaCategoria]
  @Id_Categoria int=null, 
  @Nombre_Categoria varchar(25)=null
  as
  begin
	insert into tb_Categoria(
	Nombre_Categoria
	) values(@Nombre_Categoria)
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevaOrden]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[SP_nuevaOrden]
  @Id_Orden int = null,  
  @Nombre_Orden varchar(20) = null, 
  @Id_Categoria int 
  as 
  begin 
	insert into tb_Orden values(@Nombre_Orden, @Id_Categoria) 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevoRegistro]    Script Date: 25/07/2021 09:34:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_nuevoRegistro2]
  @Id_Registro int = null,  
  @Nombre_Registro varchar(20) = null, 
  @Fecha_Registro Date,
  @Archivo_Registro binary,
  @IdCategoria int 
  as 
  begin 
	insert into tb_Registro2 values(@Nombre_Registro, @Fecha_Registro, @Archivo_Registro, @IdCategoria) 
end
GO
USE [master]
GO
ALTER DATABASE [db_Upload] SET  READ_WRITE 
GO


exec SP_ListarRegistroCategoria 1

create table tb_Registro2( 
Id_Registro int identity(1,1) primary key, 
Nombre_Registro varchar(100) not null, 
Fecha_Registro date not null, 
Archivo_Registro image null, 
IdCategoria int not null, 
CONSTRAINT fk_Categoria2 FOREIGN KEY (IdCategoria) REFERENCES tb_Categoria (Id_Categoria) 
);

SELECT        tb_Registro2.Nombre_Registro, tb_Registro2.Fecha_Registro, tb_Registro2.Archivo_Registro, tb_Categoria.Id_Categoria, tb_Registro2.IdCategoria as IdReg_Cat
FROM            tb_Categoria INNER JOIN
                         tb_Registro2 ON tb_Categoria.Id_Categoria = tb_Registro2.IdCategoria
						 where tb_Registro2.IdCategoria = tb_Registro2.IdCategoria

SELECT        Id_Registro, Nombre_Registro, Fecha_Registro, Archivo_Registro
FROM            tb_Registro2


select * from tb_Registro2
