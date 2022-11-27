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
    public class FilmService : IFilmService
    {
        private IUnitofWork uow;
        private IRepository<FilmModel> MovieRepository;
        private IMapper mapper;
        public FilmService(IUnitofWork _uow, IMapper _mapper)
        {
            uow = _uow;
            mapper = _mapper;
            MovieRepository = uow.GetRepository<FilmModel>();
        }

        public void Add(AddFilmDto dto)
        {
            var entity = mapper.Map<FilmModel>(dto);
            MovieRepository.Add(entity);
            uow.SaveChange();
        }

        public void Update(FilmDto dto)
        {
            var entity = mapper.Map<FilmModel>(dto);
            MovieRepository.Update(entity);
            uow.SaveChange();
        }

        public void Delete(FilmDto dto)
        {
            var entity = MovieRepository.GetById(dto.Id);
            MovieRepository.Delete(entity);
            uow.SaveChange();
        }

        public FilmDto GetMovie(int id)
        {
            var entity = MovieRepository.GetById(id);
            return mapper.Map<FilmDto>(entity);
        }

        public IEnumerable<FilmDto> GetAllMovie()
        {
            var entities = MovieRepository.GetAll();
            return mapper.Map<IEnumerable<FilmDto>>(entities);
        }

        public IEnumerable<GetSingleMovieDto> GetAllMovieByDto()
        {
            var entities = MovieRepository.GetAll()
                .Select(m => new GetSingleMovieDto()
                {
                    Id = m.Id,
                    FilmName = m.FilmName,
                    FilmHallModels = m.FilmHallModels.Select(s => new FilmHallDto()
                    {
                        Id = s.Id,
                        HallName = s.HallName,
                        FilmSessionModels = mapper.Map<IEnumerable<SessionDto>>(s.FilmSessionModels)
                    })
                });
            return entities;
        }

        public IEnumerable<GetSingleMovieDto> SearchMovie(SearchDto dto)
        {
            var entities = MovieRepository.GetAll()
                .Select(m => new GetSingleMovieDto()
                {
                    Id = m.Id,
                    FilmName = m.FilmName,
                    FilmHallModels = m.FilmHallModels.Select(s => new FilmHallDto()
                    {
                        Id = s.Id,
                        HallName = s.HallName,
                        FilmSessionModels = mapper.Map<IEnumerable<SessionDto>>(s.FilmSessionModels)

                    })
                });
            return entities;
        }
    }
}
