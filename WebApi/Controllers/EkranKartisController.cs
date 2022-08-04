using Business.Repositories.EkranKartiRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EkranKartisController : ControllerBase
    {
        private readonly IEkranKartiService _ekranKartiService;

        public EkranKartisController(IEkranKartiService ekranKartiService)
        {
            _ekranKartiService = ekranKartiService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(EkranKarti ekranKarti)
        {
            var result = await _ekranKartiService.Add(ekranKarti);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(EkranKarti ekranKarti)
        {
            var result = await _ekranKartiService.Update(ekranKarti);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(EkranKarti ekranKarti)
        {
            var result = await _ekranKartiService.Delete(ekranKarti);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _ekranKartiService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ekranKartiService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
