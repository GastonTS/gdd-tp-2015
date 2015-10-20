USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE SCHEMA [gd_ñuflo]
GO

CREATE TABLE gd_ñuflo.Ciudad (
	id_ciudad int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255)
	)
GO

CREATE TABLE gd_ñuflo.Ruta_Aerea (
	id_ruta int IDENTITY(1,1) PRIMARY KEY,
	id_ciudad_origen int REFERENCES gd_ñuflo.Ciudad,
	id_ciudad_destino int REFERENCES gd_ñuflo.Ciudad,
	precio_base_por_peso numeric(18,2),
	precio_base_por_pasaje numeric(18,2)
	)
GO
	
CREATE TABLE gd_ñuflo.Viaje (
	id_viaje int IDENTITY(1,1) PRIMARY KEY,
	id_aeronave int REFERENCES gd_ñuflo.Aeronave,
	id_ruta int REFERENCES gd_ñuflo.Ruta_Aerea,
	peso_ocupado numeric(18,0),
	fecha_salida datetime,
	fecha_llegada datetime,
	fecha_llegada_estimada datetime
	)
GO
	
CREATE TABLE gd_ñuflo.Aeronave (
	id_aeronave int IDENTITY(1,1) PRIMARY KEY,
	modelo nvarchar(255),
	matricula nvarchar(255) UNIQUE,
	fabricante nvarchar(255),
	tipo_de_servicio nvarchar(255),
	fecha_de_alta datetime,
	capacidad_peso_encomiendas numeric(18,0),
	baja_vida_utill datetime,
	baja_por_fuera_de_servicio int REFERENCES gd_ñuflo.ServicioTecnico
	)
GO
	
CREATE TABLE gd_ñuflo.ButacaPorAvion (
	id_aeronave int REFERENCES gd_ñuflo.Aeronave,
	id_butaca int REFERENCES gd_ñuflo.Ruta_Aerea,
	ocupada bit,
	PRIMARY KEY(id_aeronave, id_butaca)
	)
GO

CREATE TABLE gd_ñuflo.Butaca (
	id_butaca int PRIMARY KEY,
	numero_de_butaca numeric(18,0),
	tipo_butaca nvarchar(255)
	)
GO
	
CREATE TABLE gd_ñuflo.ServicioTecnico (
	id_servicio int PRIMARY KEY,
	id_aeronave int REFERENCES gd_ñuflo.Aeronave.
	fecha_fuera_de_servicio datetime,
	fecha_reinicio_de_servicio datetime
	)
GO

CREATE TABLE gd_ñuflo.Milla (
	id_milla int PRIMARY KEY,
	id_cliente int REFERENCES gd_ñuflo.Cliente,
	fecha_de_obtencion datetime,
	cantidad int
	)
GO

CREATE TABLE gd_ñuflo.Canje (
	id_canje int PRIMARY KEY,
	id_cliente int REFERENCES gd_ñuflo.Cliente,
	id_Producto int REFERENCES gd_ñuflo.Producto,
	cantidad int,
	fecha_de_canje datetime
	)
GO
	
CREATE TABLE gd_ñuflo.Producto (
	id_producto int PRIMARY KEY,
	millas_necesarias int,
	stock int,
	descripcion nvarchar(510)
	)
GO

CREATE TABLE gd_ñuflo.Cliente (
	id_cliente int PRIMARY KEY,
	dni numeric(18, 0),
	nombre nvarchar(255),
	apellido nvarchar(255),
	direccion nvarchar(255),
	telefono numeric(18, 0),
	mail nvarchar(255),
	fecha_de_nacimiento datetime
	)
GO

CREATE TABLE gd_ñuflo.Compra (
	codigo_de_compra int PRIMARY KEY,
	id_viaje int /*REFERENCES gd_ñuflo.Viaje*/,
	id_cliente int REFERENCES gd_ñuflo.Cliente,
	fecha_de_compra datetime
	)
GO
	
CREATE TABLE gd_ñuflo.PasajeEncomienda (
	id_pasaje_encomienda numeric(18,0) PRIMARY KEY,
	codigo_de_compra  int REFERENCES gd_ñuflo.Compra,
	id_cliente  int REFERENCES gd_ñuflo.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0),
	cancelado bit
	)
GO

CREATE TABLE gd_ñuflo.PasajeEncomiendaPorCancelacion (
	id_pasaje_encomienda int REFERENCES gd_ñuflo.PasajeEncomienda,
	id_cancelacion int REFERENCES gd_ñuflo.Cancelacion,
	motivo_cancelacion  nvarchar(255),
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
	)
GO

CREATE TABLE gd_ñuflo.Cancelacion (
	id_cancelacion int PRIMARY KEY,
	codigo_de_compra int REFERENCES gd_ñuflo.Compra
	)
GO