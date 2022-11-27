using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Domain.Dto
{
    public class FilmHallDto
    {
        public int Id { get; set; }
        public string HallName { get; set; }

        public IEnumerable<SessionDto> FilmSessionModels { get; set; }
    }
}
