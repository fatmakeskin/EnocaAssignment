using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssigment.Domain.Data
{
    public class FilmModel
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public DateTime FilmReleaseDate { get; set; }
        public List<FilmHallModel> FilmHallModels { get; set; }
    }
}
