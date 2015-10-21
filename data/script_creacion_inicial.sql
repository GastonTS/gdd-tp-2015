USE GD2C2015
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****CREACION DE SCHEMA****/
CREATE SCHEMA NIUFLO AUTHORIZATION gd
GO

/****CREACION DE TABLAS****/
CREATE TABLE NIUFLO.Ciudad (
	id_ciudad int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255)
	)
GO

CREATE TABLE NIUFLO.Ruta_Aerea (
	id_ruta int IDENTITY(1,1) PRIMARY KEY,
	id_ciudad_origen int REFERENCES NIUFLO.Ciudad,
	id_ciudad_destino int REFERENCES NIUFLO.Ciudad,
	precio_base_por_peso numeric(18,2),
	precio_base_por_pasaje numeric(18,2)
	tipo_servicio nvarchar(255)
	)
GO
	
CREATE TABLE NIUFLO.Aeronave (
	id_aeronave int IDENTITY(1,1) PRIMARY KEY,
	modelo nvarchar(255),
	matricula nvarchar(255) UNIQUE,
	fabricante nvarchar(255),
	tipo_de_servicio nvarchar(255),
	fecha_de_alta datetime,
	capacidad_peso_encomiendas numeric(18,0),
	baja_vida_utill datetime,
	)
GO
	
CREATE TABLE NIUFLO.ButacaPorAvion (
	id_aeronave int REFERENCES NIUFLO.Aeronave,
	id_butaca int REFERENCES NIUFLO.Ruta_Aerea,
	ocupada bit,
	PRIMARY KEY(id_aeronave, id_butaca)
	)
GO

CREATE TABLE NIUFLO.Butaca (
	id_butaca int PRIMARY KEY,
	numero_de_butaca numeric(18,0),
	tipo_butaca nvarchar(255)
	)
GO
	
CREATE TABLE NIUFLO.ServicioTecnico (
	id_servicio int PRIMARY KEY,
	id_aeronave int REFERENCES NIUFLO.Aeronave,
	fecha_fuera_de_servicio datetime,
	fecha_reinicio_de_servicio datetime
	)
GO

ALTER TABLE NIUFLO.Aeronave
	ADD baja_por_fuera_de_servicio int REFERENCES NIUFLO.ServicioTecnico
GO
	
CREATE TABLE NIUFLO.Viaje (
	id_viaje int IDENTITY(1,1) PRIMARY KEY,
	id_aeronave int REFERENCES NIUFLO.Aeronave,
	id_ruta int REFERENCES NIUFLO.Ruta_Aerea,
	peso_ocupado numeric(18,0),
	fecha_salida datetime,
	fecha_llegada datetime,
	fecha_llegada_estimada datetime
	)
GO

CREATE TABLE NIUFLO.Cliente (
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

CREATE TABLE NIUFLO.Milla (
	id_milla int PRIMARY KEY,
	id_cliente int REFERENCES NIUFLO.Cliente,
	fecha_de_obtencion datetime,
	cantidad int
	)
GO
	
CREATE TABLE NIUFLO.Producto (
	id_producto int PRIMARY KEY,
	millas_necesarias int,
	stock int,
	descripcion nvarchar(510)
	)
GO

CREATE TABLE NIUFLO.Canje (
	id_canje int PRIMARY KEY,
	id_cliente int REFERENCES NIUFLO.Cliente,
	id_Producto int REFERENCES NIUFLO.Producto,
	cantidad int,
	fecha_de_canje datetime
	)
GO

CREATE TABLE NIUFLO.Compra (
	codigo_de_compra int PRIMARY KEY,
	id_viaje int REFERENCES NIUFLO.Viaje,
	id_cliente int REFERENCES NIUFLO.Cliente,
	fecha_de_compra datetime
	)
GO
	
CREATE TABLE NIUFLO.PasajeEncomienda (
	id_pasaje_encomienda numeric(18,0) PRIMARY KEY,
	codigo_de_compra  int REFERENCES NIUFLO.Compra,
	id_cliente  int REFERENCES NIUFLO.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0),
	cancelado bit
	)
GO

CREATE TABLE NIUFLO.Cancelacion (
	id_cancelacion int PRIMARY KEY,
	codigo_de_compra int REFERENCES NIUFLO.Compra
	)
GO

CREATE TABLE NIUFLO.PasajeEncomiendaPorCancelacion (
	id_pasaje_encomienda numeric(18,0) REFERENCES NIUFLO.PasajeEncomienda,
	id_cancelacion int REFERENCES NIUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255),
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
	)
GO

/**** MIGRACION *****/

INSERT INTO NIUFLO.Ciudad (nombre) 
	SELECT (Ruta_Ciudad_Origen) FROM gd_esquema.Maestra
	GROUP BY Ruta_Ciudad_Origen
	UNION
	SELECT Ruta_Ciudad_Destino FROM gd_esquema.Maestra
	GROUP BY Ruta_Ciudad_Destino
GO