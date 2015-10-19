SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [Ñuflo]

CREATE TABLE gd_ñuflo.Ciudad (
	id_ciudad INT IDENTITY(1,1) PRIMARY KEY,
	nombre NVARCHAR(255)
	)

CREATE TABLE gd_ñuflo.Ruta_Aerea (
	id_ruta INT PRIMARY KEY,
	id_ciudad_origen INT REFERENCES gd_ñuflo.Ciudad,
	id_ciudad_destino INT REFERENCES gd_ñuflo.Ciudad,
	precio_base_por_peso NUMERIC(18,2),
	precio_base_por_pasaje NUMERIC(18,2),
	)

INSERT INTO gd_ñuflo.Ciudad (nombre) 
	SELECT (Ruta_Ciudad_Origen) FROM GD2C2015.gd_esquema.Maestra
	GROUP BY Ruta_Ciudad_Origen
	UNION
	SELECT Ruta_Ciudad_Destino FROM GD2C2015.gd_esquema.Maestra
	GROUP BY Ruta_Ciudad_Destino


CREATE TABLE gd_ñuflo.Producto (
	id_producto INT PRIMARY KEY,
	millas_necesarias INT,
	stock INT,
	descripcion NVARCHAR(510),
	)

CREATE TABLE gd_ñuflo.Canje (
	id_canje INT PRIMARY KEY,
	id_cliente INT REFERENCES gd_ñuflo.Cliente,
	id_Producto INT REFERENCES gd_ñuflo.Producto,
	cantidad INT,
	fecha_de_canje DATETIME,
	)


CREATE TABLE gd_ñuflo.Milla (
	id_milla INT PRIMARY KEY,
	id_cliente INT REFERENCES gd_ñuflo.Cliente,
	fecha_de_obtencion DATETIME,
	cantidad INT,
	)


CREATE TABLE gd_ñuflo.Cliente (
	id_cliente INT PRIMARY KEY,
	dni numeric(18, 0),
	nombre nvarchar(255),
	apellido nvarchar(255),
	direccion nvarchar(255),
	telefono numeric(18, 0),
	mail nvarchar(255),
	fecha_de_nacimiento DATETIME,
	)



CREATE TABLE gd_ñuflo.PasajeEncomienda (
	id_pasaje_encomienda INT PRIMARY KEY,
	codigo_de_compra  INT REFERENCES gd_ñuflo.Compra,
	id_cliente  INT REFERENCES gd_ñuflo.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0),
	cancelado BIT,
	)

CREATE TABLE gd_ñuflo.PasajeEncomienda (
	id_pasaje_encomienda INT PRIMARY KEY,
	codigo_de_compra  INT REFERENCES gd_ñuflo.Compra,
	id_cliente  INT REFERENCES gd_ñuflo.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0),
	cancelado BIT,
	)


CREATE TABLE gd_ñuflo.PasajeEncomiendaCancelacion (
	id_pasaje_encomienda INT REFERENCES gd_ñuflo.PasajeEncomienda,
	id_cancelacion INT REFERENCES gd_ñuflo.Cancelacion,
	motivo_cancelacion  nvarchar(255),
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
	)


CREATE TABLE gd_ñuflo.PasajeEncomiendaCancelacion (
	id_cancelacion INT PRIMARY KEY,
	codigo_de_compra INT REFERENCES gd_ñuflo.Compra,
	)


CREATE TABLE gd_ñuflo.Compra (
	codigo_de_compra INT PRIMARY KEY,
	id_viaje INT /*REFERENCES gd_ñuflo.Viaje*/,
	id_cliente INT REFERENCES gd_ñuflo.Cliente,
	fecha_de_compra DATETIME,
	)
