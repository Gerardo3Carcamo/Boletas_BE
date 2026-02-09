using Boletas_BE.Data;
using Boletas_BE.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Boletas_BE.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        private readonly BoletasDbContext _context;

        public UsuarioController(BoletasDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            try
            {
                var result = await _context.Usuario.ToListAsync();
                return Ok(new
                {
                    data = result,
                    message = "",
                    status = true
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Login(string usuario, string pass)
        {
            try
            {
                var user = await _context
                    .Usuario
                    .Where(x => x.Usuario == usuario && x.Password == pass)
                    .FirstOrDefaultAsync();
                if (user is null) return Unauthorized("User has not access");
                return Ok(new
                {
                    data = new
                    {
                        Nombre = user.Nombres + " " + user.Apellidos,
                        Rol = user.Rol,
                        Usuario = user.Usuario,
                        Id = user.Id
                    },
                    message = "",
                    status = true
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
