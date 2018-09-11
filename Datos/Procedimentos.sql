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


--Mostrar
Create proc SpMostrar_Proveedor
as
select top 100 * from Proveedor
order by razon_social asc
Go
-- Buscar Ambas
Create proc Spbuscar_Proveedor_NumDoc_RazonSocial
@textBuscar varchar(50)
as
select * from Proveedor
where num_documento like '%'+@textBuscar+'%' or razon_social like '%'+@textBuscar+'%'
GO

--Buscar Razon Social
create proc Spbuscar_Proveedor_razon_social
@textBuscar varchar(50)
as
select * from Proveedor
where razon_social like '%'+@textBuscar+'%'
Go
--Buscar Numero de Documento
create proc Spbuscar_Proveedor_num_documento
@textBuscar varchar(50)
as
select * from Proveedor
where num_documento like '%'+@textBuscar+'%'
Go
--Insertar
create proc SpInsertar_Proveedor
@idProveedor int output,
@razon_social varchar(150),
@sector_comercial varchar(50),
@tipo_documento varchar(50),
@num_documento varchar(50),
@direccion varchar(100),
@telefono varchar(50),
@email varchar(50),
@url_web varchar(100)
AS
INSERT INTO Proveedor (razon_social,sector_comercial,tipo_documento,num_documento,direccion,telefono,email,url_web)
VALUES(@razon_social,@sector_comercial,@tipo_documento,@num_documento,@direccion,@telefono,@email,@url_web)
Go 
--Editar
create proc SpEditar_Proveedor
@idProveedor int,
@razon_social varchar(150),
@sector_comercial varchar(50),
@tipo_documento varchar(50),
@num_documento varchar(50),
@direccion varchar(100),
@telefono varchar(50),
@email varchar(50),
@url_web varchar(100)
AS
UPDATE Proveedor Set razon_social=@razon_social, sector_comercial=@sector_comercial, tipo_documento=@tipo_documento,
num_documento=@num_documento, direccion=@direccion, telefono=@telefono, email=@email, url_web=@url_web
WHERE idProveedor = @idProveedor
Go 
--Eleminar
create proc SpEliminar_Proveedor
@idProveedor int
AS
delete from Proveedor
where idProveedor = @idProveedor
Go


--Procedimiento Mostrar
CREATE PROC SpMostrar_Cliente
AS
SELECT TOP 100 * FROM dbo.Cliente
ORDER BY nombre ASC
GO
--Procedimiento Buscar Nombre y Apellido
CREATE PROC SpBuscar_Cliente
@textBuscar VARCHAR(50)
AS
SELECT * FROM  DBVentas.dbo.Cliente
WHERE nombre LIKE '%'+@textBuscar+'%' OR apellidos LIKE '%'+@textBuscar+'%'
GO
--Procedimiento Insertar
CREATE PROC SpInsertar_Cliente
@idCliente int OUTPUT,
@nombre VARCHAR(20),
@apellidos VARCHAR(40),
@sexo VARCHAR(1),
@fecha_nacimiento DATE,
@tipo_documento VARCHAR(20),
@num_documento VARCHAR(14),
@direccion VARCHAR(100),
@telefono VARCHAR(10),
@email VARCHAR(50)
AS
INSERT INTO  DBVentas.dbo.Cliente(nombre, apellidos, sexo, fecha_nacimiento, tipo_documento, num_documento, direccion, telefono, email)
VALUES ( @nombre, @apellidos, @sexo, @fecha_nacimiento, @tipo_documento, @num_documento, @direccion, @telefono, @email)
GO
--Procedimiento Editar
CREATE PROC SpEditar_Cliente
@idCliente int OUTPUT,
@nombre VARCHAR(20),
@apellidos VARCHAR(40),
@sexo VARCHAR(1),
@fecha_nacimiento DATE,
@tipo_documento VARCHAR(20),
@num_documento VARCHAR(14),
@direccion VARCHAR(100),
@telefono VARCHAR(10),
@email VARCHAR(50)
AS
UPDATE  DBVentas.dbo.Cliente SET nombre = @nombre, apellidos = @apellidos, sexo = @sexo, fecha_nacimiento = @fecha_nacimiento,
num_documento = @num_documento, direccion = @direccion, telefono = @telefono, email = @email
WHERE idCliente = @idCliente
GO
--Procedimento Eliminar
CREATE PROC SpEliminar_Cliente
@idCliente int
AS
DELETE FROM  DBVentas.dbo.Cliente
WHERE idCliente = @idCliente
GO


-- Mostrar Trabajadores
CREATE PROC SpMostrar_Trabajador
AS
SELECT TOP 100 * From dbo.Trabajador
Order by apellidos asc 
GO
-- Buscar Trabajadores
CREATE PROC SpBuscar_Trabajador
@textBuscar varchar(50)
AS
SELECT * FROM dbo.Trabajador
WHERE apellidos like '%'+@textBuscar+'%' OR nombre like '%'+@textBuscar+'%' OR num_documento like '%'+@textBuscar+'%' 
ORDER BY apellidos asc
GO
-- Insertar Trabajadores
CREATE PROC SpInsertar_Trabajador
@idTrabajador int OutPut,
@nombre varchar(20),
@apellidos varchar(40),
@sexo varchar(1),
@fecha_nacimiento date,
@tipo_documento varchar(20),
@num_documento varchar(14),
@direccion varchar(100),
@telefono varchar(10),
@email varchar(50),
@acesso varchar(20),
@usuario varchar(20),
@password varchar(20)
AS
Insert INTO Trabajador (nombre, apellidos, sexo, fecha_nacimiento, tipo_documento, num_documento, direccion, telefono, email, acesso, usuario, password)
Values (@nombre, @apellidos, @sexo, @fecha_nacimiento, @tipo_documento, @num_documento, @direccion, @telefono,@email, @acesso, @usuario, @password)
GO
-- Update Trabajadores
CREATE PROC SpEditar_Trabajador
@idTrabajador int,
@nombre varchar(20),
@apellidos varchar(40),
@sexo varchar(1),
@fecha_nacimiento date,
@tipo_documento varchar(20),
@num_documento varchar(14),
@direccion varchar(100),
@telefono varchar(10),
@email varchar(50),
@acesso varchar(20),
@usuario varchar(20),
@password varchar(20)
AS
Update Trabajador set nombre=@nombre, apellidos=@apellidos, sexo=@sexo, fecha_nacimiento=@fecha_nacimiento, tipo_documento=@tipo_documento,  num_documento=@num_documento, direccion=@direccion, telefono=@telefono, email=@email, acesso=@acesso, usuario=@usuario, password=@password
WHERE idTrabajador = @idTrabajador
GO
-- Delete Trabajadores
CREATE PROC SpEliminar_Trabajador
@idTrabajador int
AS
Delete FROM dbo.Trabajador
WHERE idTrabajador = @idTrabajador
GO

--Comprobar si hay Un Usuario Con el Mismo nombre
Create Proc [dbo].[SpConfirmarLogin]
@usuario varchar(20)
AS
Select usuario
from Trabajador
where usuario = @usuario
Go

--Cargar Login
Create Proc SpLogin
@usuario varchar(20),
@password varchar(20)
AS
Select idTrabajador, apellidos, nombre, acesso
from Trabajador
where usuario = @usuario and password = @password
GO

--Procedimiento Almacenado para mostrar los Ingreso
Create Proc SpMostrar_Ingreso
AS
Select i.idIngreso, (t.apellidos+' '+t.nombre) as Trabajador,
p.razon_social as Proveedor, i.fecha, i.tipo_comprobante,
i.serie, i.correlativo, i.estado, SUM(d.precio_compra*d.stock_inicial) as Total
From Detalle_ingreso d inner join Ingreso i
on d.idIngreso = i.idIngreso inner join Proveedor p
on i.idProveedor = p.idProveedor inner join Trabajador t
on  i.idTrabajador = t.idTrabajador
GROUP BY
i.idIngreso, t.apellidos+' '+t.nombre,
p.razon_social, i.fecha, i.tipo_comprobante,
i.serie, i.correlativo, i.estado
Order By i.idIngreso Desc
GO

--Mostrar Ingresos entre Fechas
Create Proc SpBuscar_Ingreso_Fecha
@textBuscar varchar(20),
@textBuscar2 varchar(20)
AS
Select i.idIngreso, (t.apellidos+' '+t.nombre) as Trabajador,
p.razon_social as Proveedor, i.fecha, i.tipo_comprobante,
i.serie, i.correlativo, i.estado, SUM(d.precio_compra*d.stock_inicial) as Total
From Detalle_ingreso d inner join Ingreso i
on d.idIngreso = i.idIngreso inner join Proveedor p
on i.idProveedor = p.idProveedor inner join Trabajador t
on  i.idTrabajador = t.idTrabajador
GROUP BY
i.idIngreso, t.apellidos+' '+t.nombre,
p.razon_social, i.fecha, i.tipo_comprobante,
i.serie, i.correlativo, i.estado
Having i.fecha>=@textBuscar and i.fecha<=@textBuscar2
Go

--Procediminto insertar ingreso
Create proc SpInsertar_ingreso
@idIngreso int = null output,
@idTrabajador int,
@idProveedor int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(4),
@correlativo varchar(7),
@igv decimal(4,2),
@estado varchar(7)
AS
insert Into Ingreso (idTrabajador, idProveedor, fecha, tipo_comprobante,
serie, correlativo, igv, dbo.Ingreso.estado)
values(@idTrabajador, @idProveedor, @fecha,@tipo_comprobante,
@serie, @correlativo, @igv, @estado)
--Obtener el Codigo autoGenerado
Set @idIngreso = @@IDENTITY
Go

--Procedimiento anular ingreso
Create Proc SpAnular_ingreso
@idIngreso int
as
UPDATE Ingreso Set estado= 'ANULADO'
Where idIngreso = @idIngreso
Go

--Procedimiento para insertar los detalles de ingreso
Create Proc SpInsertar_detalle_ingreso
@idDetalle_ingreso int output,
@idIngreso int,
@idArticulo int,
@precio_compra money,
@precio_venta money,
@stock_inicial int,
@stock_actual int,
@fecha_produccion date,
@fecha_vencimiento date
AS
Insert Into Detalle_ingreso(idIngreso, idArticulo, precio_compra, precio_venta,
stock_inicial, stock_actual, fecha_produccion, fecha_vencimiento)
Values (@idIngreso, @idArticulo, @precio_compra, @precio_venta,
@stock_inicial, @stock_actual, @fecha_produccion, @fecha_vencimiento)
Go

--Mostrar Detalles de Ingreso
Create Proc SpMostrar_detalle_ingreso
@textBuscar int
AS
Select d.idArticulo, a.nombre as Articulo, d.precio_compra,
d.precio_venta, d.stock_inicial, d.fecha_produccion,
d.fecha_vencimiento,(d.stock_inicial*d.precio_compra) as SubTotal
From detalle_ingreso d inner join Articulo a
on d.idArticulo = a.idArticulo
where d.idIngreso = @textBuscar
GO