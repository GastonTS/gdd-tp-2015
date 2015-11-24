USE [GD2C2015]
GO

IF (NOT EXISTS (SELECT * FROM sys.schemas WHERE name = '�UFLO')) 
BEGIN
    EXEC ('CREATE SCHEMA �UFLO')
END
GO

CREATE PROCEDURE �UFLO.NO_CHECK_CONSTRAINS
AS 
	DECLARE @sql varchar(max)
	DECLARE tables_in_schema CURSOR FOR 
	SELECT f.name, Object_NAME(f.parent_object_id)
	FROM sys.foreign_keys AS f JOIN
	sys.schemas AS s ON s.schema_id = f.schema_id
	WHERE s.name = '�UFLO'

	DECLARE @table_name varchar(max)
	DECLARE @fk_name varchar(max)

	OPEN tables_in_schema 

	FETCH tables_in_schema INTO  @fk_name, @table_name

	WHILE (@@FETCH_STATUS = 0) 
	BEGIN 
		SET @sql = 'ALTER TABLE �UFLO.' + @table_name + ' DROP CONSTRAINT ' + @fk_name
		EXEC(@sql)

		FETCH tables_in_schema INTO  @fk_name, @table_name
	END 

	CLOSE tables_in_schema 
	DEALLOCATE tables_in_schema 
GO

-- Creo el SP para limpiar la base
CREATE PROCEDURE [�UFLO].CleanDatabase
AS
	DECLARE @names_sp varchar(max)
	DECLARE @names_func varchar(max)
	DECLARE @names_veiws varchar(max)
	DECLARE @names_tables varchar(max)
	DECLARE @names_types varchar(max)
	DECLARE @names_triggers varchar(max)

	DECLARE @sql varchar(max)

	--Borro los triggers
	SELECT @names_triggers = coalesce(@names_triggers + ', ','') + '[�UFLO].' + t.NAME
	FROM GD2C2015.sys.objects t, GD2C2015.sys.schemas s
	WHERE s.schema_id = t.schema_id AND s.name = '�UFLO' AND  t.type = 'TR'
	
	SET @sql = 'DROP TRIGGER ' + @names_triggers
	EXEC(@sql)

	--Borro los stored procedures
	SELECT @names_sp = coalesce(@names_sp + ', ','') + '[�UFLO].' + p.NAME
	FROM GD2C2015.sys.procedures p, GD2C2015.sys.schemas s
	WHERE s.schema_id = p.schema_id AND p.NAME != 'CleanDatabase' AND p.NAME != 'NO_CHECK_CONSTRAINS' AND s.name = '�UFLO'
	
	SET @sql = 'DROP PROCEDURE ' + @names_sp
	EXEC(@sql)

	--Borro las functions
	SELECT @names_func = coalesce(@names_func + ', ','') + '[�UFLO].' + f.NAME
	FROM GD2C2015.sys.objects f, GD2C2015.sys.schemas s
	WHERE s.schema_id = f.schema_id AND s.name = '�UFLO' AND  f.type IN ('FN', 'IF', 'TF')
	
	SET @sql = 'DROP FUNCTION ' + @names_func
	EXEC(@sql)


	--Borro las vistas
	SELECT @names_veiws = coalesce(@names_veiws + ', ','') + '[�UFLO].' + TABLE_NAME
	FROM GD2C2015.INFORMATION_SCHEMA.VIEWS
	WHERE TABLE_SCHEMA = '�UFLO'

	SET @sql = 'DROP VIEW ' + @names_veiws
	EXEC(@sql)

	-- Deshabilito la integridad referencial de las tablas a borrar
	EXEC �UFLO.NO_CHECK_CONSTRAINS

	--Borro las tablas excepto la maestra
	SELECT @names_tables = coalesce(@names_tables + ', ','') + '[�UFLO].' + TABLE_NAME
	FROM GD2C2015.INFORMATION_SCHEMA.TABLES
	WHERE TABLE_SCHEMA = '�UFLO' and TABLE_TYPE = 'BASE TABLE'

	SET @sql = 'DROP TABLE ' + @names_tables
	EXEC(@sql)

	--Borro los User define types
	SELECT @names_types = coalesce( @names_types + ' DROP TYPE ','DROP TYPE ') + '[�UFLO].' + t.NAME
	FROM GD2C2015.sys.types t, GD2C2015.sys.schemas s
	WHERE s.schema_id = t.schema_id AND s.name = '�UFLO'

	SET @sql = @names_types
	EXEC(@sql)
GO

DECLARE @ok bit
SET @ok = 0
begin TRAN
	EXEC [�UFLO].CleanDatabase
	SET @ok = 1
COMMIT TRAN

DROP PROCEDURE [�UFLO].CleanDatabase
DROP PROCEDURE [�UFLO].NO_CHECK_CONSTRAINS	

IF @ok = 1 
DROP SCHEMA �UFLO
GO