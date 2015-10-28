USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/********************************************/
/****************** Tables ******************/
/********************************************/
DROP TABLE ÑUFLO.PasajeEncomiendaPorCancelacion
GO

DROP TABLE ÑUFLO.Cancelacion
GO
	
DROP TABLE ÑUFLO.PasajeEncomienda
GO

DROP TABLE ÑUFLO.Compra
GO

DROP TABLE ÑUFLO.Canje
GO
	
DROP TABLE ÑUFLO.Producto
GO

DROP TABLE ÑUFLO.Milla
GO

DROP TABLE ÑUFLO.Cliente
GO
	
DROP TABLE ÑUFLO.Viaje
GO
		
ALTER TABLE ÑUFLO.Aeronave
	DROP CONSTRAINT fk_baja_por_fuera_de_servicio
GO

DROP TABLE ÑUFLO.ServicioTecnico
GO

DROP TABLE ÑUFLO.ButacaPorAvion
GO

DROP TABLE ÑUFLO.TipoButaca
GO

DROP TABLE ÑUFLO.Aeronave
GO

DROP TABLE ÑUFLO.ServicioPorRuta
GO

DROP TABLE ÑUFLO.RutaAerea
GO

DROP TABLE ÑUFLO.TipoServicio

DROP TABLE ÑUFLO.Ciudad
GO

DROP TABLE ÑUFLO.Usuario
GO

DROP TABLE ÑUFLO.FuncionalidadPorRol
GO

DROP TABLE ÑUFLO.Funcionalidad
GO

DROP TABLE ÑUFLO.Rol
GO


/********************************************/
/************* Stored Procedures ************/
/********************************************/

/********************************************/
/***************** Functions ****************/
/********************************************/

DROP FUNCTION ÑUFLO.ButacasDisponibles
GO

DROP FUNCTION ÑUFLO.PesoDisponible
GO

DROP FUNCTION ÑUFLO.MillasPorClienteCarga
GO

DROP FUNCTION ÑUFLO.PasajeConDestinoEnFechas
GO

DROP FUNCTION ÑUFLO.TOP5DestinosPasajesComprados
GO

DROP FUNCTION ÑUFLO.DetallePasajesPara
GO

/********************************************/
/******************* Views ******************/
/********************************************/

DROP VIEW ÑUFLO.VRutaAerea
GO

DROP SCHEMA [ÑUFLO]
GO

