CREATE PROCEDURE [dbo].[ServicioEliminar]
	@IdServicio INT
AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

   DELETE FROM dbo.Servicio
   WHERE IdServicio = @IdServicio

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, 'No se pudo eliminar el servicio de la BD' AS MsgError

  END TRY

	  BEGIN CATCH
		SELECT 
			   ERROR_NUMBER() AS CodeError,
			   ERROR_MESSAGE() AS MsgError

	  ROLLBACK TRANSACTION TRASA
  
  END CATCH

  END 