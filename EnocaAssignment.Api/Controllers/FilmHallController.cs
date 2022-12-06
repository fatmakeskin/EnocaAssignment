using EnocaAssignment.Domain.Dto;
using EnocaAssignment.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaAssignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmHallController : ControllerBase
    {
        private IFilmHallService service;
        public FilmHallController(IFilmHallService _service)
        {
            service = _service;
        }

        [HttpGet(nameof(Get))]
        public IActionResult Get(int id)
        {
            return Ok(service.GetSaloon(id));
        }
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            return Ok(service.GetAllSaloon());
        }
        [HttpPost((nameof(Add)))]
        public IActionResult Add(AddFilmHallDto filmhallDto)
        {
            try
            {
                if (filmhallDto == null) return BadRequest();
                service.Add(filmhallDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPut(nameof(Update))]
        public IActionResult Update(FilmHallDto filmhallDto)
        {
            try
            {
                if (filmhallDto == null) return BadRequest();
                service.Update(filmhallDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(FilmHallDto filmhallDto)
        {
            try
            {
                if (filmhallDto != null) return BadRequest();
                service.Delete(filmhallDto);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
