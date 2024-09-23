using Microsoft.AspNetCore.Mvc;
using SharedModels;
using WebApiPrueba.Business;

namespace WebApiPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VikingosController : ControllerBase
    {
        private readonly VikingoService _vikingoService;

        public VikingosController(VikingoService vikingoService)
        {
            _vikingoService = vikingoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viking>>> GetAll() =>
            Ok(await _vikingoService.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Viking vikingo)
        {
            await _vikingoService.AddAsync(vikingo);
            return CreatedAtAction(nameof(GetById), new { id = vikingo.Id }, vikingo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Viking vikingo)
        {
            if (id != vikingo.Id) return BadRequest();
            await _vikingoService.UpdateAsync(vikingo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _vikingoService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Viking>> GetById(int id)
        {
            var vikingo = await _vikingoService.GetByIdAsync(id);

            if (vikingo == null)
            {
                return NotFound();
            }

            return Ok(vikingo);
        }
    }
}
