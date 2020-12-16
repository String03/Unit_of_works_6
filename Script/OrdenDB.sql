USE MASTER
GO
CREATE DATABASE ORDENDB
GO
USE ORDENDB
GO
CREATE TABLE Producto(
	id int primary key identity(1,1),
	precio_unitario decimal,
	nombre varchar(100),
	cantidad_stock int
)
GO

CREATE TABLE Orden(
	id int primary key identity(1,1),
	fecha_reg date
)
GO

CREATE TABLE DetalleOrden(
	id int primary key identity(1,1),
	producto_id int,
	orden_id int,
	cantidad int,
	precio money,
	foreign key (producto_id) references producto(id),
	foreign key (orden_id) references orden(id)

)
GO