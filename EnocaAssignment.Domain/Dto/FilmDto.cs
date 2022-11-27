using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Domain.Dto
{
    public class FilmDto
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public DateTime FilmReleaseDate { get; set; }
    }
}
