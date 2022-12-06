using AutoMapper;
using EnocaAssigment.Domain.Data;
using EnocaAssignment.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AddFilmDto, FilmModel>();
            CreateMap<FilmModel, FilmDto>();
            CreateMap<FilmDto, FilmModel>();

            CreateMap<AddFilmHallDto, FilmHallModel>();
            CreateMap<FilmHallModel, FilmHallDto>();
            CreateMap<FilmHallDto, FilmHallModel>();

            CreateMap<AddSessionDto, FilmSessionModel>();
            CreateMap<FilmSessionModel, SessionDto>();
            CreateMap<SessionDto, FilmSessionModel>();           

        }
    }
}
