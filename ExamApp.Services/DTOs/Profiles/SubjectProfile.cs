using AutoMapper;
using ExamApp.Domain.Entities;

namespace ExamApp.Services.DTOs.Profiles
{
    internal class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            // в обе стороны так как имена полей идентичны
            CreateMap<SubjectDto, Subject>().ReverseMap();
        }
    }
}
