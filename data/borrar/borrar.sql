USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/********************************************/
/****************** Tables ******************/
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
/************* Stored Procedures ************/
/********************************************/

/********************************************/
/***************** Functions ****************/
/********************************************/

DROP FUNCTION �UFLO.ButacasDisponibles
GO

DROP FUNCTION �UFLO.PesoDisponible
GO

DROP FUNCTION �UFLO.DetalleMillasDe
GO

DROP FUNCTION �UFLO.MillasTotalesDe
GO

DROP FUNCTION �UFLO.MillasPorClienteCarga
GO

DROP FUNCTION �UFLO.PasajesYEncomiendasDe
GO

DROP FUNCTION �UFLO.ViajesDisponiblesPara
GO

DROP FUNCTION �UFLO.DetallePasajePara
GO

DROP FUNCTION �UFLO.TOP5DestinoPasajesComprados
GO

DROP FUNCTION �UFLO.DetalleAeronavesVaciasPara
GO

DROP FUNCTION �UFLO.TOP5DestinoAeronavesVacias
GO

DROP FUNCTION �UFLO.DetalleMillasPara
GO

DROP FUNCTION �UFLO.TOP5MillasDeClientes
GO

DROP FUNCTION �UFLO.DetalleCancelacionesPara
GO

DROP FUNCTION �UFLO.TOP5DestinoCancelaciones
GO

DROP FUNCTION �UFLO.DetalleServicioTecnicoPara
GO

DROP FUNCTION �UFLO.TOP5DiasFueraDeServicio
GO

/********************************************/
/******************* Views ******************/
/********************************************/

DROP VIEW �UFLO.VRutaAerea
GO

DROP SCHEMA [�UFLO]
GO

