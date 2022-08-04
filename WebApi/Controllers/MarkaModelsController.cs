using Business.Repositories.MarkaModelRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkaModelsController : ControllerBase
    {
        private readonly IMarkaModelService _markaModelService;

        public MarkaModelsController(IMarkaModelService markaModelService)
        {
            _markaModelService = markaModelService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(MarkaModel markaModel)
        {
            var result = await _markaModelService.Add(markaModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(MarkaModel markaModel)
        {
            var result = await _markaModelService.Update(markaModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(MarkaModel markaModel)
        {
            var result = await _markaModelService.Delete(markaModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _markaModelService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _markaModelService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
