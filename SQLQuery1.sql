--Listar
create proc categoria_listar
as
select idcategoria as ID, nombre as Nombre, descripcion as Descripcion, estado as Estado
from categoria
order by idcategoria desc
go
--Buscar
create proc categoria_buscar
@valor varchar(50)
as
select idcategoria as ID, nombre as Nombre, descripcion as Descripcion, estado as Estado
from categoria
where nombre like '%' + @valor + '%' Or descripcion like '%' + @valor + '%' --con esa linea el valor no tiene que estar al inicio
order by nombre desc
go
--Insertar
create proc categoria_insertar
@nombre varchar(50),
@descripcion varchar(255)
as
insert into categoria (nombre,descripcion) values (@nombre,@descripcion)
go
--Actualizar
create proc categoria_actualizar
@idcategoria int,
@nombre varchar(50),
@descripcion varchar(255)
as
update categoria set nombre=@nombre,descripcion=@descripcion
where idcategoria=@idcategoria
go

--Eliminar
create proc categoria_eliminar
@idcategoria int
as
delete from categoria
where idcategoria=@idcategoria
go
--Desactivar
create proc categoria_desactivar
@idcategoria int
as
update categoria set estado=0--0= false = desactivado
where idcategoria=@idcategoria
go
--Activar
create proc categoria_activar
@idcategoria int
as
update categoria set estado=1 --activado
where idcategoria=@idcategoria
go