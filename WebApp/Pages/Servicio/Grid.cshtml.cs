using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Servicio
{
    public class GridModel : PageModel
    {
        
            private readonly IServicioService servicioService;

            public GridModel(IServicioService servicioService)
            {
                this.servicioService = servicioService;
            }

            public IEnumerable<ServicioEntity> GridList { get; set; } = new List<ServicioEntity>();


            public async Task<IActionResult> OnGet()
            {
                try
                {
                    GridList = await servicioService.Get();


                    return Page();


                }
                catch (Exception ex)
                {

                    return Content(ex.Message);
                }
            }

            public async Task<JsonResult> OnDeleteEliminar(int id)
            {
                try
                {
                    var result = await servicioService.Delete(new()
                    {
                        IdServicio = id
                    });



                    return new JsonResult(result);
                }
                catch (Exception ex)
                {

                    return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
                }

            }
        }
    }

