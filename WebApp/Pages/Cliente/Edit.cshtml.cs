using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Cliente
{
    public class EditModel : PageModel
    {
        private readonly IClienteService cliente;

        public EditModel(IClienteService cliente)
        {
            this.cliente = cliente;
        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        [BindProperty]
        public ClienteEntity Entity { get; set; } = new ClienteEntity();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await cliente.GetById(new()
                    {
                        IdCliente = id
                    });
                }

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
                //Metodo de Actualización
                if (Entity.IdCliente.HasValue)
                {
                    var result = await cliente.Update(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "El registro se actualizó correctamente";

                }
                else
                {   //Metodo de Inserción
                    var result = await cliente.Create(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "El registro se agregró correctamente";
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

