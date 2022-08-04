using Business.Repositories.IsletimSistemiRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsletimSistemisController : ControllerBase
    {
        private readonly IIsletimSistemiService _ısletimSistemiService;

        public IsletimSistemisController(IIsletimSistemiService ısletimSistemiService)
        {
            _ısletimSistemiService = ısletimSistemiService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(IsletimSistemi ısletimSistemi)
        {
            var result = await _ısletimSistemiService.Add(ısletimSistemi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(IsletimSistemi ısletimSistemi)
        {
            var result = await _ısletimSistemiService.Update(ısletimSistemi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(IsletimSistemi ısletimSistemi)
        {
            var result = await _ısletimSistemiService.Delete(ısletimSistemi);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _ısletimSistemiService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ısletimSistemiService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
