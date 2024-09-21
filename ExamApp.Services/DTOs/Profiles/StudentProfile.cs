using AutoMapper;
using ExamApp.Domain.Entities;

namespace ExamApp.Services.DTOs.Profiles
{
    internal class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDto, Student>()
                .ForMember(dest => dest.ClassNumber, cfg => cfg.MapFrom(src => (byte)src.ClassNumber))
                .ReverseMap()
                .ForMember(dest => dest.ClassNumber, cfg => cfg.MapFrom(src => (int)src.ClassNumber));
        }
    }
}
