﻿USE [GD2C2015]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE SCHEMA [ÑUFLO] AUTHORIZATION gd
GO


/****CREACION DE TABLAS****/
CREATE TABLE ÑUFLO.Ciudad (
	id_ciudad int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255)
	)
GO

CREATE TABLE ÑUFLO.Tipo_Servicio (
	id_tipo_servicio int IDENTITY(1,1) PRIMARY KEY,
	tipo_servicio nvarchar(255),
	porcentaje_recargo numeric(18,2)
	)
GO


INSERT INTO ÑUFLO.Tipo_Servicio(tipo_servicio, porcentaje_recargo) values ('Primera Clase', 2)
INSERT INTO ÑUFLO.Tipo_Servicio(tipo_servicio, porcentaje_recargo) values ('Ejecutivo', 1.5)
INSERT INTO ÑUFLO.Tipo_Servicio(tipo_servicio, porcentaje_recargo) values ('Turista', 1.2)
GO

CREATE TABLE ÑUFLO.Ruta_Aerea (
	id_ruta int IDENTITY(1,1) PRIMARY KEY,
	codigo_ruta numeric(18,0),
	id_ciudad_origen int REFERENCES ÑUFLO.Ciudad,
	id_ciudad_destino int REFERENCES ÑUFLO.Ciudad,
	precio_base_por_peso numeric(18,2),
	precio_base_por_pasaje numeric(18,2),
	)
GO

CREATE TABLE ÑUFLO.Servicio_Por_Ruta (
	id_ruta int REFERENCES ÑUFLO.Ruta_Aerea,
	id_tipo_servicio int REFERENCES ÑUFLO.Tipo_Servicio,
	PRIMARY KEY(id_ruta, id_tipo_servicio)
	)
GO

CREATE TABLE ÑUFLO.Aeronave (
	id_aeronave int IDENTITY(1,1) PRIMARY KEY,
	modelo nvarchar(255),
	matricula nvarchar(255) UNIQUE,
	fabricante nvarchar(255),
	id_tipo_servicio int REFERENCES ÑUFLO.Tipo_Servicio,
	fecha_de_alta datetime,
	capacidad_peso_encomiendas numeric(18,0),
	baja_vida_utill datetime,
	baja_por_fuera_de_servicio int 
	)
GO

CREATE TABLE ÑUFLO.Tipo_Butaca (
	id_tipo_butaca int IDENTITY(1,1) PRIMARY KEY,
	tipo_butaca nvarchar(255)
	)
GO

INSERT INTO ÑUFLO.Tipo_Butaca(tipo_butaca) values ('Ventanilla')
INSERT INTO ÑUFLO.Tipo_Butaca(tipo_butaca) values ('Pasillo')
GO
	
CREATE TABLE ÑUFLO.ButacaPorAvion (
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	numero_de_butaca numeric(18,0),
	id_tipo_butaca int REFERENCES ÑUFLO.Tipo_Butaca,
	PRIMARY KEY(id_aeronave, numero_de_butaca)
	)
GO

CREATE TABLE ÑUFLO.ServicioTecnico (
	id_servicio int PRIMARY KEY,
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	fecha_fuera_de_servicio datetime,
	fecha_reinicio_de_servicio datetime
	)
GO

ALTER TABLE ÑUFLO.Aeronave
	ADD CONSTRAINT fk_baja_por_fuera_de_servicio FOREIGN KEY (baja_por_fuera_de_servicio) REFERENCES ÑUFLO.ServicioTecnico
GO
	
CREATE TABLE ÑUFLO.Viaje (
	id_viaje int IDENTITY(1,1) PRIMARY KEY,
	id_aeronave int REFERENCES ÑUFLO.Aeronave,
	id_ruta int REFERENCES ÑUFLO.Ruta_Aerea,
	peso_ocupado numeric(18,0),
	fecha_salida datetime,
	fecha_llegada datetime,
	fecha_llegada_estimada datetime
	)
GO

CREATE TABLE ÑUFLO.Cliente (
	id_cliente int IDENTITY(1,1) PRIMARY KEY,
	dni numeric(18, 0),
	nombre nvarchar(255),
	apellido nvarchar(255),
	direccion nvarchar(255),
	telefono numeric(18, 0),
	mail nvarchar(255),
	fecha_de_nacimiento datetime
	)
GO

CREATE TABLE ÑUFLO.Milla (
	id_milla int PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_obtencion datetime,
	cantidad int
	)
GO
	
CREATE TABLE ÑUFLO.Producto (
	id_producto int PRIMARY KEY,
	millas_necesarias int,
	stock int,
	descripcion nvarchar(510)
	)
GO

CREATE TABLE ÑUFLO.Canje (
	id_canje int PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	id_Producto int REFERENCES ÑUFLO.Producto,
	cantidad int,
	fecha_de_canje datetime
	)
GO

CREATE TABLE ÑUFLO.Compra (
	codigo_de_compra int PRIMARY KEY,
	id_viaje int REFERENCES ÑUFLO.Viaje,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_compra datetime
	)
GO
	
CREATE TABLE ÑUFLO.PasajeEncomienda (
	id_pasaje_encomienda int identity(1,1) PRIMARY KEY,
	codigo_de_compra  int REFERENCES ÑUFLO.Compra NOT NULL,
	id_cliente  int REFERENCES ÑUFLO.Cliente NOT NULL,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0), 
	cancelado bit DEFAULT 0,
	precio numeric(18,2),
	CHECK ((peso_encomienda IS NOT NULL) OR (numero_de_butaca IS NOT NULL))
	)
GO

CREATE TABLE ÑUFLO.Cancelacion (
	id_cancelacion int PRIMARY KEY,
	codigo_de_compra int REFERENCES ÑUFLO.Compra
	)
GO

CREATE TABLE ÑUFLO.PasajeEncomiendaPorCancelacion (
	id_pasaje_encomienda INT REFERENCES ÑUFLO.PasajeEncomienda,
	id_cancelacion int REFERENCES ÑUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255),
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
	)
GO

CREATE TABLE ÑUFLO.Funcionalidad (
	id_funcionalidad int PRIMARY KEY,
	descripcion nvarchar(255)
	)
GO

CREATE TABLE ÑUFLO.Rol (
	id_rol int PRIMARY KEY,
	nombre_rol nvarchar(255) UNIQUE,
	habilitado bit
	)
GO

CREATE TABLE ÑUFLO.Funcionalidad_Por_Rol (
	id_rol int REFERENCES ÑUFLO.Rol,
	id_funcionalidad int REFERENCES ÑUFLO.Funcionalidad,
	PRIMARY KEY(id_rol, id_funcionalidad)
	)
GO

CREATE TABLE ÑUFLO.Usuario (
	nombre_usuario nvarchar(255) PRIMARY KEY,
	password nvarchar(255),
	id_rol int REFERENCES ÑUFLO.Rol,
	cantidad_intentos smallint,
	habilitado bit
	)
GO

/**** MIGRACION *****/
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
INSERT INTO ÑUFLO.Ruta_Aerea (codigo_ruta, id_ciudad_origen, id_ciudad_destino, precio_base_por_peso, precio_base_por_pasaje)
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
INSERT INTO ÑUFLO.Servicio_Por_Ruta (id_ruta, id_tipo_servicio)
	select r.id_ruta, a.id_tipo_servicio
		from (select distinct Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino,
				case Tipo_Servicio
						when 'Primera Clase' then 1
						when 'Ejecutivo' then 2
						when 'Turista' then 3
					end id_tipo_servicio
			 from gd_esquema.Maestra) a,
			 ÑUFLO.Ruta_Aerea r,
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
		ÑUFLO.Ruta_Aerea r,
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

/*#PasajeEncomienda DEBERIA HACER FUNCION PARA BUSCAR UN id_cliente dado dni, nombre y apellido*/

/*265646 Pasajes*/
/*Compra */
INSERT INTO ÑUFLO.Compra(codigo_de_compra,id_cliente,fecha_de_compra, id_viaje)
	select Pasaje_Codigo,
			(select id_cliente 
				from ÑUFLO.Cliente c 
				where c.dni = m.Cli_Dni
					and c.nombre = m.Cli_Nombre
					and c.apellido = c.apellido), Pasaje_FechaCompra,
			(select v.id_viaje 
				from  ÑUFLO.Viaje v, ÑUFLO.Ruta_Aerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd
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
		where Butaca_Piso = 1
GO

/*Pasajes propiamente dicho*/
INSERT INTO ÑUFLO.PasajeEncomienda(codigo_de_compra, numero_de_butaca, precio, id_cliente)
	select Pasaje_Codigo, Butaca_Nro, Pasaje_Precio,
			(select id_cliente 
				from ÑUFLO.Cliente c 
				where c.dni = m.Cli_Dni
					and c.nombre = m.Cli_Nombre
					and c.apellido = c.apellido) cliente
		from gd_esquema.Maestra m
		where Butaca_Piso = 1
GO


/*135658 Encomiendas*/
/*Compra*/
INSERT INTO ÑUFLO.Compra(codigo_de_compra, fecha_de_compra, id_cliente, id_viaje)
	select Paquete_Codigo, Paquete_FechaCompra,
			(select id_cliente 
				from ÑUFLO.Cliente c 
				where c.dni = m.Cli_Dni
					and c.nombre = m.Cli_Nombre
					and c.apellido = c.apellido) cliente,
			(select v.id_viaje 
				from  ÑUFLO.Viaje v, ÑUFLO.Ruta_Aerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd
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
		where Butaca_Piso = 0
GO

/*Encomienda*/
INSERT INTO ÑUFLO.PasajeEncomienda(codigo_de_compra, peso_encomienda, precio, id_cliente)
	select Paquete_Codigo, Paquete_KG, Paquete_Precio,
			(select id_cliente 
				from ÑUFLO.Cliente c 
				where c.dni = m.Cli_Dni
					and c.nombre = m.Cli_Nombre
					and c.apellido = c.apellido)
	from gd_esquema.Maestra m
	where Butaca_Piso = 0
GO