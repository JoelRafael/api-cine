using Microsoft.AspNetCore.Mvc;
using ApiCine.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiCine.Controllers

{
   [ApiController]
   [Route("[controller]")]
    public class AdministracionController : ControllerBase
    {

        private readonly appcontext _ctx;
        public AdministracionController(appcontext ctx)
        {
            this._ctx = ctx;
        }

        [HttpGet]
        [Route("GetActores")]
        public async Task<IActionResult> GetActores()
        {
            var Actores = await _ctx.Actores.Include(x=>x.Peliculas).ToListAsync();
            //var Actores = await _ctx.Actores.ToListAsync();
            return Ok(new {Error=false, Message="", Data=Actores});
        }
        [HttpPost]
        [Route("PostActores")]
        public async Task<IActionResult> PostActores(Actor Json)
        {
            _ctx.Actores.Add(Json);
            var Save = await _ctx.SaveChangesAsync();
            if (Save==0)
            {
                return StatusCode(500, new {Error=true, Message="Hubo un problema en el servidor", Data="" });
            }
            return StatusCode(201, new { Error = false, Message = "Actor registrado con exito", Data = "" });
        }
        [HttpPost]
        [Route("PostPeliculas")]
        public async Task<IActionResult> PostPeliculas(Pelicula Json)
        {
            _ctx.Peliculas.Add(Json);
            var Save = await _ctx.SaveChangesAsync();
            if (Save == 0)
            {
                return StatusCode(500, new { Error = true, Message = "Hubo un problema en el servidor", Data = "" });
            }
            return StatusCode(201, new { Error = false, Message = "Pelicula registrado con exito", Data = "" });
        }
        [HttpGet]
        [Route("GetPeliculas")]
        public async Task<IActionResult> GetPeliculas()
        {
            var Peliculas = await _ctx.Peliculas.Include(x => x.Actors).ToListAsync();
            return Ok(new { Error = false, Message = "", Data = Peliculas });
        }
    }
}
