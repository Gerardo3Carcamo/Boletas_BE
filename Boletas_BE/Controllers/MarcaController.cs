using Boletas_BE.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Boletas_BE.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MarcaController : ControllerBase
    {
        private readonly BoletasDbContext _context;

        public MarcaController(BoletasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMarcas()
        {
            try
            {
                return Ok(new
                {
                    data = await _context
                        .Marcas
                        .ToListAsync(),
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
