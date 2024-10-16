using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.model.Request;
using WebApplication1.model.Response;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        [HttpPost]

        [Route("tareasFecha")]
        //controlador listo
        public Respuesta tareasPorFecha([FromBody] Tarea_fechas fechas)
        {
            Respuesta res = model.proc.p_Tarea.listaMenu(fechas);
            return res;
        }
    }
}
