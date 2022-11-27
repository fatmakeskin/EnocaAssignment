using AutoMapper;
using EnocaAssigment.Domain.Data;
using EnocaAssignment.Application.Repositories.Interfaces;
using EnocaAssignment.Domain.Dto;
using EnocaAssignment.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Service.services
{
    public class FilmSessionService:IFilmSessionService
    {
        private IUnitofWork uow;
        private IRepository<FilmSessionModel> SessionRepository;
        private IMapper mapper;
        public FilmSessionService(IUnitofWork _uow, IMapper _mapper)
        {
            mapper = _mapper;
            uow = _uow;
            SessionRepository = uow.GetRepository<FilmSessionModel>();
        }

        public void Add(AddSessionDto sessionDto)
        {
            var entity = mapper.Map<FilmSessionModel>(sessionDto);
            SessionRepository.Add(entity);
            uow.SaveChange();
        }

        public void Delete(SessionDto sessionDto)
        {
            var entity = mapper.Map<FilmSessionModel>(sessionDto);
            SessionRepository.Delete(entity);
            uow.SaveChange();
        }

        public IEnumerable<SessionDto> GetAllSession()
        {
            var entity = SessionRepository.GetAll();
            return mapper.Map<IEnumerable<SessionDto>>(entity);
        }

        public SessionDto GetSession(int id)
        {
            var entity = SessionRepository.GetById(id);
            return mapper.Map<SessionDto>(entity);
        }

        public void Update(SessionDto sessionDto)
        {
            var entity = mapper.Map<FilmSessionModel>(sessionDto);
            SessionRepository.Update(entity);
            uow.SaveChange();
        }
    }
}
