using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssigment.Domain.Data
{
    public class FilmSessionModel
    {
        public int Id { get; set; }
        public DateTime FilmReleaseDate { get; set; }
        public DateTime FilmExpireDate { get; set; }

        public int FilmHallModelId { get; set; }
        public FilmHallModel FilmHallModel { get; set; }
    }
}
