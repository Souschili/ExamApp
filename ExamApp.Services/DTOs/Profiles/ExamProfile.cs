using AutoMapper;
using ExamApp.Domain.Entities;

namespace ExamApp.Services.DTOs.Profiles
{
    internal class ExamProfile : Profile
    {
        public ExamProfile()
        {
            // в обе стороны так как имена полей идентичны
            //CreateMap<ExamDto, Exam>().ReverseMap();

            // тут правила чуток другие изза того что в дто строка,
            // а надо преобразовать в DateOnly и обратно
            CreateMap<ExamDto, Exam>()
                .ForMember(dest => dest.Date, cfg => cfg.MapFrom(src => DateOnly.Parse(src.Date)))
                .ReverseMap()
                // можно сменить формат строкового преобразования 
                .ForMember(dest => dest.Date, cfg => cfg.MapFrom(src => src.Date.ToString("yyyy-MM-dd")));
        }
    }
}
