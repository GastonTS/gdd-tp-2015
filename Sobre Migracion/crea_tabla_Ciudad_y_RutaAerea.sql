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
