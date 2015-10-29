USE [GD2C2015]
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
	password nvarchar(255) NOT NULL,
	id_rol int REFERENCES ÑUFLO.Rol,
	cantidad_intentos smallint DEFAULT 0 NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
	)
GO

INSERT INTO ÑUFLO.Usuario (nombre_usuario, password, id_rol)
	values ('Juan', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1)
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

/*****************************************************************/
/*************************** Function ****************************/
/*****************************************************************/

CREATE FUNCTION ÑUFLO.ButacasDisponibles(@id_viaje int)
RETURNS @Butacas TABLE
	(
	butaca_numero numeric(18,0),
	tipo nvarchar(255)
	)
AS
BEGIN
	INSERT @Butacas
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
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.PesoDisponible(@Id_viaje int)
RETURNS numeric(18,0)
AS
BEGIN
	declare @peso_disponible numeric(18,0)
	
	select @peso_disponible = (a.capacidad_peso_encomiendas - v.peso_ocupado)
		from ÑUFLO.Aeronave a, ÑUFLO.Viaje v
		where @Id_viaje = v.id_viaje
			and v.id_aeronave = a.id_aeronave
	RETURN @peso_disponible
END
GO

CREATE FUNCTION ÑUFLO.DetalleMillasDe(@dni int)
RETURNS @DetalleMillas TABLE
	(
	Tipo nvarchar(255),
	Fecha datetime,
	Cantidad int,
	Cantidad_Gastada nvarchar(255),
	Estado nvarchar(255)
	)
AS
BEGIN
	EXEC ÑUFLO.ExpirarMillas
	INSERT @DetalleMillas
		select 'Obtencion' Tipo, fecha_de_obtencion, cantidad, CAST(cantidad_gastada AS nvarchar(255)), case expirado
																											when 0 then 'Vigentes'
																											else 'Expiradas'
																										end
			from ÑUFLO.Milla m, ÑUFLO.Cliente cli
			where m.id_cliente = cli.id_cliente
				and cli.dni= @dni
		UNION
		select 'Canje' Tipo, fecha_de_canje, -cantidad, '-', '-'
			from ÑUFLO.Canje c, ÑUFLO.Cliente cli
			where c.id_cliente = cli.id_cliente
				and cli.dni= @dni
		order by fecha_de_obtencion
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.MillasTotalesDe(@dni numeric(18,0))
RETURNS int
AS
BEGIN
	declare @TotalMillas int

	select @TotalMillas = SUM(Cantidad - Cantidad_Gastada)
		from ÑUFLO.DetalleMillasDe(@dni)
		where Estado = 'Vigentes'

	RETURN @TotalMillas
END
GO

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

CREATE FUNCTION ÑUFLO.PasajesYEncomiendasDe(@codigo_compra int)
RETURNS @PasajesYEncomiendas TABLE
	(
	Codigo int,
	PoC nvarchar(255),
	DNI numeric(18,0),
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	Peso_Encomienda nvarchar(255),
	Butaca_Nro nvarchar(255), 
	Precio numeric(18,2)
	)
AS
BEGIN
	INSERT @PasajesYEncomiendas
		select p.id_pasaje_encomienda, 'Pasaje', c.dni, c.nombre, c.apellido, '-', cast(p.numero_de_butaca AS nvarchar(255)), p.precio
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
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.ViajesDisponiblesPara(@ciudad_origen nvarchar(255), @ciudad_destino nvarchar(255), @fecha datetime)
RETURNS @Viajes TABLE
	(
	Viaje int,
	Aeronave nvarchar(255),
	Peso_Ocupado numeric(18,0),
	Fecha_Salida datetime,
	Fecha_Llegada_Estimada datetime
	)
AS
BEGIN
	INSERT @Viajes
		select v.id_viaje, a.matricula, v.peso_ocupado, v.fecha_salida, v.fecha_llegada_estimada
			from ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd
			where r.id_ruta = v.id_ruta
				and r.id_ciudad_origen = co.id_ciudad
				and r.id_ciudad_destino = cd.id_ciudad
				and co.nombre = @ciudad_origen
				and cd.nombre = @ciudad_destino
				and convert(date, v.fecha_salida) = convert(date, @fecha)
				and v.id_aeronave = a.id_aeronave
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.DetallePasajePara(@ciudad nvarchar(255) = NULL, @fecha_inicio nvarchar(255), @fecha_fin nvarchar(255))
RETURNS @Pasajes TABLE
	(
	Codigo_Compra int,
	Fecha_de_Compra datetime,
	Pasaje numeric(18,0),
	Destino nvarchar(255),
	DNI nvarchar(255),
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	Butaca_Numero numeric(18,0),
	Precio numeric(18,2)
	)	
AS
BEGIN
	Insert @Pasajes
	select co.codigo_de_compra, co.fecha_de_compra, id_pasaje_encomienda, ci.nombre,  DNI, c.nombre Nombre, apellido Apellido, numero_de_butaca Butaca, precio Precio
		from ÑUFLO.Cliente c , ÑUFLO.PasajeEncomienda p, ÑUFLO.Compra co, ÑUFLO.Viaje v, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad ci
		where  co.fecha_de_compra between @fecha_inicio and @fecha_fin
			and v.id_viaje = co.id_viaje
			and v.id_ruta = r.id_ruta
			and r.id_ciudad_destino = ci.id_ciudad
			and co.codigo_de_compra = p.codigo_de_compra
			and c.id_cliente = p.id_cliente
			and p.numero_de_butaca is not null
			and (@ciudad is null
				or @ciudad = ci.nombre)
	RETURN
END
GO	

CREATE FUNCTION ÑUFLO.TOP5DestinoPasajesComprados(@fecha_inicio datetime, @fecha_fin datetime)
RETURNS @TOP5DestinosPasajes TABLE
	(
	Destino nvarchar(255),
	Cantidad_de_Pasajes_Comprados int
	)
AS
BEGIN
	INSERT @TOP5DestinosPasajes
	select top 5 Destino, COUNT(*)
		from ÑUFLO.PasajeConDestinoEnFechas(DEFAULT, @fecha_inicio, @fecha_fin)
		group by Destino
		order by COUNT(*) desc
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.DetalleAeronavesVaciasPara(@ciudad nvarchar(255) = NULL, @fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Vacias TABLE
	(
	Viaje int, 
	Destino nvarchar(255), 
	Matricula nvarchar(255), 
	Modelo nvarchar(255), 
	Fabricante nvarchar(255),
	Capacidad_Peso_Encomiendas numeric(18,0)
	)
AS
BEGIN
	INSERT @Vacias
		select v.id_viaje, ci.nombre, a.matricula, a.modelo, a.fabricante, a.capacidad_peso_encomiendas
			from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.PasajeEncomienda p, ÑUFLO.Ciudad ci, ÑUFLO.RutaAerea r, ÑUFLO.Aeronave a
			where c.fecha_de_compra between @fecha_inicio and @fecha_fin
				and v.id_ruta = r.id_ruta
				and r.id_ciudad_destino = ci.id_ciudad
				and v.id_viaje = c.id_viaje
				and c.codigo_de_compra = p.codigo_de_compra
				and v.id_aeronave = a.id_aeronave
				and (@ciudad IS NULL
					or @ciudad = ci.nombre)
			group by v.id_viaje, ci.nombre, a.matricula, a.modelo, a.fabricante, a.capacidad_peso_encomiendas
			having COUNT(*) = 0
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.TOP5DestinoAeronavesVacias(@fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Destinos TABLE 
	(
	Destino nvarchar(255),
	Cantidad_Aeronaves_Vacias int
	)
AS
BEGIN
	INSERT @Destinos
		select top 5 Destino, COUNT(*) 
			from ÑUFLO.DestinoAeronavesVaciasPara(DEFAULT, @fecha_inicio, @fecha_fin)
			group by Destino
			order by COUNT(*) desc
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.DetalleMillasPara(@dni numeric(18,0) = NULL, @fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Detalles TABLE
	(
	Tipo nvarchar(255),
	DNI numeric (18,0),
	Millas_Acumuladas int,
	Fecha datetime
	)
AS
BEGIN
	EXEC ÑUFLO.ExpirarMillas
	INSERT @Detalles
		select case 
				when dm.cant < 0 then 'Canje'
				else 'Obtencion'
				end, *
			from(select c.dni, m.cantidad cant, m.fecha_de_obtencion fecha
					from ÑUFLO.Cliente c ,  ÑUFLO.Milla m
					where c.id_cliente = m.id_cliente
						and m.fecha_de_obtencion between @fecha_inicio and @fecha_fin
						and (@dni IS NULL
							or @dni = c.dni)
				UNION
				select c.dni, -ca.cantidad cant, ca.fecha_de_canje fecha
					from ÑUFLO.Cliente c ,  ÑUFLO.Canje ca
					where c.id_cliente = ca.id_cliente
						and ca.fecha_de_canje between @fecha_inicio and @fecha_fin
						and (@dni IS NULL
							or @dni = c.dni)) dm
			order by dm.fecha
		
	RETURN	
END
GO

CREATE FUNCTION ÑUFLO.TOP5MillasDeClientes(@fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Clientes TABLE
	(
	DNI numeric (18,0),
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	Millas_Acumuladas int
	)
AS
BEGIN
	INSERT @Clientes
		select top 5 m.dni, c.nombre, c.apellido, SUM(Millas_Acumuladas)
			from ÑUFLO.DetalleMillasPara(DEFAULT, @fecha_inicio, @fecha_fin) m, ÑUFLO.Cliente c
			where m.DNI = c.dni
			group by m.dni, c.nombre, c.apellido
			order by SUM(Millas_Acumuladas) desc
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.DetalleCancelacionesPara(@ciudad nvarchar(255), @fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Cancelaciones TABLE
	(
	Pasaje numeric(18,0),
	DNI numeric(18,0),
	Nombre nvarchar(255),
	Apellido nvarchar(255), 
	Butaca_Numero numeric(18,0),
	Fecha_Devolucion datetime,
	Motivo nvarchar(255)
	)
AS
BEGIN
	INSERT @Cancelaciones
		select pc.id_pasaje_encomienda, p.dni, p.nombre_cliente, p.apellido, p.numero_de_butaca ,c.fecha_devolucion, pc.motivo_cancelacion
			from ÑUFLO.PasajeConDestinoEnFechas(DEFAULT, @fecha_inicio, @fecha_fin) p,
				ÑUFLO.Cancelacion c,
				ÑUFLO.PasajeEncomiendaPorCancelacion pc
			where p.nombre_ciudad = @ciudad
				and p.pasaje = pc.id_pasaje_encomienda
				and p.codigo_compra = c.codigo_de_compra

	RETURN
END
GO

CREATE FUNCTION ÑUFLO.TOP5DestinoCancelaciones(@fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Destinos TABLE
	(
	Destino nvarchar(255),
	Cantidad_de_Cancelaciones int
	)
AS
BEGIN
	INSERT @Destinos
		select top 5 p.nombre_ciudad, COUNT(*)
			from ÑUFLO.PasajeConDestinoEnFechas(DEFAULT, @fecha_inicio, @fecha_fin) p,
				ÑUFLO.Cancelacion c,
				ÑUFLO.PasajeEncomiendaPorCancelacion pc
			where p.pasaje = pc.id_pasaje_encomienda
				and p.codigo_compra = c.codigo_de_compra
			group by p.nombre_ciudad
	RETURN
END
GO

CREATE FUNCTION ÑUFLO.DetalleServicioTecnicoPara(@matricula nvarchar(255) = NULL, @fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Detalle TABLE
	(
	Matricula nvarchar(255),
	Modelo nvarchar(255), 
	Fabricante nvarchar(255), 
	Capacidad_Peso_Encomiendas numeric(18,0), 
	Fecha_Fuera_de_Servicio datetime, 
	Dias_Fuera_Servicio int
	)
AS
BEGIN
	INSERT INTO @Detalle
		select a.matricula, a.modelo, a.fabricante, a.capacidad_peso_encomiendas, st.fecha_fuera_de_servicio,
				case
					 when @fecha_fin < st.fecha_reinicio_de_servicio then DATEDIFF(DD, st.fecha_fuera_de_servicio, @fecha_fin)
					 else DATEDIFF(DD, st.fecha_fuera_de_servicio, st.fecha_reinicio_de_servicio) 
				 end Dias_Fuera_de_Servicio
			from ÑUFLO.Aeronave a, ÑUFLO.ServicioTecnico st
			where st.id_aeronave = a.id_aeronave
				and st.fecha_fuera_de_servicio between @fecha_inicio and @fecha_fin
				and (@matricula IS NULL
				or @matricula = a.matricula)

	RETURN
END
GO

CREATE FUNCTION ÑUFLO.TOP5DiasFueraDeServicio(@fecha_inicio datetime, @fecha_fin datetime)
RETURNS @Aeronaves TABLE
	(
	Matricula nvarchar(255),
	Modelo nvarchar(255),
	Fabricante nvarchar(255),
	Capacidad_Peso_Encomiendas int,
	Cantidad_Dias_Fuera int
	)
AS
BEGIN
	INSERT @Aeronaves
		select matricula, modelo, fabricante, capacidad_peso_encomiendas, SUM(Dias_Fuera_Servicio)
			from ÑUFLO.DetalleServicioTecnicoPara(DEFAULT, @fecha_inicio, @fecha_fin)
		group by matricula, modelo, fabricante, capacidad_peso_encomiendas
		order by SUM(Dias_Fuera_Servicio) desc
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
	UPDATE ÑUFLO.Milla
	SET cantidad = m.cantidad - p.millas_necesarias ,fecha_de_obtencion = i.fecha_de_canje
	FROM inserted i, ÑUFLO.Producto p, ÑUFLO.Milla m
	WHERE i.id_cliente = m.id_cliente
		AND i.id_Producto = p.id_producto
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
