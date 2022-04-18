CREATE PROCEDURE [dbo].[SolicitudEliminar]
	@IdSolicitud INT
AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

   DELETE FROM dbo.Solicitud
   WHERE IdSolicitud = @IdSolicitud

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, 'La solicitud no pudo ser eliminada de la BD' AS MsgError

  END TRY

	  BEGIN CATCH
		SELECT 
			   ERROR_NUMBER() AS CodeError,
			   ERROR_MESSAGE() AS MsgError

	  ROLLBACK TRANSACTION TRASA
  
  END CATCH

  END 