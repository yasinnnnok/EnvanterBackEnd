using Business.Repositories.AnakartRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnakartsController : ControllerBase
    {
        private readonly IAnakartService _anakartService;

        public AnakartsController(IAnakartService anakartService)
        {
            _anakartService = anakartService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(Anakart anakart)
        {
            var result = await _anakartService.Add(anakart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Anakart anakart)
        {
            var result = await _anakartService.Update(anakart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(Anakart anakart)
        {
            var result = await _anakartService.Delete(anakart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _anakartService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _anakartService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
