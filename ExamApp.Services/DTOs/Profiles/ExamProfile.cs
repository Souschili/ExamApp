using AutoMapper;
using ExamApp.Domain.Entities;

namespace ExamApp.Services.DTOs.Profiles
{
    internal class ExamProfile : Profile
    {
        public ExamProfile()
        {
            // в обе стороны так как имена полей идентичны
            CreateMap<ExamDto, Exam>().ReverseMap();
        }
    }
}
