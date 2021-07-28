USE [Compania]
GO
/****** Object:  Table [dbo].[tb_Archivo]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Archivo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[fecha] [date] NULL,
	[archivo] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Categoria]    Script Date: 7/27/2021 11:14:22 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Orden]    Script Date: 7/27/2021 11:14:22 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Registro]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Registro](
	[Id_Registro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Registro] [varchar](100) NOT NULL,
	[Fecha_Registro] [date] NOT NULL,
	[Archivo_Registro] [image] NULL,
	[IdOrden] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Registro2]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Registro2](
	[Id_Registro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Registro] [varchar](100) NOT NULL,
	[Fecha_Registro] [date] NOT NULL,
	[Archivo_Registro] [image] NULL,
	[IdCategoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_Orden]  WITH CHECK ADD  CONSTRAINT [fk_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[tb_Categoria] ([Id_Categoria])
GO
ALTER TABLE [dbo].[tb_Orden] CHECK CONSTRAINT [fk_Categoria]
GO
ALTER TABLE [dbo].[tb_Registro]  WITH CHECK ADD  CONSTRAINT [fk_Orden] FOREIGN KEY([IdOrden])
REFERENCES [dbo].[tb_Orden] ([Id_Orden])
GO
ALTER TABLE [dbo].[tb_Registro] CHECK CONSTRAINT [fk_Orden]
GO
ALTER TABLE [dbo].[tb_Registro2]  WITH CHECK ADD  CONSTRAINT [fk_Categoria2] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[tb_Categoria] ([Id_Categoria])
GO
ALTER TABLE [dbo].[tb_Registro2] CHECK CONSTRAINT [fk_Categoria2]
GO
/****** Object:  StoredProcedure [dbo].[SP_editarArchivo]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_editarArchivo]
  @id int=null, 
  @nombre varchar(100)=null,
  @fecha date=null,
  @archivo image=null
  as
  begin
	update tb_Archivo
 	set nombre=@nombre, 
	fecha=@fecha 
	--,archivo
	where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_eliminarArchivo]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_eliminarArchivo]
  @id int=null
  as
  begin 
      delete 
      from   tb_Archivo 
      where  id=@Id 
  end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarArchivos]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ListarArchivos]
as
begin
	select
	id
	,nombre
	,fecha
	from tb_Archivo order by id
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarCategorias]    Script Date: 7/27/2021 11:14:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ListarOrden]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ListarOrden]
as
begin
	select
	Nombre_Orden
	from tb_Orden order by Id_Orden
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarOrdenCategoria]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ListarOrdenCategoria]
as
begin
	SELECT        tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria, count(tb_Registro2.IdCategoria) AS Total
FROM            tb_Registro2 INNER JOIN
                         tb_Categoria ON tb_Registro2.IdCategoria = tb_Categoria.Id_Categoria INNER JOIN
                         tb_Orden ON tb_Categoria.Id_Categoria = tb_Orden.IdCategoria
						 GROUP BY tb_Orden.IdCategoria, tb_Categoria.Nombre_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarRegistro]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ListarRegistro]
as
begin
	SELECT        Nombre_Registro, Fecha_Registro
FROM            tb_Registro2
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarRegistroCategoria]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ListarRegistroCategoria]
@BusqRegistCategoria int
as
begin
	SELECT        tb_Registro2.Id_Registro, tb_Registro2.Nombre_Registro, tb_Registro2.Fecha_Registro, tb_Registro2.Archivo_Registro, tb_Categoria.Id_Categoria, tb_Registro2.IdCategoria as IdReg_Cat
FROM            tb_Categoria INNER JOIN
                         tb_Registro2 ON tb_Categoria.Id_Categoria = tb_Registro2.IdCategoria
						 where tb_Registro2.IdCategoria = @BusqRegistCategoria
end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevaCategoria]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_nuevaCategoria]
  @Id_Categoria int=null, 
  @Nombre_Categoria varchar(25)=null
  as
  begin
	insert into tb_Categoria(
	Nombre_Categoria
	) values(@Nombre_Categoria)
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevaOrden]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_nuevaOrden]
  @Id_Orden int = null,  
  @Nombre_Orden varchar(20) = null, 
  @Id_Categoria int 
  as 
  begin 
	insert into tb_Orden values(@Nombre_Orden, @Id_Categoria) 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevoArchivo]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_nuevoArchivo]
  @id int=null, 
  @nombre varchar(100)=null,
  @fecha date=null,
  @archivo image=null
  as
  begin
	insert into tb_Archivo(
	nombre, 
	fecha, 
	archivo
	) values(@nombre, @fecha, @archivo)
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevoRegistro]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_nuevoRegistro]
  @Id_Registro int = null,  
  @Nombre_Registro varchar(20) = null, 
  @Fecha_Registro Date,
  @Archivo_Registro binary,
  @IdOrden int 
  as 
  begin 
	insert into tb_Registro values(@Nombre_Registro, @Fecha_Registro, @Archivo_Registro, @IdOrden) 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevoRegistro2]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_nuevoRegistro2]
  @Id_Registro int = null,  
  @Nombre_Registro varchar(20) = null, 
  @Fecha_Registro Date,
  @Archivo_Registro image,
  @IdCategoria int 
  as 
  begin 
	insert into tb_Registro2 values(@Nombre_Registro, @Fecha_Registro, @Archivo_Registro, @IdCategoria) 
end
GO
/****** Object:  StoredProcedure [dbo].[Update_Producto]    Script Date: 7/27/2021 11:14:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Update_Producto]
	@Id	INT,
	@Descripcion NVARCHAR(200),
	@CodigoProducto NVARCHAR(25),
	@Precio	MONEY
AS
BEGIN
	UPDATE dbo.Producto
	SET Descripcion    = @Descripcion, 
		CodigoProducto = @CodigoProducto, 
		Precio         = @Precio
	WHERE Id = @Id;
END
GO
