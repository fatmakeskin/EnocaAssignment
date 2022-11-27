using EnocaAssignment.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Service.Interfaces
{
    public interface IFilmService
    {
        void Add(AddFilmDto dto);
        void Update(FilmDto dto);
        void Delete(FilmDto dto);
        FilmDto GetMovie(int id);
        IEnumerable<FilmDto> GetAllMovie();
        public IEnumerable<GetSingleMovieDto> GetAllMovieByDto();
        public IEnumerable<GetSingleMovieDto> SearchMovie(SearchDto dto);
    }
}
