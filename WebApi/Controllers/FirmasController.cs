using Business.Repositories.FirmaRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmasController : ControllerBase
    {
        private readonly IFirmaService _firmaService;

        public FirmasController(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(Firma firma)
        {
            var result = await _firmaService.Add(firma);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Firma firma)
        {
            var result = await _firmaService.Update(firma);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(Firma firma)
        {
            var result = await _firmaService.Delete(firma);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _firmaService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _firmaService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
