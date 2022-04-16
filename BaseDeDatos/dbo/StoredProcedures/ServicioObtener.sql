CREATE PROCEDURE [dbo].[ServicioObtener]
	@IdServicio INT
AS
BEGIN 
	SET NOCOUNT ON

	SELECT 
	       IdServicio,
		   NombreServicio,
		   PlazoEntrega,
		   CostoServicio,
		   Estado,
		   CuentaContable
	FROM
	    dbo.Servicio
	WHERE
	    (@IdServicio IS NULL OR IdServicio=@IdServicio)
	      

END
