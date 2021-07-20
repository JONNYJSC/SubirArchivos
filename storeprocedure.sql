USE [db_Upload]
GO
/****** Object:  StoredProcedure [dbo].[sp_Archivo]    Script Date: 18/07/2021 01:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_Archivo]
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


-- listado registros de la tabla persona


alter proc SP_ListarArchivos
as
begin
	select
	id
	,nombre
	,fecha
	from tb_Archivo order by id
end
go

-- regitra nuevo archivo de la tabla tb_archivo

create proc SP_nuevoArchivo
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
go

-- borrar una archivo por su id
create proc SP_deleteArchivo
  @id int
  as
  begin
	delete from tb_Archivo where id = @id
	end
go