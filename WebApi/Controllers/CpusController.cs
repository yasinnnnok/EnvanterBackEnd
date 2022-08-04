using Business.Repositories.CpuRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CpusController : ControllerBase
    {
        private readonly ICpuService _cpuService;

        public CpusController(ICpuService cpuService)
        {
            _cpuService = cpuService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(Cpu cpu)
        {
            var result = await _cpuService.Add(cpu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Cpu cpu)
        {
            var result = await _cpuService.Update(cpu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(Cpu cpu)
        {
            var result = await _cpuService.Delete(cpu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _cpuService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _cpuService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
