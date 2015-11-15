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


DROP PROCEDURE ÑUFLO.LogearUsuario
GO

DROP PROCEDURE ÑUFLO.HabilitarUsuario 
GO


DROP PROCEDURE ÑUFLO.AltaAeronave
GO

DROP PROCEDURE ÑUFLO.ActualizarAeronave
GO

DROP PROCEDURE ÑUFLO.AgregarButaca
GO

DROP PROCEDURE ÑUFLO.FiltroAeronave
GO

DROP PROCEDURE ÑUFLO.BajaPorVidaUtil
GO

DROP PROCEDURE ÑUFLO.BajaFueraDeServicio
GO

DROP PROCEDURE ÑUFLO.CancelarPasajesDe
GO

DROP PROCEDURE ÑUFLO.ReemplazarAeronavePara
GO

DROP PROCEDURE ÑUFLO.PesoDisponible
GO

DROP PROCEDURE ÑUFLO.MillasTotalesDe
GO

DROP PROCEDURE ÑUFLO.ViajesDisponiblesPara
GO

DROP PROCEDURE ÑUFLO.PasajesYEncomiendasDe
GO

DROP PROCEDURE ÑUFLO.ButacasDisponibles
GO

DROP PROCEDURE ÑUFLO.ExpirarMillas
GO

DROP PROCEDURE ÑUFLO.DetallePasajePara
GO

DROP PROCEDURE ÑUFLO.DetalleAeronavesVaciasPara
GO

DROP PROCEDURE ÑUFLO.DetalleMillasDe
GO

DROP PROCEDURE ÑUFLO.DetalleMillasPara
GO

DROP PROCEDURE ÑUFLO.DetalleCancelacionesPara
GO

DROP PROCEDURE ÑUFLO.DetalleServicioTecnicoPara
GO

DROP PROCEDURE ÑUFLO.TOP5DestinoPasajesComprados
GO

DROP PROCEDURE ÑUFLO.TOP5DestinoAeronavesVacias
GO

DROP PROCEDURE ÑUFLO.TOP5MillasDeClientes
GO

DROP PROCEDURE ÑUFLO.TOP5DestinoCancelaciones
GO

DROP PROCEDURE ÑUFLO.TOP5DiasFueraDeServicio
GO

DROP PROCEDURE ÑUFLO.DestinoOrigen
GO

DROP PROCEDURE ÑUFLO.CiudadTipoServicio
GO

/********************************************/
/***************** Functions ****************/
/********************************************/

DROP FUNCTION ÑUFLO.MillasPorClienteCarga
GO

/********************************************/
/******************* Views ******************/
/********************************************/

DROP VIEW ÑUFLO.VRutaAerea
GO

DROP VIEW ÑUFLO.DetallePasajes
GO

DROP VIEW ÑUFLO.DetalleAeronavesVacias
GO

DROP VIEW ÑUFLO.DetalleMillas
GO

DROP VIEW ÑUFLO.DetalleCancelaciones
GO

DROP VIEW ÑUFLO.DetalleServiciosTecnicos
GO

DROP SCHEMA [ÑUFLO]
GO