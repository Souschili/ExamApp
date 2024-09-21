using ExamApp.Services.DTOs;
using ExamApp.Services.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            throw new NotImplementedException("We check our exception handler");
        }

        [HttpPost("subjects")]
        public async Task<IActionResult> SubjectRegistration(SubjectDto subjectDto)
        {
            await _registrationService.SubjectRegistrationAsync(subjectDto);
            return NoContent();
        }

        [HttpPost("students")]
        public async Task<IActionResult> StudentRegistration(StudentDto studentDto)
        {
            await _registrationService.StudentRegistrationAsync(studentDto);
            return NoContent();
        }

        [HttpPost("exams")]
        public async Task<IActionResult> ExamsRegistration(ExamDto examDto)
        {
            await _registrationService.ExamRegistrationAsync(examDto);
            return NoContent();
        }
    }
}
