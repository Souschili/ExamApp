using ExamApp.Services.DTOs;

namespace ExamApp.Services.Services.Contract
{
    public interface IRegistrationService
    {
        Task SubjectRegistrationAsync(SubjectDto subjectDto);
        Task StudentRegistrationAsync(StudentDto studentDto);
        Task ExamRegistrationAsync(ExamDto examDto);
    }
}
