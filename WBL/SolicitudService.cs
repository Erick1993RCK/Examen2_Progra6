using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ISolicitudService
    {
        Task<DBEntity> Create(SolicitudEntity entity);
        Task<DBEntity> Delete(SolicitudEntity entity);
        Task<IEnumerable<SolicitudEntity>> Get();
        Task<SolicitudEntity> GetById(SolicitudEntity entity);
        Task<IEnumerable<SolicitudEntity>> GetLista();
        Task<DBEntity> Update(SolicitudEntity entity);
    }

    public class SolicitudService : ISolicitudService
    {
        private readonly IDataAccess sql;

        public SolicitudService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        // Metodo GET
        public async Task<IEnumerable<SolicitudEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<SolicitudEntity, ServicioEntity, ClienteEntity>("dbo.SolicitudObtener", "IdSolicitud,IdServicio,IdCliente");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo GetById
        public async Task<SolicitudEntity> GetById(SolicitudEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<SolicitudEntity>("dbo.SolicitudObtener", new { entity.IdSolicitud });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create
        public async Task<DBEntity> Create(SolicitudEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.SolicitudInsertar", new
                {
                    entity.IdSolicitud,
                    entity.IdCliente,
                    entity.IdServicio,
                    entity.IdCantidad,
                    entity.Monto,
                    entity.FechaEntrega,
                    entity.UsuarioEntrega,
                    entity.Observaciones
                });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(SolicitudEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.SolicitudActualizar", new
                {
                    entity.IdSolicitud,
                    entity.IdCliente,
                    entity.IdServicio,
                    entity.IdCantidad,
                    entity.Monto,
                    entity.FechaEntrega,
                    entity.UsuarioEntrega,
                    entity.Observaciones
                });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete

        public async Task<DBEntity> Delete(SolicitudEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.SolicitudEliminar", new
                {
                    entity.IdSolicitud
                });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<SolicitudEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<SolicitudEntity>("dbo.SolicitudListar");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

    }
}
