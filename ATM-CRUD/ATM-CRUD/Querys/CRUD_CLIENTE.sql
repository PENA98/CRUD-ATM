USE GenisysATM_V2
GO

CREATE PROCEDURE sp_crearCliente
(
	@nombre nvarchar(100),
	@apellido nvarchar(100),
	@identidad char(13),
	@direccion nvarchar(2000),
	@telefono char(9),
	@celular char(9)
)
AS
BEGIN
	INSERT INTO ATM.Cliente(nombres, apellidos, identidad, direccion, telefono, celular)
	VALUES (@nombre, @apellido, @identidad, @direccion, @telefono, @celular)
END
GO

CREATE PROCEDURE sp_listarCliente
(
	@identidad char(13)
)
AS
BEGIN
	SELECT * FROM ATM.Cliente WHERE identidad = @identidad
END
GO

CREATE PROCEDURE sp_actualizarCliente
(
	@nombre nvarchar(100),
	@apellido nvarchar(100),
	@identidad char(13),
	@direccion nvarchar(2000),
	@telefono char(9),
	@celular char(9)
)
AS
BEGIN
	UPDATE ATM.Cliente
	SET nombres = @nombre, apellidos = @apellido, direccion = @direccion, telefono = @telefono, celular = @celular
	WHERE identidad = @identidad
END
GO

CREATE PROCEDURE sp_eliminarCliente
(
	@identidad char(13)
)
AS
BEGIN
	DELETE FROM ATM.Cliente WHERE identidad = @identidad
END
GO
