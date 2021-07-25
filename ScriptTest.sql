USE [db_Upload]
GO
/****** Object:  Table [dbo].[tb_Categoria]    Script Date: 25/07/2021 02:14:30 p. m. ******/
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
/****** Object:  Table [dbo].[tb_Orden]    Script Date: 25/07/2021 02:14:30 p. m. ******/
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
/****** Object:  Table [dbo].[tb_Registro]    Script Date: 25/07/2021 02:14:30 p. m. ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[SP_ListarCategorias]    Script Date: 25/07/2021 02:14:30 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ListarOrdenCategoria]    Script Date: 25/07/2021 02:14:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ListarOrdenCategoria]
as
begin
	SELECT        tb_Categoria.Nombre_Categoria, count(tb_Categoria.Id_Categoria) As Total
FROM            tb_Categoria INNER JOIN
                         tb_Orden ON tb_Categoria.Id_Categoria = tb_Orden.IdCategoria
						 group by tb_Categoria.Nombre_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevaCategoria]    Script Date: 25/07/2021 02:14:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_nuevaCategoria]
  @Id_Categoria int=null, 
  @Nombre_Categoria varchar(25)=null
  as
  begin
	insert into tb_Categoria(
	Nombre_Categoria
	) values(@Nombre_Categoria)
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_nuevaOrden]    Script Date: 25/07/2021 02:14:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_nuevaOrden]
  @Id_Orden int = null,  
  @Nombre_Orden varchar(20) = null, 
  @Id_Categoria int 
  as 
  begin 
	insert into tb_Orden values(@Nombre_Orden, @Id_Categoria) 
end
GO
