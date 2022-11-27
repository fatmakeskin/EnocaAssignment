using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Domain.Dto
{
    public class AddSingleMovieDto
    {
        public AddFilmDto MovieDto { get; set; }
        public AddFilmHallDto SalloonDto { get; set; }
        public AddSessionDto SessionDto { get; set; }
    }
}
