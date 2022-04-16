CREATE PROCEDURE [dbo].[ServicioLista]
AS
BEGIN 
	SET NOCOUNT ON

	SELECT 
	       IdServicio,
		   NombreServicio
		 
	FROM
	    dbo.Servicio

END