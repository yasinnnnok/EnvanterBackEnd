using Business.Repositories.VerilenRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerilensController : ControllerBase
    {
        private readonly IVerilenService _verilenService;

        public VerilensController(IVerilenService verilenService)
        {
            _verilenService = verilenService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(Verilen verilen)
        {
            var result = await _verilenService.Add(verilen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Verilen verilen)
        {
            var result = await _verilenService.Update(verilen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(Verilen verilen)
        {
            var result = await _verilenService.Delete(verilen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _verilenService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _verilenService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
