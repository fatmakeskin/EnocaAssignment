using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssigment.Domain.Data
{
    public class FilmHallModel
    {
        public int Id { get; set; }
        public string HallName { get; set; }

        public List<FilmSessionModel> FilmSessionModels { get; set; }

        public int FilmModelId { get; set; }
        public FilmModel FilmModel { get; set; }
    }
}
