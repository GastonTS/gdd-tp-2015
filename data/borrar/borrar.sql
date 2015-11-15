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


DROP PROCEDURE �UFLO.LogearUsuario
GO

DROP PROCEDURE �UFLO.HabilitarUsuario 
GO


DROP PROCEDURE �UFLO.AltaAeronave
GO

DROP PROCEDURE �UFLO.ActualizarAeronave
GO

DROP PROCEDURE �UFLO.AgregarButaca
GO

DROP PROCEDURE �UFLO.FiltroAeronave
GO

DROP PROCEDURE �UFLO.BajaPorVidaUtil
GO

DROP PROCEDURE �UFLO.BajaFueraDeServicio
GO

DROP PROCEDURE �UFLO.CancelarPasajesDe
GO

DROP PROCEDURE �UFLO.ReemplazarAeronavePara
GO

DROP PROCEDURE �UFLO.PesoDisponible
GO

DROP PROCEDURE �UFLO.MillasTotalesDe
GO

DROP PROCEDURE �UFLO.ViajesDisponiblesPara
GO

DROP PROCEDURE �UFLO.PasajesYEncomiendasDe
GO

DROP PROCEDURE �UFLO.ButacasDisponibles
GO

DROP PROCEDURE �UFLO.ExpirarMillas
GO

DROP PROCEDURE �UFLO.DetallePasajePara
GO

DROP PROCEDURE �UFLO.DetalleAeronavesVaciasPara
GO

DROP PROCEDURE �UFLO.DetalleMillasDe
GO

DROP PROCEDURE �UFLO.DetalleMillasPara
GO

DROP PROCEDURE �UFLO.DetalleCancelacionesPara
GO

DROP PROCEDURE �UFLO.DetalleServicioTecnicoPara
GO

DROP PROCEDURE �UFLO.TOP5DestinoPasajesComprados
GO

DROP PROCEDURE �UFLO.TOP5DestinoAeronavesVacias
GO

DROP PROCEDURE �UFLO.TOP5MillasDeClientes
GO

DROP PROCEDURE �UFLO.TOP5DestinoCancelaciones
GO

DROP PROCEDURE �UFLO.TOP5DiasFueraDeServicio
GO

DROP PROCEDURE �UFLO.DestinoOrigen
GO

DROP PROCEDURE �UFLO.CiudadTipoServicio
GO

/********************************************/
/***************** Functions ****************/
/********************************************/

DROP FUNCTION �UFLO.MillasPorClienteCarga
GO

/********************************************/
/******************* Views ******************/
/********************************************/

DROP VIEW �UFLO.VRutaAerea
GO

DROP VIEW �UFLO.DetallePasajes
GO

DROP VIEW �UFLO.DetalleAeronavesVacias
GO

DROP VIEW �UFLO.DetalleMillas
GO

DROP VIEW �UFLO.DetalleCancelaciones
GO

DROP VIEW �UFLO.DetalleServiciosTecnicos
GO

DROP SCHEMA [�UFLO]
GO