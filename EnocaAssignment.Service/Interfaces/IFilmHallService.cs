using EnocaAssignment.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Service.Interfaces
{
    public interface IFilmHallService
    {
        void Add(AddFilmHallDto filmhallDto);
        void Update(FilmHallDto filmhallDto);
        void Delete(FilmHallDto filmhallDto);
        FilmHallDto GetSaloon(int id);
        IEnumerable<FilmHallDto> GetAllSaloon();
    }
}
