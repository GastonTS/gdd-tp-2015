USE [GD2C2015]
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
	tipo_servicio nvarchar(255)
	)
GO


INSERT INTO ÑUFLO.Tipo_Servicio(tipo_servicio) values ('Primera Clase')
INSERT INTO ÑUFLO.Tipo_Servicio(tipo_servicio) values ('Ejecutivo')
INSERT INTO ÑUFLO.Tipo_Servicio(tipo_servicio) values ('Turista')
GO

CREATE TABLE ÑUFLO.Ruta_Aerea (
	id_ruta int IDENTITY(1,1) PRIMARY KEY,
	codigo_ruta numeric(18,0),
	id_ciudad_origen int REFERENCES ÑUFLO.Ciudad,
	id_ciudad_destino int REFERENCES ÑUFLO.Ciudad,
	precio_base_por_peso numeric(18,2),
	precio_base_por_pasaje numeric(18,2),
	id_tipo_servicio int REFERENCES ÑUFLO.Tipo_Servicio
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
	id_cliente int PRIMARY KEY,
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
	id_pasaje_encomienda numeric(18,0) PRIMARY KEY,
	codigo_de_compra  int REFERENCES ÑUFLO.Compra,
	id_cliente  int REFERENCES ÑUFLO.Cliente,
	peso_encomienda numeric(18, 0),
	numero_de_butaca numeric(18, 0),
	cancelado bit
	)
GO

CREATE TABLE ÑUFLO.Cancelacion (
	id_cancelacion int PRIMARY KEY,
	codigo_de_compra int REFERENCES ÑUFLO.Compra
	)
GO

CREATE TABLE ÑUFLO.PasajeEncomiendaPorCancelacion (
	id_pasaje_encomienda numeric(18,0) REFERENCES ÑUFLO.PasajeEncomienda,
	id_cancelacion int REFERENCES ÑUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255),
	PRIMARY KEY (id_cancelacion, id_pasaje_encomienda)
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
		JOIN (select distinct Aeronave_Matricula, Butaca_Nro, Butaca_Tipo
			from gd_esquema.Maestra) b ON matricula = Aeronave_Matricula
	where Butaca_Tipo <> '0'
	order by id_aeronave, Butaca_Nro
GO
	
/*68 Ruta Aerea - Codigos Ruta Repetidos, Escalas?*/
INSERT INTO ÑUFLO.Ruta_Aerea (codigo_ruta, id_ciudad_origen, id_ciudad_destino, precio_base_por_peso, precio_base_por_pasaje, id_tipo_servicio)
	select distinct Ruta_Codigo, co.id_ciudad, cd.id_ciudad, SUM(Ruta_Precio_BaseKG), 
					SUM(Ruta_Precio_BasePasaje), id_tipo_servicio
	from (select distinct Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Ruta_Precio_BaseKG, Ruta_Precio_BasePasaje,
			case Tipo_Servicio
					when 'Primera Clase' then 1
					when 'Ejecutivo' then 2
					when 'Turista' then 3
				end id_tipo_servicio
		 from gd_esquema.Maestra) a,
		 ÑUFLO.Ciudad co,
		 ÑUFLO.Ciudad cd
	where co.nombre = Ruta_Ciudad_Origen
		AND cd.nombre = Ruta_Ciudad_Destino
	group by Ruta_Codigo, co.id_ciudad, cd.id_ciudad, id_tipo_servicio
	order by Ruta_Codigo
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
		AND r.codigo_ruta = Ruta_Codigo
		AND co.nombre = Ruta_Ciudad_Origen
		AND cd.nombre = Ruta_Ciudad_Destino
		AND r.id_ciudad_origen = co.id_ciudad
		AND r.id_ciudad_destino = cd.id_ciudad
	order by FechaSalida
GO