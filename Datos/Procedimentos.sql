USE [DBVentas]
GO
--Procedimiento Mostrar
Create Proc SpMostrar_Categoria
as
select top 200 * from DBVentas.dbo.Categoria
order by nombre asc
go

--Procedimiento Buscar(textBuscar=Nombre)
Create Proc SpBuscar_Categoria
@textBuscar varchar(50)
as
select * from DBVentas.dbo.Categoria
where  nombre COLLATE SQL_Latin1_General_Cp1_CI_AI 
like '%'+ @textBuscar + '%' 
ORDER BY DBVentas.dbo.Categoria.nombre
go

--Procedimiento Insertar(id, nombre, descrip)
create proc SpInsertar_Categoria
@idCategoria int output,
@nombre varchar(50),
@descripcion varchar(255)
as
insert into DBVentas.dbo.Categoria (nombre, descripcion)
values(@nombre, @descripcion)
go

--Procedimiento Editar(id)
Create Proc SpEditar_Categoria
@idCategoria int,
@nombre varchar(50),
@descripcion varchar(255)
as
update DBVentas.dbo.Categoria set nombre=@nombre,
descripcion=@descripcion
where idCategoria=@idCategoria
go

--Procedimento Eliminar(id)
Create Proc SpEliminar_Categoria
@idCategoria int
as
delete from DBVentas.dbo.Categoria
where idCategoria = @idCategoria
go

--Procedimiento Mostrar Presentacion
Create Proc SpMostrar_Presentacion
As
Select top 100 * From dbo.Presentacion
Order BY idPresentacion desc
GO
--Procedimiento Buscar Presentacion(textBuscar = Nombre)
Create Proc SpBuscar_Presentacion
@textBuscar varchar(50)
AS
Select * from dbo.Presentacion
Where descripcion COLLATE SQL_Latin1_General_Cp1_CI_AI 
like '%'+ @textBuscar + '%' or nombre COLLATE SQL_Latin1_General_Cp1_CI_AI 
like '%'+ @textBuscar + '%'
Go 
--Procedimiento Insertar Presentacion
Create proc SpInsertar_Presentacion
@idPresentacion int output,
@nombre varchar(50),
@descripcion varchar(255)
As
Insert into Presentacion (nombre,descripcion)
values (@nombre,@descripcion)
Go
--Procedimiento Editar Presentacion
Create Proc SpEditar_Presentacion
@idPresentacion int,
@nombre varchar(50),
@descripcion varchar(255)
As
update Presentacion set nombre= @nombre, descripcion=@descripcion
where idPresentacion = @idPresentacion
Go
--Procedimiento Eliminar Presentacion
create proc SpEliminar_Presentacion
@idPresentacion int
as
delete from Presentacion
where idPresentacion= @idPresentacion
go

--Procedimiento Mostrar Articulo
create proc SpMostrar_Articulo
as
SELECT top 100 Articulo.idArticulo, Articulo.codigo, Articulo.nombre, Articulo.descripcion, Articulo.imagen, Articulo.idCategoria, Articulo.idPresentacion, Categoria.nombre 
AS Categoria, Presentacion.nombre AS Presentacion
FROM dbo.Articulo INNER JOIN dbo.Categoria 
ON Articulo.idCategoria = Categoria.idCategoria INNER JOIN dbo.Presentacion 
ON dbo.Articulo.idPresentacion = dbo.Presentacion.idPresentacion
order by dbo.Articulo.idArticulo desc
Go
--Procedimiento Buscar Articulo(TextBuscar)
create proc SpBuscar_Articulo
@textBuscar varchar(50)
as
SELECT Articulo.idArticulo, Articulo.codigo, Articulo.nombre, Articulo.descripcion, Articulo.imagen, Articulo.idCategoria, Articulo.idPresentacion, Categoria.nombre 
AS Categoria, Presentacion.nombre AS Presentacion
FROM dbo.Articulo INNER JOIN dbo.Categoria 
ON Articulo.idCategoria = Categoria.idCategoria INNER JOIN dbo.Presentacion 
ON dbo.Articulo.idPresentacion = dbo.Presentacion.idPresentacion
where dbo.Articulo.nombre like '%'+@textBuscar+'%' or dbo.Articulo.descripcion like '%'+@textBuscar+'%'
order by dbo.Articulo.idArticulo desc
Go
--Procedimiento Insertar Articulo
create proc SpInsertar_Articulo
@idArticulo int output,@codigo varchar(50),
@nombre varchar(50),@descripcion varchar(1024),
@imagen image,@idCategoria int,@idPresentacion int
AS
insert Into Articulo(codigo, nombre, descripcion, imagen, idCategoria, idPresentacion)
values(@codigo, @nombre, @descripcion, @imagen, @idCategoria, @idPresentacion)
Go
--Procedimiento	Editar Articulo
create proc SpEditar_Articulo
@idArticulo int,@codigo varchar(50),
@nombre varchar(50),@descripcion varchar(1024),
@imagen image,@idCategoria int,@idPresentacion int
AS
update Articulo set codigo = @codigo, nombre= @nombre, descripcion = @descripcion, 
imagen = @imagen, idCategoria = @idCategoria, idPresentacion = @idPresentacion
where idArticulo = @idArticulo
Go
--Procedimiento Eliminar Articulo
create proc SpEliminar_Articulo
@idArticulo int
as
delete from Articulo
where idArticulo = @idArticulo
Go