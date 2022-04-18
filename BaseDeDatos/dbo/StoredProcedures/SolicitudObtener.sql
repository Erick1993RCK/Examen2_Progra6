CREATE PROCEDURE [dbo].[SolicitudObtener]
	@IdSolcitud INT
AS
BEGIN 
	SET NOCOUNT ON

	SELECT 
	       IdSolicitud,
		   IdCliente,
		   IdServicio,
		   Cantidad,
		   Monto,
		   FechaEntrega,
		   UsuarioEntrega,
		   Observaciones
	FROM
	    dbo.Solicitud
	WHERE
	    (@IdSolcitud IS NULL OR IdSolicitud=@IdSolcitud)
END
