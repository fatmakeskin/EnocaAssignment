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
    public class FilmHallService:IFilmHallService
    {
        private IRepository<FilmHallModel> SalloonRepository;
        private IUnitofWork uow;
        IMapper mapper;
        public FilmHallService(IUnitofWork _uow, IMapper _mapper)
        {
            mapper = _mapper;
            uow = _uow;
            SalloonRepository = uow.GetRepository<FilmHallModel>();
        }

        public void Add(AddFilmHallDto filmhallDto)
        {
            var entity = mapper.Map<FilmHallModel>(filmhallDto);
            SalloonRepository.Add(entity);
            uow.SaveChange();
        }

        public void Delete(FilmHallDto filmhallDto)
        {
            var entity = mapper.Map<FilmHallModel>(filmhallDto);
            SalloonRepository.Delete(entity);
            uow.SaveChange();
        }

        public IEnumerable<FilmHallDto> GetAllSaloon()
        {
            var enitiy = SalloonRepository.GetAll();
            return mapper.Map<IEnumerable<FilmHallDto>>(enitiy);
        }

        public FilmHallDto GetSaloon(int id)
        {
            var entity = SalloonRepository.GetById(id);
            return mapper.Map<FilmHallDto>(entity);
        }

        public void Update(FilmHallDto filmhallDto)
        {
            var entity = mapper.Map<FilmHallModel>(filmhallDto);
            SalloonRepository.Update(entity);
        }
    }
}
