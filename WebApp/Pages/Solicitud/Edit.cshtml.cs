using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Solicitud
{
    public class EditModel : PageModel
    {
        private readonly ISolicitudService solicitudService;
        private readonly IClienteService clienteService;
        private readonly IServicioService servicioService;

        public EditModel(ISolicitudService solicitudService, IClienteService clienteService, IServicioService servicioService)
        {
            this.solicitudService = solicitudService;
            this.clienteService = clienteService;
            this.servicioService = servicioService;
     

        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        [BindProperty]
        public SolicitudEntity Entity { get; set; } = new SolicitudEntity();


        public IEnumerable<ClienteEntity> ClienteLista { get; set; } = new List<ClienteEntity>();

        public IEnumerable<ServicioEntity> ServicioLista { get; set; } = new List<ServicioEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await solicitudService.GetById(new() { IdSolicitud = id });
                }

                ClienteLista = await clienteService.GetLista();
                ServicioLista = await servicioService.GetLista();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (Entity.IdSolicitud.HasValue)
                {
                    //Actualizar
                    var result = await solicitudService.Update(Entity);

                    if (result.CodeError != 0)
                    {
                        throw new Exception(result.MsgError);
                    }

                    TempData["Msg"] = "El registro ha sido actualizado";
                }
                else
                {
                    //Nuevo Registro
                    var result = await solicitudService.Create(Entity);

                    if (result.CodeError != 0)
                    {
                        throw new Exception(result.MsgError);
                    }

                    TempData["Msg"] = "El registro ha sido ingresado";

                }

                return RedirectToPage("Grid");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
