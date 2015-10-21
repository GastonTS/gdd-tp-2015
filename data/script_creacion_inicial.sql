USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE SCHEMA [ÑUFLO] AUTHORIZATION gd
GO


/****CREACION DE TABLAS****/
CREATE TABLE ÑUFLO.Ciudad (
	id_ciudad int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255)
	)
GO

CREATE TABLE ÑUFLO.Ruta_Aerea (
	id_ruta int IDENTITY(1,1) PRIMARY KEY,
	id_ciudad_origen int REFERENCES ÑUFLO.Ciudad,
	id_ciudad_destino int REFERENCES ÑUFLO.Ciudad,
	precio_base_por_peso numeric(18,2),
	precio_base_por_pasaje numeric(18,2),
	tipo_servicio nvarchar(255)
	)
GO
	
CREATE TABLE ÑUFLO.Aeronave (
	id_aeronave int IDENTITY(1,1) PRIMARY KEY,
	modelo nvarchar(255),
	matricula nvarchar(255) UNIQUE,
	fabricante nvarchar(255),
	tipo_de_servicio nvarchar(255),
	fecha_de_alta datetime,
	capacidad_peso_encomiendas numeric(18,0),
	baja_vida_utill datetime
	)
GO
	
CREATE TABLE ÑUFLO.ButacaPorAvion (
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	id_butaca int REFERENCES ÑUFLO.Ruta_Aerea,
	ocupada bit,
	PRIMARY KEY(id_aeronave, id_butaca)
	)
GO

CREATE TABLE ÑUFLO.Butaca (
	id_butaca int PRIMARY KEY,
	numero_de_butaca numeric(18,0),
	tipo_butaca nvarchar(255)
	)
GO
	
CREATE TABLE ÑUFLO.ServicioTecnico (
	id_servicio int PRIMARY KEY,
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	fecha_fuera_de_servicio datetime,
	fecha_reinicio_de_servicio datetime
	)
GO

ALTER TABLE ÑUFLO.Aeronave
	ADD baja_por_fuera_de_servicio int REFERENCES ÑUFLO.ServicioTecnico
GO
	
CREATE TABLE ÑUFLO.Viaje (
	id_viaje int IDENTITY(1,1) PRIMARY KEY,
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	id_ruta int REFERENCES ÑUFLO.Ruta_Aerea,
	peso_ocupado numeric(18,0),
	fecha_salida datetime,
	fecha_llegada datetime,
	fecha_llegada_estimada datetime
	)
GO

CREATE TABLE ÑUFLO.Cliente (
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

CREATE TABLE ÑUFLO.Milla (
	id_milla int PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_obtencion datetime,
	cantidad int
	)
GO
	
CREATE TABLE ÑUFLO.Producto (
	id_producto int PRIMARY KEY,
	millas_necesarias int,
	stock int,
	descripcion nvarchar(510)
	)
GO

CREATE TABLE ÑUFLO.Canje (
	id_canje int PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	id_Producto int REFERENCES ÑUFLO.Producto,
	cantidad int,
	fecha_de_canje datetime
	)
GO

CREATE TABLE ÑUFLO.Compra (
	codigo_de_compra int PRIMARY KEY,
	id_viaje int REFERENCES ÑUFLO.Viaje,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_compra datetime
	)
GO
	
CREATE TABLE ÑUFLO.PasajeEncomienda (
	id_pasaje_encomienda numeric(18,0) PRIMARY KEY,
	codigo_de_compra  int REFERENCES ÑUFLO.Compra,
	id_cliente  int REFERENCES ÑUFLO.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0),
	cancelado bit
	)
GO

CREATE TABLE ÑUFLO.Cancelacion (
	id_cancelacion int PRIMARY KEY,
	codigo_de_compra int REFERENCES ÑUFLO.Compra
	)
GO

CREATE TABLE ÑUFLO.PasajeEncomiendaPorCancelacion (
	id_pasaje_encomienda numeric(18,0) REFERENCES ÑUFLO.PasajeEncomienda,
	id_cancelacion int REFERENCES ÑUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255),
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
	)
GO

/**** MIGRACION *****/

INSERT INTO ÑUFLO.Ciudad (nombre) 
	SELECT (Ruta_Ciudad_Origen) FROM gd_esquema.Maestra
	GROUP BY Ruta_Ciudad_Origen
	UNION
	SELECT Ruta_Ciudad_Destino FROM gd_esquema.Maestra
	GROUP BY Ruta_Ciudad_Destino
GO