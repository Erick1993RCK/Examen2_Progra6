CREATE PROCEDURE [dbo].[ClienteListar]
AS
BEGIN 
	SET NOCOUNT ON

	SELECT 
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
		 
	FROM
	    dbo.Cliente

END