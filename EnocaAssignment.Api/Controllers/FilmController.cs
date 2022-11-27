using EnocaAssignment.Domain.Dto;
using EnocaAssignment.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaAssignment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private IFilmService service;
        public FilmController(IFilmService _service)
        {
            service = _service;
        }

        [HttpGet(nameof(Get))]
        public ActionResult Get(int id)
        {
            return Ok(service.GetMovie(id));
        }

        [HttpGet(nameof(GetAll))]
        public ActionResult GetAll()
        {
            return Ok(service.GetAllMovie());
        }

        [HttpGet(nameof(GetMovieByDto))]
        public ActionResult GetMovieByDto()
        {

            return Ok(service.GetAllMovieByDto());
        }

        [HttpPost(nameof(Search))]
        public IActionResult Search(SearchDto model)
        {
            return Ok(service.SearchMovie(model));
        }

        [HttpPost(nameof(AddMovie))]
        public IActionResult AddMovie(AddFilmDto movieDto)
        {
            try
            {
                if (movieDto == null) return BadRequest();
                service.Add(movieDto);
                return Ok();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPut(nameof(UpdateMovie))]
        public IActionResult UpdateMovie(FilmDto filmDto)
        {
            try
            {
                if (filmDto == null) return BadRequest();
                service.Update(filmDto);
                return Ok();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete(nameof(DeleteMovie))]
        public IActionResult DeleteMovie(FilmDto filmDto)
        {
            try
            {
                if (filmDto == null) return BadRequest();
                service.Delete(filmDto);
                return Ok();

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
