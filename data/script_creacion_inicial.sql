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
	codigo_ruta numeric(18,0) NOT NULL,
	id_ciudad_origen int REFERENCES ÑUFLO.Ciudad NOT NULL,
	id_ciudad_destino int REFERENCES ÑUFLO.Ciudad NOT NULL,
	precio_base_por_peso numeric(18,2) NOT NULL,
	precio_base_por_pasaje numeric(18,2) NOT NULL,
	cancelado bit DEFAULT 0
	)
GO

CREATE TABLE ÑUFLO.ServicioPorRuta (
	id_ruta int REFERENCES ÑUFLO.RutaAerea,
	id_tipo_servicio int REFERENCES ÑUFLO.TipoServicio,
	PRIMARY KEY(id_ruta, id_tipo_servicio)
	)
GO

CREATE TABLE ÑUFLO.Fabricante (
	id_fabricante int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255) NOT NULL
	)
GO

CREATE TABLE ÑUFLO.Modelo (
	id_modelo int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255) NOT NULL
	)
GO

CREATE TABLE ÑUFLO.Aeronave (
	id_aeronave int IDENTITY(1,1) PRIMARY KEY,
	id_modelo int REFERENCES ÑUFLO.Modelo,
	matricula nvarchar(255) UNIQUE NOT NULL,
	id_fabricante int REFERENCES ÑUFLO.Fabricante,
	id_tipo_servicio int REFERENCES ÑUFLO.TipoServicio,
	fecha_de_alta datetime NOT NULL,
	capacidad_peso_encomiendas numeric(18,0) NOT NULL,
	cantidad_butacas int,
	baja_vida_utill datetime,
	baja_por_fuera_de_servicio int DEFAULT 0
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
	fecha_de_nacimiento datetime NOT NULL
	)
GO

CREATE TABLE ÑUFLO.Milla (
	id_milla int IDENTITY(1,1) PRIMARY KEY,
	id_cliente int REFERENCES ÑUFLO.Cliente,
	fecha_de_obtencion datetime,
	cantidad int DEFAULT 0,
	cantidad_gastada int DEFAULT 0,
	expirado bit DEFAULT 0
	)
GO
	
CREATE TABLE ÑUFLO.Producto (
	id_producto int IDENTITY(1,1) PRIMARY KEY,
	millas_necesarias int NOT NULL,
	stock int NOT NULL,
	descripcion nvarchar(255) UNIQUE NOT NULL
	)
GO

INSERT INTO ÑUFLO.Producto VALUES (100, 5, 'Valija')
INSERT INTO ÑUFLO.Producto VALUES (50, 10, 'Campera')
INSERT INTO ÑUFLO.Producto VALUES (10, 20, 'Pelota de futbol')

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

CREATE TABLE ÑUFLO.TarjetaDeCredito (
	id_tarjeta int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(255) UNIQUE,
	cantidad_de_cuotas int
)
GO

INSERT INTO ÑUFLO.TarjetaDeCredito(nombre, cantidad_de_cuotas) values('American Express', 6)
INSERT INTO ÑUFLO.TarjetaDeCredito(nombre, cantidad_de_cuotas) values('Master Card', 12)
INSERT INTO ÑUFLO.TarjetaDeCredito(nombre, cantidad_de_cuotas) values('Cabal', 3)
GO
	
CREATE TABLE ÑUFLO.Pasaje (
	id_pasaje int PRIMARY KEY,
	codigo_de_compra  int REFERENCES ÑUFLO.Compra,
	id_cliente  int REFERENCES ÑUFLO.Cliente,
	numero_de_butaca numeric(18, 0) NOT NULL, 
	cancelado bit DEFAULT 0,
	precio numeric(18,2) NOT NULL,
	)
GO

CREATE TABLE ÑUFLO.Encomienda (
	id_encomienda int PRIMARY KEY,
	codigo_de_compra  int REFERENCES ÑUFLO.Compra,
	id_cliente  int REFERENCES ÑUFLO.Cliente,
	peso_encomienda numeric(18, 0) NOT NULL,
	cancelado bit DEFAULT 0,
	precio numeric(18,2) NOT NULL,
	)
GO

CREATE TABLE ÑUFLO.Cancelacion (
	id_cancelacion int IDENTITY(1,1) PRIMARY KEY,
	codigo_de_compra int REFERENCES ÑUFLO.Compra,
	fecha_devolucion datetime
	)
GO

CREATE TABLE ÑUFLO.PasajePorCancelacion (
	id_pasaje INT REFERENCES ÑUFLO.Pasaje,
	id_cancelacion int REFERENCES ÑUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255) NOT NULL,
	PRIMARY KEY (id_cancelacion, id_pasaje)
	)
GO

CREATE TABLE ÑUFLO.EncomiendaPorCancelacion (
	id_encomienda INT REFERENCES ÑUFLO.Encomienda,
	id_cancelacion int REFERENCES ÑUFLO.Cancelacion,
	motivo_cancelacion  nvarchar(255) NOT NULL,
	PRIMARY KEY (id_cancelacion, id_encomienda)
	)
GO

CREATE TABLE ÑUFLO.Funcionalidad (
	id_funcionalidad int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255) NOT NULL
	)
GO

INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Rol')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Ruta Aerea')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('ABM Aeronave')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Generar Viaje')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Registrar Llegada')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Compra Pasaje/Encomienda') --cliente
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Cancelacion Pasaje/Encomienda')
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Consultar Millas') --cliente
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Canjear Millas') --cliente
INSERT INTO ÑUFLO.Funcionalidad (descripcion) values ('Listados Estadisticos')
GO

CREATE TABLE ÑUFLO.Rol (
	id_rol int IDENTITY(1,1) PRIMARY KEY,
	nombre_rol nvarchar(255) UNIQUE NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
	)
GO

INSERT INTO ÑUFLO.Rol (nombre_rol)
	values ('Administrador')
INSERT INTO ÑUFLO.Rol (nombre_rol)
	values ('Cliente')

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

INSERT INTO ÑUFLO.FuncionalidadPorRol values (2,6)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (2,8)
INSERT INTO ÑUFLO.FuncionalidadPorRol values (2,9)
GO

CREATE TABLE ÑUFLO.Usuario (
	nombre_usuario nvarchar(255) PRIMARY KEY,
	password varbinary(255) NOT NULL,
	cantidad_intentos smallint DEFAULT 0 NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
	)
GO

INSERT INTO ÑUFLO.Usuario (nombre_usuario, password)
	values ('Juan', HASHBYTES('SHA2_256', 'w23e'))
INSERT INTO ÑUFLO.Usuario (nombre_usuario, password)
	values ('Ramiro', HASHBYTES('SHA2_256', 'w23e'))
GO

CREATE TABLE ÑUFLO.RolPorUsuario (
	id_rol int REFERENCES ÑUFLO.Rol,
	nombre_usuario nvarchar(255) REFERENCES ÑUFLO.Usuario,
	PRIMARY KEY(id_rol, nombre_usuario)
	)
GO

INSERT INTO ÑUFLO.RolPorUsuario(id_rol, nombre_usuario)
	values(1, 'Juan')
INSERT INTO ÑUFLO.RolPorUsuario(id_rol, nombre_usuario)
	values(2, 'Ramiro')
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

/*4 Fabricante*/
INSERT INTO ÑUFLO.Fabricante
	select distinct Aeronave_Fabricante
	from gd_esquema.Maestra
GO

/*1 Modelo*/
INSERT INTO ÑUFLO.Modelo
	select distinct Aeronave_Modelo
	from gd_esquema.Maestra
GO

/*30 Aeronave*/
INSERT INTO ÑUFLO.Aeronave (matricula, id_modelo, id_fabricante, capacidad_peso_encomiendas, fecha_de_alta, id_tipo_servicio)
	select distinct Aeronave_Matricula, m.id_modelo, f.id_fabricante, Aeronave_KG_Disponibles, GETDATE(),
				case Tipo_Servicio
					when 'Primera Clase' then 1
					when 'Ejecutivo' then 2
					when 'Turista' then 3
				end id_tipo_servicio
	from gd_esquema.Maestra ma, Ñuflo.Modelo m, Ñuflo.Fabricante f
	where Aeronave_Fabricante = f.nombre
		and Aeronave_Modelo = m.nombre
	order by Aeronave_Matricula
GO
	
/*1337 Butacas*/
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

UPDATE a
		set cantidad_butacas = (select count(*) from ÑUFLO.ButacaPorAvion
								where id_aeronave = a.id_aeronave)
FROM ÑUFLO.Aeronave a
GO

ALTER TABLE ÑUFLO.Aeronave ALTER COLUMN cantidad_butacas INTEGER NOT NULL
GO

	
/*68 Ruta Aerea*/
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

/*68 Servicio Por Ruta*/
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

/*8510 Viaje*/
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
CREATE TABLE #CompraPasaje (
	codigo_compra int IDENTITY(1,1),
	numero_butaca numeric(18,0),
	pasaje_precio numeric(18,2),
	id_pasaje numeric(18,0),
	fecha_compra datetime,
	id_cliente int,
	id_viaje int
	)
GO

CREATE TABLE #CompraEncomienda (
	codigo_compra int IDENTITY(1,1),
	paquete_kg numeric(18,0),
	paquete_precio numeric(18,2),
	id_encomienda numeric(18,0),
	fecha_compra datetime,
	id_cliente int,
	id_viaje int
	)
GO

INSERT INTO #CompraPasaje(numero_butaca, pasaje_precio, id_pasaje, fecha_compra, id_cliente, id_viaje)
	select Butaca_Nro, Pasaje_Precio, Pasaje_Codigo, Pasaje_FechaCompra,
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
		where Pasaje_Codigo != 0
GO

INSERT INTO #CompraEncomienda(paquete_kg, paquete_precio, id_encomienda, fecha_compra, id_cliente, id_viaje)
	select Paquete_KG, Paquete_Precio, Paquete_Codigo, Paquete_FechaCompra,
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
		where Paquete_Codigo != 0
GO

/*401304 Compra*/
INSERT INTO ÑUFLO.Compra (id_viaje, id_cliente, fecha_de_compra)
	select id_viaje, id_cliente, fecha_compra
		from  #CompraPasaje
GO

INSERT INTO ÑUFLO.Compra (id_viaje, id_cliente, fecha_de_compra)
	select id_viaje, id_cliente, fecha_compra
		from  #CompraEncomienda
GO

/*401304 PasajeEncomienda */
INSERT INTO ÑUFLO.Pasaje (id_pasaje, codigo_de_compra, id_cliente, numero_de_butaca, precio)
	select id_pasaje, codigo_compra, id_cliente, numero_butaca, pasaje_precio
		from #CompraPasaje
GO

INSERT INTO ÑUFLO.Encomienda (id_encomienda, codigo_de_compra, id_cliente, peso_encomienda, precio)
	select id_encomienda, (select MAX(codigo_compra) from #CompraPasaje) + codigo_compra, id_cliente, paquete_kg, paquete_precio
		from #CompraEncomienda
GO
	
/*****************************************************************/
/*********************** Stored Procedures ***********************/
/*****************************************************************/

/*Usuario*/
CREATE PROCEDURE ÑUFLO.LogearUsuario
@usuario nvarchar(255),
@password varchar(255)
AS
DECLARE @intentos smallint, @habilitado bit
SET @intentos = (select cantidad_intentos from ÑUFLO.Usuario where nombre_usuario = @usuario)
SET @habilitado = (select habilitado from ÑUFLO.Usuario where nombre_usuario = @usuario)
IF (@habilitado = 1 or @habilitado is null)
BEGIN
	DECLARE @hash varbinary(255)
	SET @hash = (select password from ÑUFLO.Usuario where nombre_usuario = @usuario)
	
	IF (@hash =  HASHBYTES('SHA2_256', @password))
		BEGIN
			UPDATE ÑUFLO.Usuario
				SET cantidad_intentos = 0, habilitado = 1
				WHERE nombre_usuario = @usuario
				SELECT 1
		END
	ELSE
		BEGIN
			SELECT -1
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

CREATE PROCEDURE ÑUFLO.FuncionalidadesPorUsuario
@nombre_usuario nvarchar(255)
AS
select distinct f.id_funcionalidad, f.descripcion
	from ÑUFLO.Funcionalidad f, ÑUFLO.FuncionalidadPorRol fr, ÑUFLO.RolPorUsuario ru
	where f.id_funcionalidad = fr.id_funcionalidad
		and fr.id_rol = ru.id_rol
		and ru.nombre_usuario = @nombre_usuario
;
GO

/*Cliente*/
CREATE PROCEDURE ÑUFLO.ConsultaCliente
@dni numeric(18,0)
AS
	select nombre, apellido, direccion, telefono, mail, fecha_de_nacimiento
		from ÑUFLO.Cliente
		where dni = @dni
;
GO

CREATE PROCEDURE ÑUFLO.ModificarCliente
@dni numeric(18,0),
@nombre nvarchar(255),
@apellido nvarchar(255),
@direccion nvarchar(255),
@telefono numeric(18,0),
@mail nvarchar(255),
@fecha_de_nacimiento datetime
AS
	IF(NOT EXISTS (select id_cliente from ÑUFLO.Cliente where dni = @dni))
		INSERT INTO ÑUFLO.Cliente(dni, nombre, apellido, direccion, telefono, mail, fecha_de_nacimiento)
			values(@dni, @nombre, @apellido, @direccion, @telefono, @mail, @fecha_de_nacimiento)
	ELSE
		UPDATE ÑUFLO.Cliente
			SET nombre = @nombre, apellido = @apellido, direccion = @direccion, 
				telefono = @telefono, mail = @mail, fecha_de_nacimiento = @fecha_de_nacimiento
			where dni = @dni
;
GO

CREATE PROCEDURE ÑUFLO.MillasTotalesDe
@dni NUMERIC(18,0)
AS
select ÑUFLO.TotalMillasDe(@dni)
;
GO

CREATE PROCEDURE ÑUFLO.ProductosDe
@dni NUMERIC(18,0)
AS
	DECLARE @millas_cliente NUMERIC(18,0)
	SET @millas_cliente = (select ÑUFLO.TotalMillasDe(@dni))
	
	SELECT descripcion 
		FROM ÑUFLO.Producto
		WHERE millas_necesarias <= @millas_cliente
;
GO	

CREATE PROCEDURE ÑUFLO.CanjearProductoA
@dni NUMERIC(18,0),
@cantidad int,
@descripcion nvarchar(255),
@hoy datetime
AS
	DECLARE @gasto int, @id_producto int
	SET @id_producto = (select id_producto from ÑUFLO.Producto where descripcion = @descripcion)
	SET @gasto = (select millas_necesarias * @cantidad from ÑUFLO.Producto where id_producto = @id_producto)
	
	IF((select ÑUFLO.TotalMillasDe(@dni)) < @gasto)
		THROW 60008, 'El cliente no posee suficientes millas para realizar el canje', 1
	
	IF((select stock from ÑUFLO.Producto where id_producto = @id_producto) < @cantidad or @id_Producto is null)
		THROW 60009, 'No hay suficiente stock del producto deseado para realizar el canje', 1

	INSERT INTO ÑUFLO.Canje(id_cliente, id_Producto, cantidad, fecha_de_canje)
		values((select top 1 id_cliente from ÑUFLO.Cliente where dni=@dni), @id_producto, @cantidad, @hoy)
			
;
GO	

CREATE PROCEDURE ÑUFLO.ExpirarMillas
@hoy datetime
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

		IF(DATEDIFF(DD, @fecha, @hoy) > 365)
			UPDATE ÑUFLO.Milla
			 set expirado = 1
			 where id_milla = @id_milla

		FETCH CMillas INTO @id_milla, @fecha
	END

	CLOSE CMillas
	DEALLOCATE CMillas
;
GO

/*Aeronave*/

CREATE PROCEDURE ÑUFLO.IncorporarAeronavesFueraDeServicio
@hoy datetime
AS
	DECLARE @id_aeronave int
	DECLARE @fecha_reinicio_de_servicio datetime
	DECLARE CServicio CURSOR 
		FOR select st.id_aeronave, st.fecha_reinicio_de_servicio
				from ÑUFLO.ServicioTecnico st JOIN ÑUFLO.Aeronave a ON st.id_aeronave = a.id_aeronave
				where a.baja_por_fuera_de_servicio = 1 and
					  a.baja_vida_utill IS NULL and
					  st.fecha_reinicio_de_servicio = (select max(st2.fecha_reinicio_de_servicio)
														 from ÑUFLO.ServicioTecnico st2
														 where st2.id_aeronave = st.id_aeronave
														 group by st2.id_aeronave)

	OPEN CServicio 
	FETCH CServicio INTO @id_aeronave, @fecha_reinicio_de_servicio

	WHILE (@@FETCH_STATUS = 0)
	BEGIN	

		IF(@fecha_reinicio_de_servicio <= @hoy)
			UPDATE ÑUFLO.Aeronave
			 set baja_por_fuera_de_servicio = 0
			 where id_aeronave = @id_aeronave

		FETCH CServicio INTO @id_aeronave, @fecha_reinicio_de_servicio
	END

	CLOSE CServicio
	DEALLOCATE CServicio
	
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
@cantidad_butacas int = null,
@hoy datetime
AS

exec ÑUFLO.IncorporarAeronavesFueraDeServicio @hoy

select id_aeronave 'ID Aeronave', m.nombre Modelo, matricula Matricula, f.nombre Fabricante, ts.tipo_servicio 'Tipo de Servicio', fecha_de_alta 'Fecha de Alta',
		capacidad_peso_encomiendas 'Capacidad Encomiendas', baja_vida_utill 'Baja vida util', baja_por_fuera_de_servicio 'Fuera de Servicio'
	from ÑUFLO.Aeronave a, ÑUFLO.Modelo m, ÑUFLO.Fabricante f, ÑUFLO.TipoServicio ts
	where a.id_modelo = m.id_modelo
		and a.id_fabricante = f.id_fabricante
		and (@modelo is null or @modelo = m.nombre)
		and (@matricula is null or @matricula = matricula)
		and (@fabricante is null or @fabricante = f.nombre)
		and (@baja_fuera_servicio is null or @baja_fuera_servicio = baja_por_fuera_de_servicio)
		and (@baja_vida_util is null or (@baja_vida_util = 1 and baja_vida_utill is not null))
		and (@tipo_servicio is null or @tipo_servicio = a.id_tipo_servicio)
		and (@capacidad_encomiendas is null or @capacidad_encomiendas < capacidad_peso_encomiendas)
		and a.id_tipo_servicio = ts.id_tipo_servicio
		and (@cantidad_butacas is null or @cantidad_butacas <= (select COUNT(id_tipo_butaca) 
																	from ÑUFLO.ButacaPorAvion b
																	where a.id_aeronave = b.id_aeronave))

;
GO

CREATE PROCEDURE ÑUFLO.ButacasDe
@id_aeronave int
AS
select numero_de_butaca, id_tipo_butaca
	from ÑUFLO.ButacaPorAvion
	where id_aeronave = @id_aeronave
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
	DECLARE @id_modelo int, @id_fabricante int
	
	IF(NOT EXISTS(select id_modelo from ÑUFLO.Modelo where @modelo = nombre))
		INSERT INTO ÑUFLO.Modelo(nombre)
			values(@modelo)

	set @id_modelo = (select id_modelo from ÑUFLO.Modelo where @modelo = nombre)

	IF(NOT EXISTS(select id_fabricante from ÑUFLO.Fabricante where @fabricante = nombre))
		INSERT INTO ÑUFLO.Fabricante(nombre)
			values(@fabricante)

	set @id_fabricante = (select id_fabricante from ÑUFLO.Fabricante where @fabricante = nombre)
	
	INSERT INTO ÑUFLO.Aeronave(matricula, id_modelo, id_fabricante, id_tipo_servicio, capacidad_peso_encomiendas, fecha_de_alta, cantidad_butacas)
		values(@matricula, @id_modelo, @id_fabricante, @tipo_de_servicio, @capacidad_de_encomiendas, convert(datetime, @fecha_hoy), 0)
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
		
	UPDATE ÑUFLO.Aeronave
		SET cantidad_butacas = cantidad_butacas + 1
		
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
	DECLARE @id_modelo int, @id_fabricante int
	
	IF(NOT EXISTS(select id_modelo from ÑUFLO.Modelo where @modelo = nombre))
		INSERT INTO ÑUFLO.Modelo(nombre)
			values(@modelo)

	set @id_modelo = (select id_modelo from ÑUFLO.Modelo where @modelo = nombre)

	IF(NOT EXISTS(select id_fabricante from ÑUFLO.Fabricante where @fabricante = nombre))
		INSERT INTO ÑUFLO.Fabricante(nombre)
			values(@fabricante)

	set @id_fabricante = (select id_fabricante from ÑUFLO.Fabricante where @fabricante = nombre)
	
	UPDATE ÑUFLO.Aeronave
		SET matricula = @matricula, 
			id_modelo = @id_modelo, 
			id_fabricante = @id_fabricante, 
			id_tipo_servicio = @tipo_de_servicio, 
			capacidad_peso_encomiendas = @capacidad_de_encomiendas, 
			fecha_de_alta = convert(datetime, @fecha_hoy)
		WHERE id_aeronave = @id_aeronave
;
GO

CREATE PROCEDURE ÑUFLO.ValidarAeronaveActiva
@id_aeronave int,
@fecha_hoy datetime,
@fecha_fin datetime = null
AS
	IF(@fecha_fin is not null and @fecha_fin < @fecha_hoy)
		THROW 62004, 'La fecha de reincorporacion debe ser mayor a la fecha de hoy', 1

	IF((select baja_vida_utill from ÑUFLO.Aeronave where id_aeronave = @id_aeronave) is not null)
		THROW 60004, 'La nave ya se encuentra fuera de su vida util', 1

	IF((select baja_por_fuera_de_servicio from ÑUFLO.Aeronave where id_aeronave = @id_aeronave) = 1)
		THROW 60003, 'La nave ya se encuentra en mantenimiento', 1
		
	select COUNT(id_viaje)
		from ÑUFLO.Viaje
		where id_aeronave = @id_aeronave
			and (@fecha_fin is null and fecha_salida > @fecha_hoy
				 or fecha_salida between @fecha_hoy and @fecha_fin)
			and fecha_llegada is not null
;
GO

CREATE PROCEDURE ÑUFLO.BajaPorVidaUtil
@id_aeronave int,
@fecha nvarchar(255)
AS	
	DECLARE @fecha_baja datetime
	SET @fecha_baja = convert(datetime, @fecha)

	UPDATE ÑUFLO.Aeronave
		SET baja_vida_utill = @fecha_baja
		WHERE id_aeronave = @id_aeronave
;
GO

CREATE PROCEDURE ÑUFLO.BajaFueraDeServicio
@id_aeronave int,
@fecha_fuera datetime,
@fecha_rein datetime
AS
	UPDATE ÑUFLO.Aeronave
		SET baja_por_fuera_de_servicio = 1
		WHERE id_aeronave = @id_aeronave
	
	INSERT INTO ÑUFLO.ServicioTecnico(fecha_fuera_de_servicio, fecha_reinicio_de_servicio, id_aeronave)
		values(@fecha_fuera, @fecha_rein, @id_aeronave)			
;
GO

CREATE PROCEDURE ÑUFLO.CancelarPasajesDe
@id_aeronave int,
@fecha_hoy nvarchar(255),
@fecha_fin nvarchar(255) = null
AS
	DECLARE @fecha_f datetime, @hoy datetime
	SET @hoy = convert(datetime, @fecha_hoy)
	SET @fecha_f = convert(datetime, @fecha_fin)

	DECLARE CPasajes CURSOR 
		FOR select c.codigo_de_compra, p.id_pasaje
				from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.Pasaje p
				where @id_aeronave = v.id_aeronave
					and ((@fecha_f is null and v.fecha_salida > @hoy)
					or v.fecha_salida between @hoy and @fecha_f)
					and v.id_viaje = c.id_viaje
					and c.codigo_de_compra = p.codigo_de_compra
					and p.cancelado = 0
					and v.fecha_llegada is null
					
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

		INSERT INTO ÑUFLO.PasajePorCancelacion(id_cancelacion, id_pasaje, motivo_cancelacion)
			values((select MAX(id_cancelacion) from ÑUFLO.Cancelacion), @pasaje, 'Baja de Aeronave')

		UPDATE ÑUFLO.Pasaje
			SET cancelado = 1
			WHERE @pasaje = id_pasaje

		FETCH CPasajes INTO @pnr, @pasaje
	END

	CLOSE CPasajes
	DEALLOCATE CPasajes
;
GO

CREATE PROCEDURE ÑUFLO.CancelarEncomiendasDe
@id_aeronave int,
@fecha_hoy nvarchar(255),
@fecha_fin nvarchar(255) = null
AS
	DECLARE @fecha_f datetime, @hoy datetime
	SET @hoy = convert(datetime, @fecha_hoy)
	SET @fecha_f = convert(datetime, @fecha_fin)

	DECLARE CEncomienda CURSOR 
		FOR select c.codigo_de_compra, e.id_encomienda
				from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.Encomienda e
				where @id_aeronave = v.id_aeronave
					and ((@fecha_f is null and v.fecha_salida > @hoy)
					or v.fecha_salida between @hoy and @fecha_f)
					and v.id_viaje = c.id_viaje
					and c.codigo_de_compra = e.codigo_de_compra
					and e.cancelado = 0
					and v.fecha_llegada is null
					
	DECLARE @pnr int, @encomienda int, @cod_anterior int
	SET @cod_anterior = -1
	OPEN CEncomienda
	FETCH CEncomienda INTO @pnr, @encomienda

	WHILE (@@FETCH_STATUS = 0)
	BEGIN	
		if(@pnr <> @cod_anterior)
		BEGIN
			INSERT INTO ÑUFLO.Cancelacion(codigo_de_compra, fecha_devolucion)
				values(@pnr, @hoy)
			SET @cod_anterior = @pnr
		END

		INSERT INTO ÑUFLO.EncomiendaPorCancelacion(id_cancelacion, id_encomienda, motivo_cancelacion)
			values((select MAX(id_cancelacion) from ÑUFLO.Cancelacion), @encomienda, 'Baja de Aeronave')

		UPDATE ÑUFLO.Encomienda
			SET cancelado = 1
			WHERE @encomienda = id_encomienda

		FETCH CEncomienda INTO @pnr, @encomienda
	END

	CLOSE CEncomienda
	DEALLOCATE CEncomienda
;
GO

CREATE PROCEDURE ÑUFLO.CancelarPasajesYEncomiendasDe
@id_aeronave int,
@fecha_hoy nvarchar(255),
@fecha_fin nvarchar(255) = null
AS

	EXEC ÑUFLO.CancelarPasajesDe @id_aeronave, @fecha_hoy, @fecha_fin
	EXEC ÑUFLO.CancelarEncomiendasDe @id_aeronave, @fecha_hoy, @fecha_fin

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
	SET @modelo = (select id_modelo from ÑUFLO.Aeronave where id_aeronave = @id_aeronave)
	SET @fabricante = (select id_fabricante from ÑUFLO.Aeronave where id_aeronave = @id_aeronave)
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
			select a.id_aeronave
				from ÑUFLO.Aeronave a
				where @modelo = a.id_modelo
					and @fabricante = a.id_fabricante
					and @tipo_servicio = a.id_tipo_servicio
					and baja_por_fuera_de_servicio is null
					and baja_vida_utill is null
					and NOT EXISTS (select * from ÑUFLO.ViajesDeAeronaveEntre(a.id_aeronave, @salida, @llegada))
		 
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

CREATE PROCEDURE ÑUFLO.AeronavePorMatricula
@matricula nvarchar(255)
AS
	select a.id_aeronave, a.id_modelo, m.nombre Modelo, a.id_fabricante,f.nombre Fabricante, a.matricula Matricula, a.id_tipo_servicio,
		   ts.tipo_servicio 'Tipo de servicio', a.fecha_de_alta 'Fecha de alta', a.capacidad_peso_encomiendas 'Capacidad peso encomiendas',
		    a.cantidad_butacas 'Butacas totales', a.baja_vida_utill 'Baja vida util', a.baja_por_fuera_de_servicio 'Baja por fuera de servicio'
	from ÑUFLO.Aeronave a JOIN ÑUFLO.Fabricante f ON a.id_fabricante = f.id_fabricante
						  JOIN ÑUFLO.Modelo m ON a.id_modelo = m.id_modelo
						  JOIN ÑUFLO.TipoServicio ts ON a.id_tipo_servicio = ts.id_tipo_servicio 
	where a.matricula = @matricula
;
GO

/*Viaje*/
CREATE PROCEDURE ÑUFLO.ViajesDisponiblesPara
@ciudad_origen nvarchar(255),
@ciudad_destino nvarchar(255),
@fecha datetime
AS
	select v.id_viaje, a.matricula Matricula_aeronave, v.fecha_salida, v.fecha_llegada_estimada Fecha_Llegada_Estimada, ÑUFLO.CantidadButacasDisponibles(v.id_viaje) Cantidad_Butacas,
			ÑUFLO.PesoDisponible(v.id_viaje) Peso_Disponible, ts.tipo_servicio
		from ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad co, ÑUFLO.Ciudad cd, ÑUFLO.TipoServicio ts
		where r.id_ruta = v.id_ruta
			and r.id_ciudad_origen = co.id_ciudad
			and r.id_ciudad_destino = cd.id_ciudad
			and co.nombre = @ciudad_origen
			and cd.nombre = @ciudad_destino
			and convert(date, v.fecha_salida) = convert(date, @fecha)
			and v.id_aeronave = a.id_aeronave
			and ts.id_tipo_servicio = a.id_tipo_servicio
;
GO

CREATE PROCEDURE ÑUFLO.GenerarViaje
@fecha_salida datetime,
@fecha_llegada_estimada datetime,
@hoy datetime,
@matricula nvarchar(255),
@id_ruta int
AS
	DECLARE @id_aeronave int
	
	SET @id_aeronave = (select id_aeronave from ÑUFLO.Aeronave where matricula = @matricula)
	
	IF(@id_aeronave is null)
		THROW 60007, 'La matricula ingresada no pertenece a ninguna Aeronave', 1
		
	IF(@id_ruta NOT IN (select id_ruta from ÑUFLO.RutaAerea))
		THROW 60012, 'La ruta ingresada no existe', 1
	
	IF(@fecha_llegada_estimada < @fecha_salida)
		THROW 60013, 'La fecha de llegada no puede ser menor a la de salida', 1
		
	IF(@fecha_salida < @hoy)
		THROW 60014, 'La fecha de salida debe ser mayor a la fecha de hoy', 1
		
	IF ((select id_tipo_servicio from ÑUFLO.ServicioPorRuta where id_ruta = @id_ruta) <> (select id_tipo_servicio from ÑUFLO.Aeronave where id_aeronave = @id_aeronave))
		THROW 600015, 'El servicio brindado por la aeronave no coincide con el de la ruta', 1
		
	IF(EXISTS (select * from ÑUFLO.ViajesDeAeronaveEntre(@id_aeronave, @fecha_salida, @fecha_llegada_estimada)))
		THROW 60016, 'La aeronave ya posee un viaje en esas fechas', 1
	
	INSERT INTO ÑUFLO.Viaje (id_aeronave, id_ruta, peso_ocupado, fecha_salida, fecha_llegada_estimada)
		VALUES (@id_aeronave, @id_ruta, 0, @fecha_salida, @fecha_llegada_estimada)	
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
					 ÑUFLO.Compra c, ÑUFLO.Pasaje p
				where @id_viaje = v.id_viaje
					and v.id_aeronave = b.id_aeronave
					and v.id_viaje = c.id_viaje
					and c.codigo_de_compra = p.codigo_de_compra
					and p.numero_de_butaca = b.numero_de_butaca
					and p.cancelado = 0) b
		where b.id_tipo_butaca = tb.id_tipo_butaca
;
GO

CREATE PROCEDURE ÑUFLO.CargarMillasDe
@id_viaje int,
@fecha_obtencion datetime
AS
	DECLARE @id_cliente int, @id_pasaje int, @cantidad int

	DECLARE CClientes CURSOR 
		FOR (select p.id_cliente, p.id_pasaje, convert(integer, p.precio/10)
				from ÑUFLO.Pasaje p, ÑUFLO.Compra c
				where @id_viaje = c.id_viaje
					and p.codigo_de_compra = c.codigo_de_compra
			UNION ALL
			select e.id_cliente, e.id_encomienda, convert(integer, e.precio/10)
				from ÑUFLO.Encomienda e, ÑUFLO.Compra c
				where @id_viaje = c.id_viaje
					and e.codigo_de_compra = c.codigo_de_compra)

	OPEN CClientes
	FETCH CCLientes INTO @id_cliente, @id_pasaje, @cantidad

	WHILE(@@FETCH_STATUS = 0)
		BEGIN
		
		INSERT INTO ÑUFLO.Milla(id_cliente, fecha_de_obtencion, cantidad, cantidad_gastada, expirado)
			values(@id_cliente, @fecha_obtencion, @cantidad, 0, 0)

		FETCH CCLientes INTO @id_cliente, @id_pasaje, @cantidad
		END

	CLOSE CClientes
	DEALLOCATE CClientes
;
GO

CREATE PROCEDURE ÑUFLO.RegistrarLlegada 
@matricula nvarchar(255),
@origen nvarchar (255),
@destino nvarchar (255),
@fecha_llegada datetime
AS 
	DECLARE @id_viaje int
	SET @id_viaje = (select top 1 id_viaje
					from ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad c
					where a.matricula = @matricula
						and v.id_aeronave = a.id_aeronave
						and r.id_ruta = v.id_ruta
						and r.id_ciudad_origen = c.id_ciudad
						and c.nombre = @origen
						and v.fecha_llegada is null
						and v.fecha_salida < @fecha_llegada
					order by v.fecha_salida)

	IF(@id_viaje is null)
		THROW 60019, 'Ningun viaje no registrado coincide con los datos ingresados', 1

	UPDATE ÑUFLO.Viaje
		SET fecha_llegada = @fecha_llegada
		where id_viaje = @id_viaje

	EXEC ÑUFLO.CargarMillasDe @id_viaje, @fecha_llegada
	
	IF(@destino <> (select nombre
						from ÑUFLO.Ciudad c, ÑUFLO.Viaje v, ÑUFLO.RutaAerea r
						where v.id_viaje = @id_viaje
							and r.id_ruta = v.id_ruta
							and c.id_ciudad = r.id_ciudad_destino))
		THROW 60021, 'La Aeronave no arribo al destino esperado', 1

;
GO

CREATE PROCEDURE ÑUFLO.ValidarDestinoLlegada 
@matricula nvarchar(255),
@origen nvarchar(255),
@destino nvarchar(255),
@fecha_llegada datetime
AS 
	DECLARE @id_viaje int
	SET @id_viaje = (select top 1 id_viaje
					from ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad c
					where a.matricula = @matricula
						and v.id_aeronave = a.id_aeronave
						and r.id_ruta = v.id_ruta
						and r.id_ciudad_origen = c.id_ciudad
						and c.nombre = @origen
						and v.fecha_llegada is null
						and v.fecha_salida < @fecha_llegada
					order by v.fecha_salida)

	IF(@destino <> (select nombre
						from ÑUFLO.Ciudad c, ÑUFLO.Viaje v, ÑUFLO.RutaAerea r
						where v.id_viaje = @id_viaje
							and r.id_ruta = v.id_ruta
							and c.id_ciudad = r.id_ciudad_destino))
		THROW 60021, 'La Aeronave no arribo al destino esperado', 1
;
GO

/*Compra*/
CREATE PROCEDURE ÑUFLO.CrearCompra 
@id_viaje int,
@dni int,
@hoy datetime
AS
	IF(NOT EXISTS (select id_viaje from ÑUFLO.Viaje where id_viaje = @id_viaje))
		THROW 60031, 'El viaje indicado no existe', 1

	IF(NOT EXISTS (select dni from ÑUFLO.Cliente where dni = @dni))
		THROW 60032, 'El cliente indicado no existe', 1

	INSERT INTO ÑUFLO.Compra(id_viaje, id_cliente, fecha_de_compra)
		values(@id_viaje, (select top 1 id_cliente from ÑUFLO.Cliente where dni = @dni), @hoy)

	SELECT top 1 codigo_de_compra FROM ÑUFLO.Compra 
		where id_viaje = @id_viaje and id_cliente = (select top 1 id_cliente from ÑUFLO.Cliente where dni = @dni)
			and fecha_de_compra = @hoy
;
GO

CREATE PROCEDURE ÑUFLO.ClienteNoEstaEnVuelo
@dni numeric(18,0),
@fecha_vuelo datetime,
@fecha_estimada datetime
AS
	IF(@dni IN (select cli.dni
					from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.Pasaje p, ÑUFLO.Cliente cli
					where (v.fecha_salida between @fecha_vuelo and @fecha_estimada
						or v.fecha_llegada_estimada between @fecha_vuelo and @fecha_estimada)
						and v.id_viaje = c.id_viaje
						and c.codigo_de_compra = p.codigo_de_compra
						and p.id_cliente = cli.id_cliente))
		THROW 60034, 'El pasajero se encuentra volando en esas fechas', 1
;
GO

CREATE PROCEDURE ÑUFLO.CrearPasaje
@codigo_compra int,
@dni int,
@numero_butaca int
AS

	IF(NOT EXISTS (select codigo_de_compra from ÑUFLO.Compra where codigo_de_compra = @codigo_compra))
		THROW 60033, 'La compra indicada no existe', 1
	
	
	IF(NOT EXISTS (select dni from ÑUFLO.Cliente where dni = @dni))
		THROW 60032, 'El cliente indicado no existe', 1
		
	IF(@numero_butaca IN (select numero_de_butaca from ÑUFLO.Pasaje where codigo_de_compra = @codigo_compra))
		THROW 60033, 'La butaca seleccionada no esta disponible', 1
		
	IF(@numero_butaca IN (select numero_de_butaca from ÑUFLO.Pasaje where codigo_de_compra = @codigo_compra))
		THROW 60033, 'La butaca seleccionada no esta disponible', 1

	DECLARE @precio numeric(18,2)

	SET @precio = (select r.precio_base_por_pasaje * ts.porcentaje_recargo
						from ÑUFLO.Compra c, ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.TipoServicio ts, ÑUFLO.RutaAerea r
						where c.codigo_de_compra = @codigo_compra
							and c.id_viaje = v.id_viaje 
							and v.id_ruta = r.id_ruta
							and v.id_aeronave = a.id_aeronave
							and a.id_tipo_servicio = ts.id_tipo_servicio)

	INSERT INTO ÑUFLO.Pasaje(id_pasaje, codigo_de_compra, id_cliente, numero_de_butaca, precio, cancelado)
		values((select ÑUFLO.SiguientePasaje()), @codigo_compra, (select top 1 id_cliente from ÑUFLO.Cliente where dni = @dni), @numero_butaca, @precio, 0)

;
GO

CREATE PROCEDURE ÑUFLO.PesoDisponibleDe
@id_viaje int
AS
	select ÑUFLO.PesoDisponible(@id_viaje)
;
GO

CREATE PROCEDURE ÑUFLO.CrearEncomienda
@codigo_compra int,
@dni int,
@peso_encomienda numeric(18,2)
AS
	IF(NOT EXISTS (select codigo_de_compra from ÑUFLO.Compra where codigo_de_compra = @codigo_compra))
		THROW 60033, 'La compra indicada no existe', 1
	
	
	IF(NOT EXISTS (select dni from ÑUFLO.Cliente where dni = @dni))
		THROW 60032, 'El cliente indicado no existe', 1

	DECLARE @id_viaje int
	SET @id_viaje = (select id_viaje from ÑUFLO.Compra where @codigo_compra = codigo_de_compra)
	
	IF(@peso_encomienda > (select ÑUFLO.PesoDisponible(@id_viaje)))
		THROW 60030, 'El peso de la encomienda supera el peso disponible del viaje', 1	

	DECLARE @precio numeric(18,2)

	SET @precio = (select r.precio_base_por_peso * ts.porcentaje_recargo
						from ÑUFLO.Compra c, ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.TipoServicio ts, ÑUFLO.RutaAerea r
						where c.codigo_de_compra = @codigo_compra
							and c.id_viaje = v.id_viaje 
							and v.id_ruta = r.id_ruta
							and v.id_aeronave = a.id_aeronave
							and a.id_tipo_servicio = ts.id_tipo_servicio)

	INSERT INTO ÑUFLO.Encomienda(id_encomienda, codigo_de_compra, id_cliente, peso_encomienda, precio, cancelado)
		values((select ÑUFLO.SiguienteEncomienda()), @codigo_compra, 
				(select top 1 id_cliente from ÑUFLO.Cliente where dni = @dni), @peso_encomienda, @precio, 0)

	UPDATE ÑUFLO.Viaje
		SET peso_ocupado = peso_ocupado + @peso_encomienda
		where id_viaje = @id_viaje
;
GO

CREATE PROCEDURE ÑUFLO.CancelarPasajeOEncomienda
@id int,
@tipo nvarchar(64),
@motivo nvarchar(255),
@hoy datetime
AS	
	DECLARE @pnr int, @msg nvarchar(255)
	
	IF (EXISTS(select * from ÑUFLO.Pasaje p 
				where p.id_pasaje = @id and
					  p.cancelado = 0)
		and @tipo = 'Pasaje')
	BEGIN
		IF(EXISTS(select id_pasaje
					from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.Pasaje p
					where p.id_pasaje = @id
						and v.fecha_llegada is not null
						and p.codigo_de_compra = c.codigo_de_compra
						and c.id_viaje = v.id_viaje))
		BEGIN
			SET @msg = 'El vuelo del pasaje ' + convert(nvarchar(255), @id) + ' ya fue realizado, no se pueden cancelar passajes de vuelos ya realizadas, porfavor vuelva a realizar la seleccion';
			THROW 60035, @msg, 1
		END
		set @pnr =(select p.codigo_de_compra from Pasaje p where p.id_pasaje = @id)
		if(NOT EXISTS(select * from ÑUFLO.Cancelacion can where can.codigo_de_compra = @pnr))
		BEGIN

			INSERT INTO ÑUFLO.Cancelacion(codigo_de_compra, fecha_devolucion)
				values(@pnr, @hoy)

		END
		
		INSERT INTO ÑUFLO.PasajePorCancelacion(id_cancelacion, id_pasaje, motivo_cancelacion)
			values((select MAX(id_cancelacion) from ÑUFLO.Cancelacion), @id, @motivo)
			
		UPDATE ÑUFLO.Pasaje
			SET cancelado = 1
			WHERE @id = id_pasaje
	END
	
	IF (EXISTS(select * from ÑUFLO.Encomienda e 
				where e.id_encomienda = @id and
					  e.cancelado = 0) 
     	and @tipo = 'Encomienda')
	BEGIN
		IF(EXISTS(select id_encomienda
					from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.Encomienda e
					where e.id_encomienda = @id
						and e.codigo_de_compra = c.codigo_de_compra
						and c.id_viaje = v.id_viaje))
			SET @msg = 'La encomienda ' + convert(nvarchar(255), @id) + ' ya fue realizada, no se pueden cancelar encomiendas ya realizadas, porfavor vuelva a realizar la seleccion';
			THROW 60035, @msg, 1
		
		set @pnr =(select e.codigo_de_compra from Encomienda e where e.id_encomienda = @id)
		if(NOT EXISTS(select * from ÑUFLO.Cancelacion can where can.codigo_de_compra = @pnr))
		BEGIN

				INSERT INTO ÑUFLO.Cancelacion(codigo_de_compra, fecha_devolucion)
					values(@pnr, @hoy)

		END
		
		INSERT INTO ÑUFLO.EncomiendaPorCancelacion(id_cancelacion, id_encomienda, motivo_cancelacion)
			values((select MAX(id_cancelacion) from ÑUFLO.Cancelacion), @id, @motivo)
			
		UPDATE ÑUFLO.Encomienda
			SET cancelado = 1
			WHERE @id = id_encomienda
	END
;
GO

/*Rol*/
CREATE PROCEDURE ÑUFLO.CrearRol
@nombre_rol nvarchar(255)
AS
	IF((SELECT nombre_rol FROM ÑUFLO.Rol WHERE nombre_rol = @nombre_rol) IS NOT NULL)
		THROW 60005, 'Ese rol ya existe', 1
		
	INSERT INTO ÑUFLO.Rol VALUES (@nombre_rol, 1)
;
GO	
		
CREATE PROCEDURE ÑUFLO.RolDadoNombre
@nombre nvarchar(255) = null
AS
	SELECT nombre_rol Nombre, habilitado 'Habilitado'
		FROM ÑUFLO.Rol
		WHERE @nombre is null OR nombre_rol LIKE @nombre + '%'
;
GO

CREATE PROCEDURE ÑUFLO.CambiarNombreDeRol
@nombre_old nvarchar(255),
@nombre nvarchar(255)
AS
	IF(@nombre NOT IN (select nombre_rol from ÑUFLO.Rol))
		Update ÑUFLO.ROL
			SET nombre_rol = @nombre
			where @nombre_old = nombre_rol
	ELSE
		THROW 60011, 'No Puede cambiar el nombre a un nombre de un rol ya existente', 1
;		
GO

CREATE PROCEDURE ÑUFLO.Inhabilitar_Habilitar
@nombre nvarchar(255)
AS
	UPDATE ÑUFLO.Rol SET habilitado = habilitado ^ 1 WHERE nombre_rol = @nombre
	
	IF ((SELECT habilitado FROM Rol WHERE nombre_rol = @nombre) = 0)
		DELETE ÑUFLO.RolPorUsuario
			where id_rol = (select id_rol from ÑUFLO.Rol where @nombre = nombre_rol)
	
	EXEC ÑUFLO.RolDadoNombre @nombre
;
GO

CREATE PROCEDURE ÑUFLO.TodasLasFuncionalidades
AS
	SELECT descripcion FROM ÑUFLO.Funcionalidad
;
GO

CREATE PROCEDURE ÑUFLO.FuncionalidadesDe
@nombre_rol nvarchar(255)
AS
	DECLARE @id_rol INT
	SET @id_rol = (select ÑUFLO.idRolDe(@nombre_rol))
	
	SELECT descripcion
		FROM ÑUFLO.Funcionalidad f 
			JOIN ÑUFLO.FuncionalidadPorRol fr ON (f.id_funcionalidad = fr.id_funcionalidad)
			JOIN ÑUFLO.Rol r ON (r.id_rol = fr.id_rol)
		WHERE r.id_rol = @id_rol
;
GO

CREATE PROCEDURE ÑUFLO.AsignarFuncionalidadARol
@nombre_rol nvarchar(255),
@descripcion nvarchar(255)
AS
	DECLARE @id_rol INT, @id_funcionalidad INT
	SET @id_rol = (select ÑUFLO.idRolDe(@nombre_rol))
	
	SELECT @id_funcionalidad = id_funcionalidad 
		FROM ÑUFLO.Funcionalidad
		WHERE descripcion = @descripcion
	
	INSERT INTO ÑUFLO.FuncionalidadPorRol VALUES (@id_rol, @id_funcionalidad)
;
GO

CREATE PROCEDURE ÑUFLO.BorrarFuncionalidadesDe
@nombre_rol nvarchar(255)
AS
	DECLARE @id_rol INT, @id_funcionalidad INT
	SET @id_rol = (select ÑUFLO.idRolDe(@nombre_rol))
	
	DELETE FROM ÑUFLO.FuncionalidadPorRol
		WHERE id_rol = @id_rol
;
GO


/*Ciudad*/
CREATE PROCEDURE ÑUFLO.DestinoOrigen
AS
	select id_ciudad_origen "Id ciudad origen", id_ciudad_destino "Id ciudad destino"
		from ÑUFLO.RutaAerea

	select id_ciudad "Id ciudad", nombre "Nombre"
		from ÑUFLO.Ciudad
;
GO

CREATE PROCEDURE ÑUFLO.TodasLasCiudades
AS
	SELECT nombre FROM ÑUFLO.Ciudad
;
GO

CREATE PROCEDURE ÑUFLO.IdCiudadDadoNombre
@nombre nvarchar(255),
@id INT OUTPUT
AS
	SELECT @id = id_ciudad FROM Ciudad WHERE nombre = @nombre
;
RETURN
GO

/*Tipo Servicio*/
CREATE PROCEDURE ÑUFLO.TiposDeServicio
AS
	SELECT tipo_servicio "Tipo Servicio" FROM ÑUFLO.TipoServicio
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

CREATE PROCEDURE ÑUFLO.IdTipoServicioDadoServicio
@servicio nvarchar(255),
@id INT OUTPUT
AS
	SELECT @id = id_tipo_servicio FROM TipoServicio WHERE tipo_servicio = @servicio
;
RETURN
GO

/*Ruta Aerea*/
CREATE PROCEDURE ÑUFLO.FiltrosAltaRutaAerea
@nombre_origen nvarchar(255) = NULL,
@nombre_destino nvarchar(255) = NULL,
@tipo_servicio nvarchar(255) = NULL
AS
	DECLARE @id_ciudad_origen int, @id_ciudad_destino int, @id_tipo_servicio int
	EXEC ÑUFLO.IdCiudadDadoNombre @nombre_origen, @id = @id_ciudad_origen OUTPUT;
	EXEC ÑUFLO.IdCiudadDadoNombre @nombre_destino, @id = @id_ciudad_destino OUTPUT;
	EXEC ÑUFLO.IdTipoServicioDadoServicio @tipo_servicio, @id = @id_tipo_servicio OUTPUT;

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
			  (@id_tipo_servicio IS NULL OR ra.id_ruta = sr.id_ruta ) AND
			  ra.cancelado = 0
;  
GO


CREATE PROCEDURE ÑUFLO.FiltrosModificacionRutaAerea
@id_ciudad_origen int = NULL,
@id_ciudad_destino int = NULL,
@id_tipo_servicio int = NULL
AS
	SELECT ra.id_ruta "id ruta", ra.codigo_ruta "Codigo de ruta", ra.id_ciudad_origen "id origen", c1.nombre "Ciudad origen", 
	ra.id_ciudad_destino "id destino", c2.nombre "Ciudad destino", ra.precio_base_por_peso "Precio base por peso", 
	ra.precio_base_por_pasaje "Precio base por pasaje",
		   ts.id_tipo_servicio "id servicio", ts.tipo_servicio "Tipo de servicio"	
		FROM ÑUFLO.RutaAerea ra JOIN ÑUFLO.Ciudad c1			ON ra.id_ciudad_origen = c1.id_ciudad
								JOIN ÑUFLO.Ciudad c2			ON ra.id_ciudad_destino = c2.id_ciudad
								JOIN ÑUFLO.ServicioPorRuta sr	ON ra.id_ruta = sr.id_ruta
								JOIN ÑUFLO.TipoServicio ts		ON sr.id_tipo_servicio  = ts.id_tipo_servicio

		WHERE (@id_ciudad_origen IS NULL OR ra.id_ciudad_origen = @id_ciudad_origen) AND
			  (@id_ciudad_destino IS NULL OR  ra.id_ciudad_destino = @id_ciudad_destino) AND
			  (@id_tipo_servicio IS NULL OR sr.id_tipo_servicio = @id_tipo_servicio ) AND
			  (@id_tipo_servicio IS NULL OR ra.id_ruta = sr.id_ruta) AND
			  ra.cancelado = 0
;  
GO

CREATE PROCEDURE ÑUFLO.InsertRutaAerea
@codigo_ruta numeric (18, 0),
@id_ciudad_origen int,
@id_ciudad_destino int,
@precio_base_por_peso  numeric (18, 0),
@precio_base_por_pasaje  numeric (18, 0)
AS
	INSERT INTO ÑUFLO.RutaAerea (codigo_ruta, id_ciudad_origen, id_ciudad_destino, precio_base_por_peso, precio_base_por_pasaje)
		VALUES (@codigo_ruta, @id_ciudad_origen, @id_ciudad_destino, @precio_base_por_peso, @precio_base_por_pasaje)
;  
GO

CREATE PROCEDURE ÑUFLO.CancelarRutaAerea
@id_ruta int,
@hoy datetime
AS

	DECLARE @id int
	DECLARE @Tipo nvarchar(64)

	DECLARE CRutaAerea CURSOR 
		FOR (select p.id_pasaje id, 'Pasaje' as tipo
				from ÑUFLO.Compra c, ÑUFLO.Pasaje p
				where c.id_viaje = @id_ruta
					and c.codigo_de_compra = p.codigo_de_compra
			 UNION
			 select e.id_encomienda id, 'Encomienda' as tipo
				from ÑUFLO.Compra c, ÑUFLO.Encomienda e
				where c.id_viaje = @id_ruta
					and c.codigo_de_compra = e.codigo_de_compra)

	

	OPEN CRutaAerea
	FETCH CRutaAerea INTO @id, @tipo

	WHILE (@@FETCH_STATUS = 0)
	BEGIN	

	exec ÑUFLO.CancelarPasajeOEncomienda  @id, @tipo, 'Baja Ruta Aerea', @hoy

		FETCH CRutaAerea INTO @id, @tipo
	END

	CLOSE CRutaAerea
	DEALLOCATE CRutaAerea
;
GO

CREATE PROCEDURE ÑUFLO.DeleteRutaAerea
@id_ruta int,
@hoy datetime
AS
	if(0 = (select cancelado from ÑUFLO.RutaAerea 
			WHERE id_ruta=@id_ruta))
		BEGIN
		UPDATE ÑUFLO.RutaAerea
			set cancelado = 1
		WHERE id_ruta=@id_ruta;
		END
	
	EXEC ÑUFLO.CancelarRutaAerea @id_ruta, @hoy
;  
GO


CREATE PROCEDURE ÑUFLO.UpdateRutaAerea
@id_ruta int,
@codigo_ruta numeric (18, 0),
@id_ciudad_origen int,
@id_ciudad_destino int,
@precio_base_por_peso  numeric (18, 0),
@precio_base_por_pasaje  numeric (18, 0)
AS
	UPDATE ÑUFLO.RutaAerea
	SET codigo_ruta = @codigo_ruta, id_ciudad_origen = @id_ciudad_origen, id_ciudad_destino = @id_ciudad_destino,
		precio_base_por_peso = @precio_base_por_peso, precio_base_por_pasaje = @precio_base_por_pasaje
	WHERE id_ruta = @id_ruta
;  
GO

/*Compra*/
CREATE PROCEDURE ÑUFLO.PasajesYEncomiendasDe
@codigo_compra int
AS
	select p.id_pasaje Codigo, 'Pasaje' Tipo, c.dni DNI, c.nombre Nombre, c.apellido Apellido,
		 '-' 'Peso de encomienda', cast(p.numero_de_butaca AS nvarchar(255)) 'Número de butaca', p.precio Precio
		from ÑUFLO.Pasaje p, ÑUFLO.Cliente c
		where p.id_cliente = c.id_cliente and
			  p.codigo_de_compra = @codigo_compra
	UNION
	select p.id_encomienda, 'Encomienda', c.dni, c.nombre, c.apellido, cast(p.peso_encomienda AS nvarchar(255)) 'Peso de encomienda', '-' 'Número de butaca', p.precio
		from ÑUFLO.Encomienda p, ÑUFLO.Cliente c
		where p.id_cliente = c.id_cliente and
			  p.codigo_de_compra = @codigo_compra
;
GO

CREATE PROCEDURE ÑUFLO.PasajesYEncomiendasNoCanceladosDe
@codigo_compra int
AS
	select p.id_pasaje Codigo, 'Pasaje' Tipo, c.dni DNI, c.nombre Nombre, c.apellido Apellido,
		 '-' 'Peso de encomienda', cast(p.numero_de_butaca AS nvarchar(255)) 'Número de butaca', p.precio Precio
		from ÑUFLO.Pasaje p, ÑUFLO.Cliente c
		where p.id_cliente = c.id_cliente and
			  p.codigo_de_compra = @codigo_compra and
			  p.cancelado = 0
	UNION
	select p.id_encomienda, 'Encomienda', c.dni, c.nombre, c.apellido, cast(p.peso_encomienda AS nvarchar(255)) 'Peso de encomienda', '-' 'Número de butaca', p.precio
		from ÑUFLO.Encomienda p, ÑUFLO.Cliente c
		where p.id_cliente = c.id_cliente and
			  p.codigo_de_compra = @codigo_compra and
			   p.cancelado = 0
;
GO

CREATE PROCEDURE ÑUFLO.TarjetasDeCredito
AS
	select * from ÑUFLO.TarjetaDeCredito
;
GO

/*Detalles para listados*/
CREATE PROCEDURE ÑUFLO.DetallePasajePara
@id nvarchar(255),
@fecha_inicio nvarchar(255),
@fecha_fin nvarchar(255)
AS
	declare @ciudad nvarchar(255)
	set @ciudad = @id
	select Codigo_de_Compra, Fecha_De_Compra, Pasaje, Destino, DNI, Nombre, Apellido, Butaca_Numero, Precio
		from ÑUFLO.DetallePasajes
		where Fecha_de_Compra between @fecha_inicio and @fecha_fin
			and Destino = @ciudad
;
GO	

CREATE PROCEDURE ÑUFLO.DetalleMillasDe
@dni nvarchar(255),
@hoy datetime
AS
	EXEC ÑUFLO.ExpirarMillas @hoy
	select Tipo, Cantidad, Cantidad_Gastada, Fecha, Estado
		from ÑUFLO.DetalleMillas 
		where DNI = @dni
		order by Fecha
;
GO

CREATE PROCEDURE ÑUFLO.DetalleMillasPara
@id nvarchar(255),
@fecha_inicio datetime,
@fecha_fin datetime
AS
	declare @dni int
	set @dni = convert(int, @id)
	select Tipo, Cantidad, Fecha
		from ÑUFLO.DetalleMillas
		where Fecha between @fecha_inicio and @fecha_fin
			and DNI = @dni
		order by Fecha
;
GO

CREATE PROCEDURE ÑUFLO.DetalleCancelacionesPara
@id nvarchar(255),
@fecha_inicio datetime,
@fecha_fin datetime
AS
	declare @ciudad nvarchar(255)
	set @ciudad = @id
	select Pasaje, DNI, Nombre, Apellido, Butaca_Numero, Fecha_De_Compra, Fecha_Devolucion, Motivo
		from ÑUFLO.DetalleCancelaciones
		where Fecha_Devolucion between @fecha_inicio and @fecha_fin
			and @ciudad = Destino
;
GO

CREATE PROCEDURE ÑUFLO.DetalleServicioTecnicoPara
@id nvarchar(255),
@fecha_inicio datetime,
@fecha_fin datetime
AS
	declare @matricula nvarchar(255)
	set @matricula = @id
	select Matricula, Modelo, Fabricante, Capacidad_Peso, Fecha_Fuera_de_Servicio,
			case
				when (Fecha_Fuera_de_Servicio < @fecha_inicio and @fecha_fin < Fecha_Reinicio_De_Servicio) then DATEDIFF(DD, @fecha_inicio, @fecha_fin)
				when Fecha_Fuera_de_Servicio < @fecha_inicio then DATEDIFF(DD, @fecha_inicio, Fecha_Reinicio_De_Servicio)
				when @fecha_fin < Fecha_Reinicio_de_Servicio then DATEDIFF(DD, Fecha_Fuera_de_Servicio, @fecha_fin)
				else DATEDIFF(DD, Fecha_Fuera_de_Servicio, Fecha_Reinicio_de_Servicio) 
			end  Dias_Fuera_de_Servicio
		from ÑUFLO.DetalleServiciosTecnicos
		where (Fecha_Fuera_de_Servicio between @fecha_inicio and @fecha_fin) or
			  (Fecha_Fuera_de_Servicio < @fecha_inicio and Fecha_Reinicio_De_Servicio > @fecha_fin)
			and @matricula = Matricula
;
GO

TOP5DestinoPasajesComprados
/*Listados Estadisticos*/
CREATE PROCEDURE ÑUFLO.
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
	select top 5 c.nombre, (SUM(a.cantidad_butacas)-SUM(usados)) 'Butacas libres'
		from ÑUFLO.Viaje v, ÑUFLO.Aeronave a, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad c,
			(select v.id_viaje, COUNT(p.id_pasaje) usados
				from ÑUFLO.Viaje v, ÑUFLO.Compra c, ÑUFLO.Pasaje p
				where v.id_viaje = c.id_viaje
					and c.codigo_de_compra = p.codigo_de_compra
					and p.cancelado = 0
				group by v.id_viaje) bm
		where c.id_ciudad = r.id_ciudad_destino
			and r.id_ruta = v.id_ruta
			and v.id_aeronave = a.id_aeronave
			and v.id_viaje = bm.id_viaje
			and v.fecha_llegada between @fecha_inicio and @fecha_fin
		group by c.nombre
		order by 2 desc
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
	select top 5 ci.nombre Destino, COUNT(pc.id_pasaje) Cancelaciones
	from ÑUFLO.PasajePorCancelacion pc JOIN ÑUFLO.Cancelacion ca ON pc.id_cancelacion = ca.id_cancelacion
										JOIN ÑUFLO.Compra co ON ca.codigo_de_compra = co.codigo_de_compra
										JOIN ÑUFLO.Viaje v ON co.id_viaje = v.id_viaje
										JOIN ÑUFLO.RutaAerea ra ON v.id_ruta = ra.id_ruta
										JOIN ÑUFLO.Ciudad ci ON ra.id_ciudad_destino = ci.id_ciudad
	where ca.fecha_devolucion between @fecha_inicio and @fecha_fin
	group by ci.nombre 
	order by COUNT(pc.id_pasaje) desc 
	
;
GO


CREATE PROCEDURE ÑUFLO.TOP5DiasFueraDeServicio
@fecha_inicio datetime,
@fecha_fin datetime
AS
	select Matricula, Modelo, Fabricante, Capacidad_Peso, 
			SUM(case
					when (Fecha_Fuera_de_Servicio < @fecha_inicio and @fecha_fin < Fecha_Reinicio_De_Servicio) then DATEDIFF(DD, @fecha_inicio, @fecha_fin)
					when Fecha_Fuera_de_Servicio < @fecha_inicio then DATEDIFF(DD, @fecha_inicio, Fecha_Reinicio_De_Servicio)
					when @fecha_fin < Fecha_Reinicio_de_Servicio then DATEDIFF(DD, Fecha_Fuera_de_Servicio, @fecha_fin)
					else DATEDIFF(DD, Fecha_Fuera_de_Servicio, Fecha_Reinicio_de_Servicio) 
				end)  Dias_Fuera_de_Servicio
		from ÑUFLO.DetalleServiciosTecnicos
		where (Fecha_Fuera_de_Servicio between @fecha_inicio and @fecha_fin) or
			  (Fecha_Fuera_de_Servicio < @fecha_inicio and Fecha_Reinicio_De_Servicio > @fecha_fin)
		group by Matricula, Modelo, Fabricante, Capacidad_Peso
		order by 5;
GO

/*****************************************************************/
/*************************** Function ****************************/
/*****************************************************************/

/*Milla*/
CREATE FUNCTION ÑUFLO.TotalMillasDe(@dni numeric(18,0))
RETURNS numeric(18,0)
AS
BEGIN
	DECLARE @total numeric(18,0)
	select @total = SUM(Cantidad - Cantidad_Gastada)
		from ÑUFLO.DetalleMillas
		where Estado = 'Vigentes'
			and DNI = @dni
	RETURN @total
END
GO

/*Rol*/
CREATE FUNCTION ÑUFLO.IdRolDe(@nombre_rol nvarchar(255))
RETURNS int
AS
BEGIN
	DECLARE @id_rol int
	SELECT @id_rol = id_rol 
		FROM Rol 
		WHERE nombre_rol = @nombre_rol
RETURN @id_rol
END
GO

/*Viaje*/
CREATE FUNCTION ÑUFLO.ViajesDeAeronaveEntre(@id_aeronave int, @salida datetime, @llegada datetime)
RETURNS @Viajes TABLE (id_viaje int)
AS
BEGIN
	INSERT INTO @Viajes
		select id_viaje viajes
			from ÑUFLO.Viaje v
			where @id_aeronave = v.id_aeronave
				and (v.fecha_salida between @salida and @llegada
				or v.fecha_llegada_estimada between @salida and @llegada)
RETURN
END
GO

CREATE FUNCTION ÑUFLO.PesoDisponible(@Id_viaje int)
RETURNS numeric(18,0)
AS
BEGIN
	DECLARE @peso_disponible numeric(18,0)
	
	SET @peso_disponible = (select (a.capacidad_peso_encomiendas - v.peso_ocupado) Peso_Disponible
								from ÑUFLO.Aeronave a, ÑUFLO.Viaje v
								where @Id_viaje = v.id_viaje
									and v.id_aeronave = a.id_aeronave)
	
	RETURN @peso_disponible
END
GO
--drop FUNCTION ÑUFLO.CantidadButacasDisponibles
--go
CREATE FUNCTION ÑUFLO.CantidadButacasDisponibles(@id_viaje int)
RETURNS int
AS
BEGIN
	DECLARE @total int, @ocupadas int, @disponibles int

	SET @total = (select a.cantidad_butacas
					from ÑUFLO.Viaje v join ÑUFLO.Aeronave a on v.id_aeronave = a.id_aeronave
					where v.id_viaje = @id_viaje)

				--	where @id_viaje = v.id_viaje
					--	and v.id_aeronave = b.id_aeronave)

	SET @ocupadas = (select COUNT(numero_de_butaca)
						from ÑUFLO.Viaje v, ÑUFLO.Pasaje p, ÑUFLO.Compra c
						where @id_viaje = v.id_viaje
							and v.id_viaje = c.id_viaje
							and c.codigo_de_compra = p.codigo_de_compra)

	SET @disponibles = @total - @ocupadas

	RETURN @disponibles
END
GO

CREATE FUNCTION ÑUFLO.FCantidadButacasOcupadas(@id_viaje int)
RETURNS int
AS
BEGIN
	DECLARE @ocupadas int

	SET @ocupadas = (select COUNT(numero_de_butaca)
						from ÑUFLO.Pasaje p, ÑUFLO.Compra c
						where @id_viaje = c.id_viaje
							and c.codigo_de_compra = p.codigo_de_compra
							and p.cancelado = 0)

	RETURN @ocupadas
END
GO

CREATE FUNCTION ÑUFLO.SiguientePasaje()
RETURNS int
AS
BEGIN
	DECLARE @siguiente int
	SET @siguiente = (select MAX(id_pasaje)+1 from ÑUFLO.Pasaje)
	RETURN @siguiente
END
GO

CREATE FUNCTION ÑUFLO.SiguienteEncomienda()
RETURNS int
AS
BEGIN
	DECLARE @siguiente int
	SET @siguiente = (select MAX(id_encomienda)+1 from ÑUFLO.Encomienda)
	RETURN @siguiente
END
GO
/*****************************************************************/
/*************************** Triggers ****************************/
/*****************************************************************/

CREATE TRIGGER ÑUFLO.DisminiurCantidadesPorCanje
ON ÑUFLO.Canje FOR INSERT
AS
BEGIN
	DECLARE @id_milla int, @id_cliente int, @fecha datetime, @cantidad int, @cantidad_gastada int, @gasto int

	UPDATE ÑUFLO.Producto
		SET stock = stock - (select i.cantidad from inserted i)
		where id_Producto = (select i.id_Producto from inserted i)

	SET @gasto = (select (i.cantidad * p.millas_necesarias)
								from inserted i, ÑUFLO.Producto p
								where p.id_Producto = i.id_Producto)
	
	DECLARE CMillas CURSOR 
		FOR select id_milla, id_cliente , fecha_de_obtencion, cantidad, cantidad_gastada
				from ÑUFLO.Milla
				where expirado = 0
					and (cantidad - cantidad_gastada) > 0
					and id_cliente = (select i.id_cliente from inserted i)
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
			BREAK;
			END

		FETCH CMillas INTO @id_milla, @id_cliente, @fecha, @cantidad, @cantidad_gastada
	END

	CLOSE CMillas
	DEALLOCATE CMillas
END
GO

CREATE TRIGGER ÑUFLO.NoAsignarRolesInhabilitados
ON ÑUFLO.RolPorUsuario INSTEAD OF INSERT
AS
BEGIN
	IF((select habilitado from ÑUFLO.Rol r, inserted i where i.id_rol = r.id_rol) = 0)
		THROW 60010, 'No se puede asignar un rol inhabilitado', 1
	
	INSERT INTO ÑUFLO.RolPorUsuario
		select * from inserted
END
GO

/*****************************************************************/
/**************************** Views ******************************/
/*****************************************************************/

CREATE VIEW ÑUFLO.DetallePasajes
AS
	select co.codigo_de_compra Codigo_de_Compra, co.fecha_de_compra Fecha_De_Compra, id_pasaje Pasaje, ci.nombre Destino,
			DNI, c.nombre Nombre, apellido Apellido, numero_de_butaca Butaca_Numero, precio Precio
		from ÑUFLO.Cliente c , ÑUFLO.Pasaje p, ÑUFLO.Compra co, ÑUFLO.Viaje v, ÑUFLO.RutaAerea r, ÑUFLO.Ciudad ci
		where  v.id_viaje = co.id_viaje
			and v.id_ruta = r.id_ruta
			and r.id_ciudad_destino = ci.id_ciudad
			and co.codigo_de_compra = p.codigo_de_compra
			and c.id_cliente = p.id_cliente
GO

CREATE VIEW ÑUFLO.DetalleMillas
AS
	select id_milla, 'Obtencion' Tipo, fecha_de_obtencion Fecha, m.cantidad Cantidad, CAST(cantidad_gastada AS nvarchar(255)) Cantidad_Gastada, cli.dni DNI,
			case expirado
				when 0 then 'Vigentes'
				else 'Expiradas'
			end Estado
		from ÑUFLO.Milla m, ÑUFLO.Cliente cli
		where m.id_cliente = cli.id_cliente
	UNION
	select id_canje, 'Canje' Tipo, fecha_de_canje, -(c.cantidad * p.millas_necesarias), '-', cli.DNI, '-'
		from ÑUFLO.Canje c, ÑUFLO.Cliente cli, ÑUFLO.Producto p
		where c.id_cliente = cli.id_cliente
			and c.id_Producto = p.id_Producto
GO

CREATE VIEW ÑUFLO.DetalleCancelaciones
AS
	select pc.id_pasaje_encomienda Pasaje, p.dni DNI, p.Nombre, p.apellido Apellido, p.Butaca_Numero , 
			c.fecha_devolucion Fecha_Devolucion, pc.motivo_cancelacion Motivo, p.Fecha_De_Compra, p.Destino
		from ÑUFLO.DetallePasajes p,
			ÑUFLO.Cancelacion c,
			(select ppc.id_cancelacion, ppc.id_pasaje id_pasaje_encomienda, ppc.motivo_cancelacion
			from ÑUFLO.PasajePorCancelacion ppc
			union
			select  epc.id_cancelacion, epc.id_encomienda id_pasaje_encomienda, epc.motivo_cancelacion
			from ÑUFLO.EncomiendaPorCancelacion epc) pc
		where p.pasaje = pc.id_pasaje_encomienda
			and p.Codigo_de_Compra = c.codigo_de_compra
GO

CREATE VIEW ÑUFLO.DetalleServiciosTecnicos
AS
	select a.matricula Matricula, m.nombre Modelo, f.nombre Fabricante, a.capacidad_peso_encomiendas Capacidad_Peso,
			st.fecha_fuera_de_servicio Fecha_Fuera_de_Servicio, st.fecha_reinicio_de_servicio Fecha_Reinicio_De_Servicio
		from ÑUFLO.Aeronave a, ÑUFLO.ServicioTecnico st, ÑUFLO.Modelo m, ÑUFLO.Fabricante f
		where st.id_aeronave = a.id_aeronave
			and a.id_modelo = m.id_modelo
			and a.id_fabricante = f.id_fabricante
GO


/*****************************************************************/
/*****************Sarlompeadas que hay que borrar*****************/
/*****************************************************************/
/*Bootstrap millas*/		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (1, 200,'2016-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (1, 30,'2017-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (1, 40,'2016-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (2, 20,'2017-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (2, 30,'2015-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (3, 150,'2015-12-01 01:00:00.000')		

INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (2, 200,'2016-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (3, 30,'2017-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (4, 40,'2016-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (1, 20,'2017-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (5, 30,'2015-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (6, 150,'2015-12-01 01:00:00.000')

INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (4, 200,'2016-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (3, 30,'2017-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (9, 40,'2016-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (8, 20,'2017-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (1, 30,'2015-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (7, 150,'2015-12-01 01:00:00.000')

INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (9, 200,'2016-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (8, 30,'2017-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (7, 40,'2016-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (6, 20,'2017-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (5, 30,'2015-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (4, 150,'2015-12-01 01:00:00.000')

INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (6, 200,'2016-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (9, 30,'2017-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (7, 40,'2016-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (5, 20,'2017-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (3, 30,'2015-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (1, 150,'2015-12-01 01:00:00.000')

INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (2, 200,'2016-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (4, 30,'2017-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (6, 40,'2016-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (8, 20,'2017-12-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (7, 30,'2015-02-01 01:00:00.000')		
INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (9, 150,'2015-12-01 01:00:00.000')

INSERT INTO ÑUFLO.Milla (id_cliente, cantidad, fecha_de_obtencion) VALUES (4, 300,'2016-02-01 01:00:00.000')

/*Bootstrap millas fin*/		
