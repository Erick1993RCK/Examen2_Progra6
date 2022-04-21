CREATE PROCEDURE [dbo].[ClienteInsertar]
	@IdCliente INT,
	@Identificacion VARCHAR (128),
	@IdTipoIdentificacion INT,
	@Nombre VARCHAR (128),
	@PrimerApellido VARCHAR (128),
	@SegundoApellido VARCHAR (128),
	@FechaNacimiento DATETIME,
	@Nacionalidad INT,
	@FechaDefuncion DATETIME,
	@Genero CHAR (1),
	@NombreApellidosPadre VARCHAR (200),
	@NombreApellidosMadre VARCHAR (200),
	@Pasaporte VARCHAR (50),
	@CuentaIBAN VARCHAR (50),
	@CorreoNotifica VARCHAR (128)
AS
	BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

  INSERT INTO dbo.Cliente
  (
  	IdCliente,
	Identificacion,
	IdTipoIdentificacion,
	Nombre,
	PrimerApellido,
	SegundoApellido,
	FechaNacimiento,
	Nacionalidad,
	FechaDefuncion,
	Genero,
	NombreApellidosPadre,
	NombreApellidosMadre,
	Pasaporte,
	CuentaIBAN,
	CorreoNotifica
  )
  VALUES
  (
    @IdCliente,
	@Identificacion,
	@IdTipoIdentificacion,
	@Nombre,
	@PrimerApellido,
	@SegundoApellido,
	@FechaNacimiento,
	@Nacionalidad,
	@FechaDefuncion,
	@Genero,
	@NombreApellidosPadre,
	@NombreApellidosMadre,
	@Pasaporte,
	@CuentaIBAN,
	@CorreoNotifica 
  )

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, 'El cliente no pudo ser agregado a la BD' AS MsgError

  END TRY

	  BEGIN CATCH
		SELECT 
			   ERROR_NUMBER() AS CodeError,
			   ERROR_MESSAGE() AS MsgError

	  ROLLBACK TRANSACTION TRASA
  
  END CATCH

  END 

