using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Domain.Dto
{
    public class AddSessionDto
    {
        public DateTime FilmReleaseDate { get; set; }
        public DateTime FilmExpireDate { get; set; }

        public int FilmHallModelId { get; set; }
    }
}
