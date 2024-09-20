using AutoMapper;
using ExamApp.Domain.Entities;

namespace ExamApp.Services.DTOs.Profiles
{
    internal class StudentProfile : Profile
    {
        public StudentProfile()
        {
            // в обе стороны так как имена полей идентичны
            CreateMap<StudentDto, Student>().ReverseMap();
        }
    }
}
