--Reestablecer el Stock despues de Eliminar la venta y sus detalles
Create Trigger TrReestablecer_stock
On [detalle_venta]
for delete
AS
update di set di.stock_actual = di.stock_actual + dv.cantidad
From Detalle_ingreso AS di Inner Join
deleted AS dv on di.idDetalle_ingreso = dv.idDetalle_ingreso
GO