using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Domain.Dto
{
    public class GetSingleMovieDto
    {
        public int Id { get; set; }
        public string FilmName { get; set; }

        public IEnumerable<FilmHallDto> FilmHallModels { get; set; }
    }
}
