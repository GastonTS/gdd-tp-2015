USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP TABLE �UFLO.PasajeEncomiendaPorCancelacion
GO

DROP TABLE �UFLO.Cancelacion
GO
	
DROP TABLE �UFLO.PasajeEncomienda
GO

DROP TABLE �UFLO.Compra
GO

DROP TABLE �UFLO.Canje
GO
	
DROP TABLE �UFLO.Producto
GO

DROP TABLE �UFLO.Milla
GO

DROP TABLE �UFLO.Cliente
GO
	
DROP TABLE �UFLO.Viaje
GO
		
ALTER TABLE �UFLO.Aeronave
	DROP CONSTRAINT fk_baja_por_fuera_de_servicio
GO

DROP TABLE �UFLO.ServicioTecnico
GO

DROP TABLE �UFLO.ButacaPorAvion
GO

DROP TABLE �UFLO.Tipo_Butaca
GO

DROP TABLE �UFLO.Aeronave
GO

DROP TABLE �UFLO.Ruta_Aerea
GO

DROP TABLE �UFLO.Ciudad
GO
	
DROP SCHEMA [�UFLO]
GO