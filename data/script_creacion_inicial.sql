﻿USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE SCHEMA [ÑUFLO] AUTHORIZATION gd
GO

/*****************************************************************/
/***********************CREACION DE TABLAS************************/
/*****************************************************************/

CREATE TABLE ÑUFLO.Ciudad (
	id_ciudad int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255) NOT NULL
	)
GO

CREATE TABLE ÑUFLO.TipoServicio (
	id_tipo_servicio int IDENTITY(1,1) PRIMARY KEY,
	tipo_servicio nvarchar(255) NOT NULL,
	porcentaje_recargo numeric(18,2) NOT NULL
	)
GO


INSERT INTO ÑUFLO.TipoServicio(tipo_servicio, porcentaje_recargo) values ('Primera Clase', 2)
INSERT INTO ÑUFLO.TipoServicio(tipo_servicio, porcentaje_recargo) values ('Ejecutivo', 1.5)
INSERT INTO ÑUFLO.TipoServicio(tipo_servicio, porcentaje_recargo) values ('Turista', 1.2)
GO

CREATE TABLE ÑUFLO.RutaAerea (
	id_ruta int IDENTITY(1,1) PRIMARY KEY,
	codigo_ruta numeric(18,0) NOT NULL, --XXX
	id_ciudad_origen int REFERENCES ÑUFLO.Ciudad NOT NULL,
	id_ciudad_destino int REFERENCES ÑUFLO.Ciudad NOT NULL,
	precio_base_por_peso numeric(18,2) NOT NULL,
	precio_base_por_pasaje numeric(18,2) NOT NULL,
	)
GO

CREATE TABLE ÑUFLO.ServicioPorRuta (
	id_ruta int REFERENCES ÑUFLO.RutaAerea,
	id_tipo_servicio int REFERENCES ÑUFLO.TipoServicio,
	PRIMARY KEY(id_ruta, id_tipo_servicio)
	)
GO

CREATE TABLE ÑUFLO.Aeronave (
	id_aeronave int IDENTITY(1,1) PRIMARY KEY,
	modelo nvarchar(255) NOT NULL,
	matricula nvarchar(255) UNIQUE NOT NULL,
	fabricante nvarchar(255) NOT NULL,
	id_tipo_servicio int REFERENCES ÑUFLO.TipoServicio,
	fecha_de_alta datetime NOT NULL, --XXX
	capacidad_peso_encomiendas numeric(18,0) NOT NULL,
	baja_vida_utill datetime,
	baja_por_fuera_de_servicio int 
	)
GO

CREATE TABLE ÑUFLO.TipoButaca (
	id_tipo_butaca int IDENTITY(1,1) PRIMARY KEY,
	tipo_butaca nvarchar(255) NOT NULL
	)
GO

INSERT INTO ÑUFLO.TipoButaca(tipo_butaca) values ('Ventanilla')
INSERT INTO ÑUFLO.TipoButaca(tipo_butaca) values ('Pasillo')
GO
	
CREATE TABLE ÑUFLO.ButacaPorAvion (
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	numero_de_butaca numeric(18,0),
	id_tipo_butaca int REFERENCES ÑUFLO.TipoButaca,
	PRIMARY KEY(id_aeronave, numero_de_butaca)
	)
GO

CREATE TABLE ÑUFLO.ServicioTecnico (
	id_servicio int IDENTITY(1,1) PRIMARY KEY,
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	fecha_fuera_de_servicio datetime NOT NULL,
	fecha_reinicio_de_servicio datetime
	)
GO

ALTER TABLE ÑUFLO.Aeronave
	ADD CONSTRAINT fk_baja_por_fuera_de_servicio FOREIGN KEY (baja_por_fuera_de_servicio) REFERENCES ÑUFLO.ServicioTecnico
GO
	
CREATE TABLE ÑUFLO.Viaje (
	id_viaje int IDENTITY(1,1) PRIMARY KEY,
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	id_ruta int REFERENCES ÑUFLO.RutaAerea,
	peso_ocupado numeric(18,0) NOT NULL,
	fecha_salida datetime NOT NULL,
	fecha_llegada datetime,
	fecha_llegada_estimada datetime NOT NULL
	)
GO

CREATE TABLE ÑUFLO.Cliente (
	id_cliente int IDENTITY(1,1) PRIMARY KEY,
	dni numeric(18, 0) NOT NULL,
	nombre nvarchar(255) NOT NULL,
	apellido nvarchar(255) NOT NULL,
	direccion nvarchar(255) NOT NULL,
	telefono numeric(18, 0) NOT NULL,
	mail nvarchar(255),
	fecha_de_nacimiento datetime NOT NULL,
	CHECK(fecha_de_nacimiento < GETDATE())
	)
GO

CREATE TABLE ÑUFLO.Milla (
	id_milla int IDENTITY(1,1) PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_obtencion datetime DEFAULT GETDATE(),
	cantidad int DEFAULT 0,
	cantidad_gastada int DEFAULT 0,
	expirado bit DEFAULT 0
	)
GO
	
CREATE TABLE ÑUFLO.Producto (
	id_producto int IDENTITY(1,1) PRIMARY KEY,
	millas_necesarias int NOT NULL,
	stock int NOT NULL,
	descripcion nvarchar(255) NOT NULL
	)
GO

CREATE TABLE ÑUFLO.Canje (
	id_canje int IDENTITY(1,1) PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	id_Producto int REFERENCES ÑUFLO.Producto,
	cantidad int NOT NULL,
	fecha_de_canje datetime NOT NULL
	)
GO

CREATE TABLE ÑUFLO.Compra (
	codigo_de_compra int IDENTITY(1,1) PRIMARY KEY,
	id_viaje int REFERENCES ÑUFLO.Viaje,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_compra datetime NOT NULL
	)
GO
	
CREATE TABLE ÑUFLO.PasajeEncomienda (
	id_pasaje_encomienda int PRIMARY KEY,
	codigo_de_compra  int REFERENCES ÑUFLO.Compra,
	id_cliente  int REFERENCES ÑUFLO.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0), 
	cancelado bit DEFAULT 0,
	precio numeric(18,2) NOT NULL,
	CHECK ((peso_encomienda IS NOT NULL) OR (numero_de_butaca IS NOT NULL)
			AND NOT (peso_encomienda IS NOT NULL) AND (numero_de_butaca IS NOT NULL))
	)
GO

CREATE TABLE ÑUFLO.Cancelacion (
	id_cancelacion int IDENTITY(1,1) PRIMARY KEY,
	codigo_de_compra int REFERENCES ÑUFLO.Compra,
	fecha_devolucion datetime
	)
GO

CREATE TABLE ÑUFLO.PasajeEncomiendaPorCancelacion (
	id_pasaje_encomienda INT REFERENCES ÑUFLO.PasajeEncomienda,
	id_cancelacion int REFERENCES ÑUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255) NOT NULL,
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
	)
GO

CREATE TABLE ÑUFLO.Funcionalidad (
	id_funcionalidad int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255) NOT NULL
	)
GO

INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Rol')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Ciudades')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Ruta Aerea')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Aeronave')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Generar Viaje')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Registrar Llegada')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Compra Pasaje/Encomienda')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Cancelacion Pasaje/Encomienda')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Consultar Millas')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Canjear Millas')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Listados Estadisticos')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Productos')
GO

CREATE TABLE ÑUFLO.Rol (
	id_rol int IDENTITY(1,1) PRIMARY KEY,
	nombre_rol nvarchar(255) UNIQUE NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
	)
GO

INSERT INTO ÑUFLO.Rol (nombre_rol)
	values ('Administrador')

CREATE TABLE ÑUFLO.FuncionalidadPorRol (
	id_rol int REFERENCES ÑUFLO.Rol,
	id_funcionalidad int REFERENCES ÑUFLO.Funcionalidad,
	PRIMARY KEY(id_rol, id_funcionalidad)
	)
GO

INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,1)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,2)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,3)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,4)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,5)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,6)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,7)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,8)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,9)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,10)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,11)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (1,12)
GO

CREATE TABLE ÑUFLO.Usuario (
	nombre_usuario nvarchar(255) PRIMARY KEY,
	password varbinary(255) NOT NULL,
	id_rol int REFERENCES ÑUFLO.Rol,
	cantidad_intentos smallint DEFAULT 0 NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
	)
GO

INSERT INTO ÑUFLO.Usuario (nombre_usuario, password, id_rol)
	values ('Juan', HASHBYTES('SHA2_256', 'w23e'), 1)
GO

/*****************************************************************/
/************************** MIGRACION ****************************/
/*****************************************************************/

/*35 Ciudad*/
INSERT INTO ÑUFLO.Ciudad (nombre) 
	select (Ruta_Ciudad_Origen) 
	from gd_esquema.Maestra
	group by Ruta_Ciudad_Origen
	union
	select Ruta_Ciudad_Destino 
	from gd_esquema.Maestra
	group by Ruta_Ciudad_Destino
GO

/*30 Aeronave - Sin fechas, en alta pongo today?*/
INSERT INTO ÑUFLO.Aeronave (matricula, modelo, fabricante, capacidad_peso_encomiendas, fecha_de_alta, id_tipo_servicio)
	select distinct Aeronave_Matricula, Aeronave_Modelo, Aeronave_Fabricante, Aeronave_KG_Disponibles, GETDATE(),
				case Tipo_Servicio
					when 'Primera Clase' then 1
					when 'Ejecutivo' then 2
					when 'Turista' then 3
				end id_tipo_servicio
	from gd_esquema.Maestra
	order by Aeronave_Matricula
GO
	
/*1337 Butacas - Asumo que el maximo de butacas es la butaca mas grande del avion?*/
INSERT INTO ÑUFLO.ButacaPorAvion (id_aeronave, numero_de_butaca, id_tipo_butaca)
	select distinct id_aeronave, Butaca_Nro, 
					case Butaca_Tipo
						when 'Ventanilla' then 1
						when 'Pasillo' then 2
					end id_butaca_tipo
	from ÑUFLO.Aeronave a
		join (select distinct Aeronave_Matricula, Butaca_Nro, Butaca_Tipo
			from gd_esquema.Maestra) b ON matricula = Aeronave_Matricula
	where Butaca_Tipo <> '0'
	order by id_aeronave, Butaca_Nro
GO
	
/*68 Ruta Aerea - Codigos Ruta Repetidos, Escalas?*/
INSERT INTO ÑUFLO.RutaAerea (codigo_ruta, id_ciudad_origen, id_ciudad_destino, precio_base_por_peso, precio_base_por_pasaje)
	select distinct Ruta_Codigo, co.id_ciudad, cd.id_ciudad, SUM(Ruta_Precio_BaseKG), 
					SUM(Ruta_Precio_BasePasaje)
	from (select distinct Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Ruta_Precio_BaseKG, Ruta_Precio_BasePasaje, Tipo_Servicio
		 from gd_esquema.Maestra) a,
		 ÑUFLO.Ciudad co,
		 ÑUFLO.Ciudad cd
	where co.nombre = Ruta_Ciudad_Origen
		and cd.nombre = Ruta_Ciudad_Destino
	group by Ruta_Codigo, co.id_ciudad, cd.id_ciudad
	order by Ruta_Codigo
GO

/*68 Servicio Por Ruta - Pareciera no haber una misma ruta con diferentes servicios, pero si se diferencias en las "escalas"*/
INSERT INTO ÑUFLO.ServicioPorRuta (id_ruta, id_tipo_servicio)
	select r.id_ruta, a.id_tipo_servicio
		from (select distinct Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino,
				case Tipo_Servicio
						when 'Primera Clase' then 1
						when 'Ejecutivo' then 2
						when 'Turista' then 3
					end id_tipo_servicio
			 from gd_esquema.Maestra) a,
			 ÑUFLO.RutaAerea r,
			 ÑUFLO.Ciudad co,
			 ÑUFLO.Ciudad cd
		where r.codigo_ruta = a.Ruta_Codigo
			and r.id_ciudad_origen = co.id_ciudad
			and r.id_ciudad_destino = cd.id_ciudad
			and a.Ruta_Ciudad_Origen = co.nombre
			and a.Ruta_Ciudad_Destino = cd.nombre
GO

/*8510 Viaje - Ademas existen registros en los cuales la misma aeronave sale a por distintas rutas en la misma fecha, se debe corregir, tendra que ver con escalas?*/
INSERT INTO ÑUFLO.Viaje (id_aeronave, id_ruta, peso_ocupado, fecha_salida, fecha_llegada, fecha_llegada_estimada)
	select id_aeronave,	id_ruta, peso_ocupado, FechaSalida, FechaLLegada, Fecha_LLegada_Estimada
	from (select distinct Aeronave_Matricula, Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, FechaSalida, FechaLLegada, Fecha_LLegada_Estimada, SUM(Paquete_KG) peso_ocupado
			from gd_esquema.Maestra
			group by Aeronave_Matricula, Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, FechaSalida, FechaLLegada, Fecha_LLegada_Estimada ) m,
		ÑUFLO.Aeronave a,
		ÑUFLO.RutaAerea r,
		ÑUFLO.Ciudad co,
		ÑUFLO.Ciudad cd
	where a.matricula = Aeronave_Matricula
		and r.codigo_ruta = Ruta_Codigo
		and co.nombre = Ruta_Ciudad_Origen
		and cd.nombre = Ruta_Ciudad_Destino
		and r.id_ciudad_origen = co.id_ciudad
		and r.id_ciudad_destino = cd.id_ciudad
	order by FechaSalida
GO

/*2594 Cliente*/
INSERT INTO ÑUFLO.Cliente (dni , nombre, apellido, direccion, telefono, mail, fecha_de_nacimiento)
	select distinct Cli_Dni, Cli_Nombre, Cli_Apellido, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac 
	from gd_esquema.Maestra
GO

/*Comrpas Pasajes Encomiendas*/

/*Tabla temporal para facilitar los insert*/
CREATE TABLE #CompraPasajeEncomienda (
	codigo_compra int IDENTITY(1,1),
	numero_butaca numeric(18,0),
	pasaje_precio numeric(18,2),
	paquete_kg numeric(18,0),
	paquete_precio numeric(18,2),
	id_pasaje_encomienda numeric(18,0),
	fecha_compra datetime,
	id_cliente int,
	id_viaje int
	)
GO

INSERT INTO #CompraPasajeEncomienda(numero_butaca, pasaje_precio, paquete_kg, paquete_precio, id_pasaje_encomienda, fecha_compra, id_cliente, id_viaje)
	select Butaca_Nro, Pasaje_Precio, Paquete_KG, Paquete_Precio,
			case Butaca_Piso
				when 0 then Paquete_Codigo
				when 1 then Pasaje_Codigo
				end id_pasaje_encomienda,
			case Butaca_Piso
				when 0 then Paquete_FechaCompra
				when 1 then Pasaje_FechaCompra
				end fecha_compra,
			(select id_cliente 
				from ÑUFLO.Cliente c 
				where c.dni = m.Cli_Dni
					and c.nombre = m.Cli_Nombre
					and c.apellido = c.apellido) cliente,
			(select v.id_viaje 
				from  ÑUFLO.Viaje v, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd
				where v.id_ruta = r.id_ruta
					and r.codigo_ruta = m.Ruta_Codigo
					and r.id_ciudad_origen = co.id_ciudad
					and r.id_ciudad_destino = cd.id_ciudad
					and co.nombre = m.Ruta_Ciudad_Origen
					and cd.nombre = m.Ruta_Ciudad_Destino
					and v.id_aeronave = (select a.id_aeronave
										from ÑUFLO.Aeronave a
										where a.matricula = m.Aeronave_Matricula)
					and v.fecha_salida = m.FechaSalida
					and v.fecha_llegada_estimada = m.Fecha_LLegada_Estimada) id_viaje
		from gd_esquema.Maestra m
GO

/*401304 Compra - Consideramos como que las compras eran de a uno, no varios pasajes ni encomiendas juntas por no poder diferenciarlas*/
INSERT INTO ÑUFLO.Compra (id_viaje, id_cliente, fecha_de_compra)
	select id_viaje, id_cliente, fecha_compra
		from  #CompraPasajeEncomienda
GO
/*401304 PasajeEncomienda */
INSERT INTO ÑUFLO.PasajeEncomienda (id_pasaje_encomienda, codigo_de_compra, id_cliente, peso_encomienda, numero_de_butaca, precio)
	select id_pasaje_encomienda, codigo_compra, id_cliente, paquete_kg, 
			case 
				when paquete_kg > 0 then NULL
				else numero_butaca
			end as numero_de_butaca,
		case pasaje_precio
			when 0.00 then paquete_precio
			else pasaje_precio
			end precio
		from #CompraPasajeEncomienda
GO
	
/*****************************************************************/
/*********************** Stored Procedures ***********************/
/*****************************************************************/

CREATE PROCEDURE ÑUFLO.LogearUsuario
@usuario nvarchar(255),
@password varchar(255)
AS
DECLARE @intentos smallint, @habilitado bit
SET @intentos = (select cantidad_intentos from ÑUFLO.Usuario where nombre_usuario = @usuario)
SET @habilitado = (select habilitado from ÑUFLO.Usuario where nombre_usuario = @usuario)
IF (@habilitado = 1)
BEGIN
	DECLARE @hash varbinary(255)
	SET @hash = (select password from ÑUFLO.Usuario where nombre_usuario = @usuario)
	
	IF (@hash =  HASHBYTES('SHA2_256', @password))
		BEGIN
			UPDATE ÑUFLO.Usuario
				SET cantidad_intentos = 0, habilitado = 1
				WHERE nombre_usuario = @usuario;
		END
	ELSE
		BEGIN
			UPDATE ÑUFLO.Usuario
				SET cantidad_intentos = @intentos + 1
				WHERE nombre_usuario = @usuario;
			IF(@intentos = 2)
				BEGIN
					UPDATE ÑUFLO.Usuario
						SET habilitado = 0
						WHERE nombre_usuario = @usuario;
				END;			
		THROW 60000,'Usuario o Contraseña Incorrecta',1
		END
END
ELSE
	THROW 60001,'Usuario deshabilitado',1
;
GO

CREATE PROCEDURE ÑUFLO.HabilitarUsuario 
@usuario nvarchar(255)
AS
	UPDATE ÑUFLO.Usuario
		SET cantidad_intentos = 0, habilitado = 1
		WHERE @usuario = nombre_usuario
;
GO

CREATE PROCEDURE ÑUFLO.FiltroAeronave
@modelo nvarchar(255) = null,
@matricula nvarchar(255) = null,
@fabricante nvarchar(255) = null,
@baja_fuera_servicio bit = null,
@baja_vida_util bit = null,
@tipo_servicio int = null,
@capacidad_encomiendas numeric(18,0) = null,
@cantidad_butacas int = null
AS
select id_aeronave, modelo, matricula, fabricante, id_tipo_servicio, fecha_de_alta, capacidad_peso_encomiendas, baja_vida_utill, baja_por_fuera_de_servicio
	from ÑUFLO.Aeronave
	where (@modelo is null or @modelo = modelo)
		and (@matricula is null or @matricula = matricula)
		and (@fabricante is null or @fabricante = fabricante)
		and (@baja_fuera_servicio is null or @baja_fuera_servicio = baja_por_fuera_de_servicio)
		and (@baja_vida_util is null or (@baja_vida_util = 1 and baja_vida_utill is not null))
		and (@tipo_servicio is null or @tipo_servicio = id_tipo_servicio)
		and (@capacidad_encomiendas is null or @capacidad_encomiendas < capacidad_peso_encomiendas)
		and (@cantidad_butacas is null or @cantidad_butacas < (select COUNT(id_tipo_butaca) 
																	from ÑUFLO.ButacaPorAvion b
																	where id_aeronave = b.id_aeronave))

;
GO

CREATE PROCEDURE ÑUFLO.AltaAeronave
@matricula nvarchar(255),
@modelo nvarchar(255), 
@fabricante nvarchar(255), 
@tipo_de_servicio int, 
@capacidad_de_encomiendas numeric(18,0),
@fecha_hoy nvarchar(255)
AS
	INSERT INTO ÑUFLO.Aeronave(matricula, modelo, fabricante, id_tipo_servicio, capacidad_peso_encomiendas, fecha_de_alta)
		values(@matricula, @modelo, @fabricante, @tipo_de_servicio, @capacidad_de_encomiendas, convert(datetime, @fecha_hoy ))
;
GO

CREATE PROCEDURE ÑUFLO.AgregarButaca
@matricula nvarchar(255),
@numeroButaca numeric(18, 0),
@tipoButaca int
AS
	DECLARE @id_aeronave int
	SET @id_aeronave = (select id_aeronave from ÑUFLO.Aeronave where matricula = @matricula)

	INSERT INTO ÑUFLO.ButacaPorAvion(id_aeronave, numero_de_butaca, id_tipo_butaca)
		values(@id_aeronave, @numeroButaca, @tipoButaca)
;
GO

CREATE PROCEDURE ÑUFLO.ActualizarAeronave
@id_aeronave int,
@matricula nvarchar(255),
@modelo nvarchar(255), 
@fabricante nvarchar(255), 
@tipo_de_servicio int, 
@capacidad_de_encomiendas numeric(18,0),
@fecha_hoy nvarchar(255)
AS
	UPDATE ÑUFLO.Aeronave
		SET matricula = @matricula, 
			modelo = @modelo, 
			fabricante = @fabricante, 
			id_tipo_servicio = @tipo_de_servicio, 
			capacidad_peso_encomiendas = @capacidad_de_encomiendas, 
			fecha_de_alta = convert(datetime, @fecha_hoy)
		WHERE id_aeronave = @id_aeronave
;
GO

CREATE PROCEDURE ÑUFLO.BajaPorVidaUtil
@id_aeronave int,
@fecha nvarchar(255)
AS
	if((select baja_vida_utill from ÑUFLO.Aeronave where id_aeronave=@id_aeronave) is not null)
		THROW 60004, 'La nave ya se fuera de su vida util', 1
	
	DECLARE @fecha_baja datetime
	SET @fecha_baja = convert(datetime, @fecha)

	UPDATE ÑUFLO.Aeronave
		SET baja_vida_utill = @fecha_baja
		WHERE id_aeronave = @id_aeronave

	select COUNT(id_viaje)
		from ÑUFLO.Viaje
		where id_aeronave = @id_aeronave
			and fecha_salida > @fecha_baja
;
GO

CREATE PROCEDURE ÑUFLO.BajaFueraDeServicio
@id_aeronave int,
@fecha_fuera nvarchar(255),
@fecha_rein nvarchar(255)
AS
	if((select baja_por_fuera_de_servicio from ÑUFLO.Aeronave where id_aeronave=@id_aeronave) = 1)
		THROW 60003, 'La nave ya se encuentra en mantenimiento', 1

	DECLARE @fecha_baja datetime, @fecha_reinicio datetime
	SET @fecha_baja = convert(datetime, @fecha_fuera)
	SET @fecha_reinicio = convert(datetime, @fecha_rein)

	UPDATE ÑUFLO.Aeronave
		SET baja_por_fuera_de_servicio = 1
		WHERE id_aeronave = @id_aeronave
	
	INSERT INTO ÑUFLO.ServicioTecnico(fecha_fuera_de_servicio, fecha_reinicio_de_servicio, id_aeronave)
		values(@fecha_baja, @fecha_reinicio, @id_aeronave)			
	
	select COUNT(id_viaje)
		from ÑUFLO.Viaje
		where id_aeronave = @id_aeronave
			and fecha_salida between @fecha_baja and @fecha_reinicio
;
GO

CREATE PROCEDURE ÑUFLO.CancelarPasajesDe
@id_aeronave int,
@fecha_hoy nvarchar(255),
@fecha_inicio nvarchar(255),
@fecha_fin nvarchar(255) = null
AS
	DECLARE @fecha_i datetime, @fecha_f datetime, @hoy datetime
	SET @hoy = convert(datetime, @fecha_hoy)
	SET @fecha_i = convert(datetime, @fecha_inicio)
	SET @fecha_f = convert(datetime, @fecha_fin)

	DECLARE CPasajes CURSOR 
		FOR select c.codigo_de_compra, p.id_pasaje_encomienda
				from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.PasajeEncomienda p
				where @id_aeronave = v.id_aeronave
					and ((@fecha_f is null and v.fecha_salida > @fecha_i)
					or v.fecha_salida between @fecha_i and @fecha_f)
					and v.id_viaje = c.id_viaje
					and c.codigo_de_compra = p.codigo_de_compra

	DECLARE @pnr int, @pasaje int, @cod_anterior int
	SET @cod_anterior = -1
	OPEN CPasajes
	FETCH CPasajes INTO @pnr, @pasaje

	WHILE (@@FETCH_STATUS = 0)
	BEGIN	
		if(@pnr <> @cod_anterior)
		BEGIN
			INSERT INTO ÑUFLO.Cancelacion(codigo_de_compra, fecha_devolucion)
				values(@pnr, @hoy)
			SET @cod_anterior = @pnr
		END

		INSERT INTO ÑUFLO.PasajeEncomiendaPorCancelacion(id_cancelacion, id_pasaje_encomienda, motivo_cancelacion)
			values((select MAX(id_cancelacion) from ÑUFLO.Cancelacion), @pasaje, 'Baja de Aeronave')

		UPDATE ÑUFLO.PasajeEncomienda
			SET cancelado = 1
			WHERE @pasaje = id_pasaje_encomienda

		FETCH CPasajes INTO @pnr, @pasaje
	END

	CLOSE CPasajes
	DEALLOCATE CPasajes
;
GO

CREATE PROCEDURE ÑUFLO.ReemplazarAeronavePara
@id_aeronave int,
@fecha_inicio nvarchar(255),
@fecha_fin nvarchar(255) = null
AS
	DECLARE @fecha_i datetime, @fecha_f datetime, @modelo nvarchar(255), @fabricante nvarchar(255), @tipo_servicio int

	SET @fecha_i = convert(datetime, @fecha_inicio)
	SET @fecha_f = convert(datetime, @fecha_fin)
	SET @modelo = (select modelo from ÑUFLO.Aeronave where id_aeronave = @id_aeronave)
	SET @fabricante = (select fabricante from ÑUFLO.Aeronave where id_aeronave = @id_aeronave)
	SET @tipo_servicio = (select id_tipo_servicio from ÑUFLO.Aeronave where id_aeronave = @id_aeronave)
	
	DECLARE CViajes CURSOR FOR
		select id_viaje, fecha_salida, fecha_llegada_estimada
			from ÑUFLO.Viaje
			where id_aeronave = @id_aeronave
				and ((@fecha_f is null and fecha_salida > @fecha_i)
				or fecha_salida between @fecha_i and @fecha_f)

	BEGIN TRANSACTION
	
	DECLARE @id_viaje int, @salida datetime, @llegada datetime
	DECLARE @reemplazos TABLE (id_aeronave int)
	OPEN CViajes
	FETCH Cviajes into @id_viaje, @salida, @llegada
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO @reemplazos
			select case
						when (select COUNT(id_viaje) viajes
								from ÑUFLO.Viaje v
								where a.id_aeronave = v.id_aeronave
									and (v.fecha_salida between @salida and @llegada
									or v.fecha_llegada_estimada between @salida and @llegada)) = 0 then a.id_aeronave
						else null
					end
				from ÑUFLO.Aeronave a
				where @modelo = a.modelo
					and @fabricante = a.fabricante
					and @tipo_servicio = a.id_tipo_servicio
					and baja_por_fuera_de_servicio is null
					and baja_vida_utill is null
		 
		IF ((select COUNT(*) from @reemplazos where id_aeronave is not null) = 0)
		BEGIN
			CLOSE CViajes
			DEALLOCATE CViajes;
			ROLLBACK;
			THROW 60005, 'No se pudo reemplazar todos los viajes', 1
		END

		UPDATE ÑUFLO.Viaje
			SET id_aeronave = (select top 1 id_aeronave from @reemplazos where id_aeronave is not null)
			where id_viaje = @id_viaje

		DELETE @reemplazos
		FETCH Cviajes into @id_viaje, @salida, @llegada
	END
	COMMIT
	CLOSE CViajes
	DEALLOCATE CViajes
;
GO

CREATE PROCEDURE ÑUFLO.PesoDisponible
@Id_viaje int
AS
	select (a.capacidad_peso_encomiendas - v.peso_ocupado) Peso_Disponible
		from ÑUFLO.Aeronave a, ÑUFLO.Viaje v
		where @Id_viaje = v.id_viaje
			and v.id_aeronave = a.id_aeronave
;
GO

CREATE PROCEDURE ÑUFLO.MillasTotalesDe
@dni numeric(18,0)
AS
	select SUM(Cantidad - Cantidad_Gastada) Total_Millas
		from ÑUFLO.DetalleMillas
		where Estado = 'Vigentes'
			and DNI = @dni
;
GO

CREATE PROCEDURE ÑUFLO.ViajesDisponiblesPara
@ciudad_origen nvarchar(255),
@ciudad_destino nvarchar(255),
@fecha datetime
AS
	select v.id_viaje Viaje, a.matricula Matricula, v.peso_ocupado Peso_Ocupado, v.fecha_salida Fecha_Salida, v.fecha_llegada_estimada Fecha_Llegada_Estimada
		from ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd
		where r.id_ruta = v.id_ruta
			and r.id_ciudad_origen = co.id_ciudad
			and r.id_ciudad_destino = cd.id_ciudad
			and co.nombre = @ciudad_origen
			and cd.nombre = @ciudad_destino
			and convert(date, v.fecha_salida) = convert(date, @fecha)
			and v.id_aeronave = a.id_aeronave
;
GO

CREATE PROCEDURE ÑUFLO.PasajesYEncomiendasDe
@codigo_compra int
AS
	select p.id_pasaje_encomienda Codigo, 'Pasaje' Tipo, c.dni DNI, c.nombre Nombre, c.apellido Apellido,
		 '-' Peso_Encomienda, cast(p.numero_de_butaca AS nvarchar(255)) Butaca_Numero, p.precio Precio
		from ÑUFLO.PasajeEncomienda p, ÑUFLO.Cliente c
		where p.numero_de_butaca is not null
			and p.id_cliente = c.id_cliente
			and p.codigo_de_compra = @codigo_compra
	UNION
	select p.id_pasaje_encomienda, 'Encomienda', c.dni, c.nombre, c.apellido, cast(p.peso_encomienda AS nvarchar(255)), '-', p.precio
		from ÑUFLO.PasajeEncomienda p, ÑUFLO.Cliente c
		where p.numero_de_butaca is null
			and p.id_cliente = c.id_cliente
			and p.codigo_de_compra = @codigo_compra
;
GO

CREATE PROCEDURE ÑUFLO.ButacasDisponibles
@id_viaje int
AS
	select numero_de_butaca, tipo_butaca
		from ÑUFLO.TipoButaca tb,
			(select numero_de_butaca, id_tipo_butaca
				from ÑUFLO.Viaje v, ÑUFLO.ButacaPorAvion b
				where @id_viaje = v.id_viaje
					and v.id_aeronave = b.id_aeronave
			except
			select distinct p.numero_de_butaca, b.id_tipo_butaca
				from ÑUFLO.Viaje v, ÑUFLO.ButacaPorAvion b,
					 ÑUFLO.Compra c, ÑUFLO.PasajeEncomienda p
				where @id_viaje = v.id_viaje
					and v.id_aeronave = b.id_aeronave
					and v.id_viaje = c.id_viaje
					and c.codigo_de_compra = p.codigo_de_compra
					and p.numero_de_butaca = b.numero_de_butaca
					and p.cancelado = 0) b
		where b.id_tipo_butaca = tb.id_tipo_butaca
;
GO

CREATE PROCEDURE ÑUFLO.ExpirarMillas
AS

	DECLARE @id_milla int, @fecha datetime
	DECLARE CMillas CURSOR 
		FOR select id_milla, fecha_de_obtencion
				from ÑUFLO.Milla
				where expirado = 0

	OPEN CMillas 
	FETCH CMillas INTO @id_milla, @fecha

	WHILE (@@FETCH_STATUS = 0)
	BEGIN	

		IF(DATEDIFF(DD, @fecha, GETDATE()) > 365)
			UPDATE ÑUFLO.Milla
			 set expirado = 1
			 where id_milla = @id_milla

		FETCH CMillas INTO @id_milla, @fecha
	END

	CLOSE CMillas
	DEALLOCATE CMillas
;
GO

CREATE PROCEDURE ÑUFLO.DetallePasajePara
@ciudad nvarchar(255),
@fecha_inicio nvarchar(255),
@fecha_fin nvarchar(255)
AS
	select Codigo_de_Compra, Fecha_De_Compra, Pasaje, Destino, DNI, Nombre, Apellido, Butaca_Numero, Precio
		from ÑUFLO.DetallePasajes
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
			and Destino = @ciudad
;
GO	

CREATE PROCEDURE ÑUFLO.DetalleAeronavesVaciasPara
@ciudad nvarchar(255),
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select Viaje, Destino, Matricula, Modelo, Fabricante, Capacidad_Peso, Fecha_De_Compra
		from ÑUFLO.DetalleAeronavesVacias
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
			and @ciudad = Destino
;
GO

CREATE PROCEDURE ÑUFLO.DetalleMillasDe
@dni int
AS
	EXEC ÑUFLO.ExpirarMillas
	select Tipo, Cantidad, Cantidad_Gastada, Fecha, Estado
		from ÑUFLO.DetalleMillas 
		where DNI = @dni
		order by Fecha
;
GO

CREATE PROCEDURE ÑUFLO.DetalleMillasPara
@dni int,
@fecha_inicio datetime,
@fecha_fin datetime
AS
	EXEC ÑUFLO.ExpirarMillas
	select Tipo, Cantidad, Fecha
		from ÑUFLO.DetalleMillas
		where Fecha between @fecha_inicio and @fecha_fin
			and DNI = @dni
		order by Fecha
;
GO

CREATE PROCEDURE ÑUFLO.DetalleCancelacionesPara
@ciudad nvarchar(255),
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select Pasaje, DNI, Nombre, Apellido, Butaca_Numero, Fecha_De_Compra, Fecha_Devolucion, Motivo
		from ÑUFLO.DetalleCancelaciones
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
			and @ciudad = Destino
;
GO

CREATE PROCEDURE ÑUFLO.TodasLasCiudades
AS
	SELECT nombre FROM ÑUFLO.Ciudad
;
GO

CREATE PROCEDURE ÑUFLO.TodasLasFuncionalidades
AS
	SELECT descripcion FROM ÑUFLO.Funcionalidad
;
GO

CREATE PROCEDURE ÑUFLO.RolDadoNombre
@nombre nvarchar(255) = null
AS
	SELECT nombre_rol, habilitado
		FROM ÑUFLO.Rol
		WHERE @nombre is null OR nombre_rol LIKE @nombre + '%'
;
GO

CREATE PROCEDURE ÑUFLO.Inhabilitar_Habilitar
@nombre nvarchar(255)
AS
	IF ((SELECT habilitado FROM Rol WHERE nombre_rol = @nombre) = 1)
	BEGIN
		UPDATE Rol SET habilitado = 0 WHERE nombre_rol = @nombre
	END
	ELSE
	BEGIN
		UPDATE Rol SET habilitado = 1 WHERE nombre_rol = @nombre
	END
	
	EXEC ÑUFLO.RolDadoNombre @nombre
;
GO

CREATE PROCEDURE ÑUFLO.DetalleServicioTecnicoPara
@matricula nvarchar(255),
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select Matricula, Modelo, Fabricante, Capacidad_Peso, Fecha_Fuera_de_Servicio,
			case
				when @fecha_fin < Fecha_Reinicio_de_Servicio then DATEDIFF(DD, Fecha_Fuera_de_Servicio, @fecha_fin)
				else DATEDIFF(DD, Fecha_Fuera_de_Servicio, Fecha_Reinicio_de_Servicio) 
			end Dias_Fuera_de_Servicio
		from ÑUFLO.DetalleServiciosTecnicos
		where Fecha_Fuera_de_Servicio between @fecha_inicio and @fecha_fin
			and @matricula = Matricula
;
GO

CREATE PROCEDURE ÑUFLO.TOP5DestinoPasajesComprados
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select top 5 Destino, COUNT(*) Pasajes
		from ÑUFLO.DetallePasajes
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
		group by Destino
		order by COUNT(*) desc
;
GO

CREATE PROCEDURE ÑUFLO.TOP5DestinoAeronavesVacias
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select top 5 Destino, COUNT(*) Aeronaves_Vacias
		from ÑUFLO.DetalleAeronavesVacias
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
		group by Destino
		order by COUNT(*) desc
;
GO

CREATE PROCEDURE ÑUFLO.TOP5MillasDeClientes
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select top 5 m.DNI, c.nombre, c.apellido, SUM(m.Cantidad) Cantidad
		from ÑUFLO.DetalleMillas m, ÑUFLO.Cliente c
		where Fecha between @fecha_inicio and @fecha_fin
			and m.DNI = c.dni
		group by m.DNI, c.nombre, c.apellido
		order by SUM(m.Cantidad) desc
;
GO

CREATE PROCEDURE ÑUFLO.TOP5DestinoCancelaciones
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select top 5 p.Destino, COUNT(*) Cancelaciones
		from ÑUFLO.DetallePasajes p,
			ÑUFLO.Cancelacion c,
			ÑUFLO.PasajeEncomiendaPorCancelacion pc
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
			and p.pasaje = pc.id_pasaje_encomienda
			and p.Codigo_de_Compra = c.codigo_de_compra
		group by p.Destino
;
GO

CREATE PROCEDURE ÑUFLO.TOP5DiasFueraDeServicio
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select Matricula, Modelo, Fabricante, Capacidad_Peso, 
			SUM(case
					when @fecha_fin < Fecha_Reinicio_de_Servicio then DATEDIFF(DD, Fecha_Fuera_de_Servicio, @fecha_fin)
					else DATEDIFF(DD, Fecha_Fuera_de_Servicio, Fecha_Reinicio_de_Servicio) 
				end)  Dias_Fuera_de_Servicio
		from ÑUFLO.DetalleServiciosTecnicos
		where Fecha_Fuera_de_Servicio between @fecha_inicio and @fecha_fin
		group by Matricula, Modelo, Fabricante, Capacidad_Peso
		order by SUM(case
						when @fecha_fin < Fecha_Reinicio_de_Servicio then DATEDIFF(DD, Fecha_Fuera_de_Servicio, @fecha_fin)
						else DATEDIFF(DD, Fecha_Fuera_de_Servicio, Fecha_Reinicio_de_Servicio) 
					end) desc
;
GO

CREATE PROCEDURE ÑUFLO.DestinoOrigen
AS
	select id_ciudad_origen "Id ciudad origen", id_ciudad_destino "Id ciudad destino"
		from ÑUFLO.RutaAerea

	select id_ciudad "Id ciudad", nombre "Nombre"
		from ÑUFLO.Ciudad
;
GO

CREATE PROCEDURE ÑUFLO.CiudadTipoServicio
AS
	select id_ciudad "Id ciudad", nombre "Nombre"
		from ÑUFLO.Ciudad

	select id_tipo_servicio "Id Tipo Servicio", tipo_servicio "Tipo Servicio", porcentaje_recargo "Porcentaje de recargo"
		from ÑUFLO.TipoServicio
;
GO

CREATE PROCEDURE ÑUFLO.FiltrosAltaRutaAerea
@id_ciudad_origen int = NULL,
@id_ciudad_destino int = NULL,
@id_tipo_servicio int = NULL
AS
	SELECT ra.id_ruta "Id ruta",ra.codigo_ruta "Codigo de ruta",c1.id_ciudad "Id ciudad origen",c1.nombre "Ciudad origen",
		   c2.id_ciudad "Id ciudad destino",c2.nombre "Ciudad destino", ra.precio_base_por_peso "Precio base por peso",
		   ra.precio_base_por_pasaje "Precio base por pasaje", ts.tipo_servicio "Tipo de servicio"	
		FROM ÑUFLO.RutaAerea ra JOIN ÑUFLO.Ciudad c1			ON ra.id_ciudad_origen = c1.id_ciudad
								JOIN ÑUFLO.Ciudad c2			ON ra.id_ciudad_destino = c2.id_ciudad
								JOIN ÑUFLO.ServicioPorRuta sr	ON ra.id_ruta = sr.id_ruta
								JOIN ÑUFLO.TipoServicio ts		ON sr.id_tipo_servicio  = ts.id_tipo_servicio

		WHERE (@id_ciudad_origen IS NULL OR ra.id_ciudad_origen = @id_ciudad_origen) AND
			  (@id_ciudad_destino IS NULL OR  ra.id_ciudad_destino = @id_ciudad_destino) AND
			  (@id_tipo_servicio IS NULL OR sr.id_tipo_servicio = @id_tipo_servicio ) AND
			  (@id_tipo_servicio IS NULL OR ra.id_ruta = sr.id_ruta )
;  
GO


CREATE PROCEDURE ÑUFLO.FiltrosModificacionRutaAerea
@id_ciudad_origen int = NULL,
@id_ciudad_destino int = NULL,
@id_tipo_servicio int = NULL
AS
	SELECT ra.codigo_ruta "Codigo de ruta", c1.nombre "Ciudad origen", c2.nombre "Ciudad destino",
		   ra.precio_base_por_peso "Precio base por peso", ra.precio_base_por_pasaje "Precio base por pasaje",
		   ts.tipo_servicio "Tipo de servicio"	
		FROM ÑUFLO.RutaAerea ra JOIN ÑUFLO.Ciudad c1			ON ra.id_ciudad_origen = c1.id_ciudad
								JOIN ÑUFLO.Ciudad c2			ON ra.id_ciudad_destino = c2.id_ciudad
								JOIN ÑUFLO.ServicioPorRuta sr	ON ra.id_ruta = sr.id_ruta
								JOIN ÑUFLO.TipoServicio ts		ON sr.id_tipo_servicio  = ts.id_tipo_servicio

		WHERE (@id_ciudad_origen IS NULL OR ra.id_ciudad_origen = @id_ciudad_origen) AND
			  (@id_ciudad_destino IS NULL OR  ra.id_ciudad_destino = @id_ciudad_destino) AND
			  (@id_tipo_servicio IS NULL OR sr.id_tipo_servicio = @id_tipo_servicio ) AND
			  (@id_tipo_servicio IS NULL OR ra.id_ruta = sr.id_ruta )
;  
GO


/*****************************************************************/
/*************************** Function ****************************/
/*****************************************************************/

CREATE FUNCTION ÑUFLO.MillasPorClienteCarga(@Id_viaje int)
RETURNS @MillasPorCliente TABLE
   (
    id_cliente int PRIMARY KEY,
    cantidadMillas Int NOT NULL
   )
AS
BEGIN
   INSERT @MillasPorCliente
        SELECT comp.id_cliente, ROUND(SUM(pe.precio)/10,0,1) as millas-- El tercer parametro asi trunca, con cero redondea
        FROM ÑUFLO.Compra comp, ÑUFLO.PasajeEncomienda pe
        WHERE comp.id_viaje = @Id_viaje
			AND comp.codigo_de_compra = pe.codigo_de_compra
		GROUP BY comp.id_cliente
   RETURN
END
GO

/*****************************************************************/
/*************************** Triggers ****************************/
/*****************************************************************/

CREATE TRIGGER ÑUFLO.CargaMilla
ON ÑUFLO.Viaje FOR UPDATE
AS
BEGIN
	UPDATE ÑUFLO.Milla
	SET cantidad = mc.cantidadMillas ,fecha_de_obtencion = i.fecha_llegada
	FROM inserted i, (SELECT * FROM ÑUFLO.MillasPorClienteCarga(1/*TODO:USAR UN CURSOR*/)) mc, ÑUFLO.Milla m
	WHERE mc.id_cliente = m.id_cliente 
END
GO

CREATE TRIGGER ÑUFLO.DisminiurMillaPorCanje
ON ÑUFLO.Canje FOR INSERT
AS
BEGIN
	DECLARE @id_milla int, @id_cliente int, @fecha datetime, @cantidad int, @cantidad_gastada int, @gasto int

	SET @gasto = (select (i.cantidad * p.millas_necesarias)
								from inserted i, ÑUFLO.Producto p)
	
	DECLARE CMillas CURSOR 
		FOR select id_milla, id_cliente , fecha_de_obtencion, cantidad, cantidad_gastada
				from ÑUFLO.Milla
				where expirado = 0
					and (cantidad - cantidad_gastada) > 0
				order by fecha_de_obtencion

	OPEN CMillas 
	FETCH CMillas INTO @id_milla, @id_cliente, @fecha, @cantidad, @cantidad_gastada

	WHILE (@@FETCH_STATUS = 0 and @gasto > 0)
	BEGIN	
		IF(@gasto > @cantidad - @cantidad_gastada)
			BEGIN
			SET @gasto = @gasto - (@cantidad - @cantidad_gastada)
			UPDATE ÑUFLO.Milla
				SET cantidad_gastada = @cantidad
				where id_milla = @id_milla
			END
		ELSE
			BEGIN
			UPDATE ÑUFLO.Milla
				SET cantidad_gastada = @cantidad_gastada + @gasto
				where id_milla = @id_milla
			SET @gasto = 0
			END

		FETCH CMillas INTO @id_milla, @id_cliente, @fecha, @cantidad, @cantidad_gastada
	END

	CLOSE CMillas
	DEALLOCATE CMillas
END
GO

/*****************************************************************/
/**************************** Views ******************************/
/*****************************************************************/

CREATE VIEW ÑUFLO.VRutaAerea
AS
	select r.codigo_ruta 'Código Ruta', co.nombre 'Ciudad Origen', cd.nombre 'Ciudad Destino', 
			r.precio_base_por_peso 'Precio base x peso', r.precio_base_por_pasaje 'Precio base x pasaje'
		from ÑUFLO.RutaAerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd
		where r.id_ciudad_origen = co.id_ciudad
			and r.id_ciudad_destino = cd.id_ciudad
GO

CREATE VIEW ÑUFLO.DetallePasajes
AS
	select co.codigo_de_compra Codigo_de_Compra, co.fecha_de_compra Fecha_De_Compra, id_pasaje_encomienda Pasaje, ci.nombre Destino,
			DNI, c.nombre Nombre, apellido Apellido, numero_de_butaca Butaca_Numero, precio Precio
		from ÑUFLO.Cliente c , ÑUFLO.PasajeEncomienda p, ÑUFLO.Compra co, ÑUFLO.Viaje v, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad ci
		where  v.id_viaje = co.id_viaje
			and v.id_ruta = r.id_ruta
			and r.id_ciudad_destino = ci.id_ciudad
			and co.codigo_de_compra = p.codigo_de_compra
			and c.id_cliente = p.id_cliente
			and p.numero_de_butaca is not null
GO

CREATE VIEW ÑUFLO.DetalleAeronavesVacias
AS
	select v.id_viaje Viaje, ci.nombre Destino, a.matricula Matricula, a.modelo Modelo, a.fabricante Fabricante, a.capacidad_peso_encomiendas Capacidad_Peso,
			c.fecha_de_compra Fecha_De_Compra
		from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.PasajeEncomienda p, ÑUFLO.Ciudad ci, ÑUFLO.RutaAerea r, ÑUFLO.Aeronave a
		where v.id_ruta = r.id_ruta
			and r.id_ciudad_destino = ci.id_ciudad
			and v.id_viaje = c.id_viaje
			and c.codigo_de_compra = p.codigo_de_compra
			and v.id_aeronave = a.id_aeronave
		group by v.id_viaje, ci.nombre, a.matricula, a.modelo, a.fabricante, a.capacidad_peso_encomiendas, c.fecha_de_compra
		having COUNT(*) = 0
GO

CREATE VIEW ÑUFLO.DetalleMillas
AS
	select 'Obtencion' Tipo, fecha_de_obtencion Fecha, m.cantidad Cantidad, CAST(cantidad_gastada AS nvarchar(255)) Cantidad_Gastada, cli.dni DNI,
			case expirado
				when 0 then 'Vigentes'
				else 'Expiradas'
			end Estado
		from ÑUFLO.Milla m, ÑUFLO.Cliente cli
		where m.id_cliente = cli.id_cliente
	UNION
	select 'Canje' Tipo, fecha_de_canje, -c.cantidad, '-', cli.DNI, '-'
		from ÑUFLO.Canje c, ÑUFLO.Cliente cli
		where c.id_cliente = cli.id_cliente
GO

CREATE VIEW ÑUFLO.DetalleCancelaciones
AS
	select pc.id_pasaje_encomienda Pasaje, p.dni DNI, p.Nombre, p.apellido Apellido, p.Butaca_Numero , 
			c.fecha_devolucion Fecha_Devolucion, pc.motivo_cancelacion Motivo, p.Fecha_De_Compra, p.Destino
		from ÑUFLO.DetallePasajes p,
			ÑUFLO.Cancelacion c,
			ÑUFLO.PasajeEncomiendaPorCancelacion pc
		where p.pasaje = pc.id_pasaje_encomienda
			and p.Codigo_de_Compra = c.codigo_de_compra
GO

CREATE VIEW ÑUFLO.DetalleServiciosTecnicos
AS
	select a.matricula Matricula, a.modelo Modelo, a.fabricante Fabricante, a.capacidad_peso_encomiendas Capacidad_Peso,
			st.fecha_fuera_de_servicio Fecha_Fuera_de_Servicio, st.fecha_reinicio_de_servicio Fecha_Reinicio_De_Servicio
		from ÑUFLO.Aeronave a, ÑUFLO.ServicioTecnico st
		where st.id_aeronave = a.id_aeronave			
GO