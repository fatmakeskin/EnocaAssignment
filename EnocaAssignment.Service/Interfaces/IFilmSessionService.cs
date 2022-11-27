using EnocaAssignment.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Service.Interfaces
{
    public interface IFilmSessionService
    {
        void Add(AddSessionDto sessionDto);
        void Update(SessionDto sessionDto);
        void Delete(SessionDto sessionDto);
        SessionDto GetSession(int id);
        IEnumerable<SessionDto> GetAllSession();
    }
}
