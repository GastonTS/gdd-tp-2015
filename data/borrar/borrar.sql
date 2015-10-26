USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/********************************************/
/****************** Tablas ******************/
/********************************************/
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

DROP TABLE �UFLO.TipoButaca
GO

DROP TABLE �UFLO.Aeronave
GO

DROP TABLE �UFLO.ServicioPorRuta
GO

DROP TABLE �UFLO.RutaAerea
GO

DROP TABLE �UFLO.TipoServicio

DROP TABLE �UFLO.Ciudad
GO

DROP TABLE �UFLO.Usuario
GO

DROP TABLE �UFLO.FuncionalidadPorRol
GO

DROP TABLE �UFLO.Funcionalidad
GO

DROP TABLE �UFLO.Rol
GO


/********************************************/
/************* Store Procedure **************/
/********************************************/

DROP PROCEDURE �UFLO.ButacasDisponibles
GO

/********************************************/
/***************** Function *****************/
/********************************************/

DROP FUNCTION �UFLO.PesoDisponible
GO

DROP SCHEMA [�UFLO]
GO