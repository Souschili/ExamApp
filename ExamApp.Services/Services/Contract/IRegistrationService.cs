using ExamApp.Services.DTOs;

namespace ExamApp.Services.Services.Contract
{
    public interface IRegistrationService
    {
        Task SubjectRegistration(SubjectDto subjectDto);
        Task StudentRegistration(StudentDto studentDto);
        Task ExamRegistration(ExamDto examDto);
    }
}
