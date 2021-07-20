USE [db_Upload]
GO
/****** Object:  Table [dbo].[tb_Archivo]    Script Date: 19/07/2021 09:30:18 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Archivo]    Script Date: 19/07/2021 09:30:19 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Archivo]
  @id int=null, 
  @nombre varchar(100)=null,
  @fecha date=null,
  @archivo image=null,
  @modo varchar(25) 
as 
  begin 
    set nocount on; 
    if (@modo='guardar') 
    begin 
	if not exists (select * from tb_Archivo where id=@id)
      insert into tb_Archivo(nombre, fecha, archivo) 
                  values (@nombre, @fecha, @archivo)
    end 
	 if (@modo='mostrar')
    begin 
      select id, 
             nombre, 
             fecha
			 --archivo
      from   tb_Archivo order by id
    end 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_deleteArchivo]    Script Date: 19/07/2021 09:30:19 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_deleteArchivo]
  @id int
  as
  begin
	delete from tb_Archivo where id = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_editarArchivo]    Script Date: 19/07/2021 09:30:19 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_eliminarArchivo]    Script Date: 19/07/2021 09:30:19 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ListarArchivos]    Script Date: 19/07/2021 09:30:19 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_nuevoArchivo]    Script Date: 19/07/2021 09:30:19 a. m. ******/
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
