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
        private readonly ILogger<RegistrationController> _logger;

        public RegistrationController(IRegistrationService registrationService, ILogger<RegistrationController> logger)
        {
            _registrationService = registrationService;
            _logger = logger;
        }

        [HttpPost("subjects")]
        public async Task<IActionResult> SubjectRegistration([FromBody] SubjectDto subjectDto)
        {
            _logger.LogInformation("Register subject {@subject}", subjectDto);
            await _registrationService.SubjectRegistrationAsync(subjectDto);
            return NoContent();
        }

        [HttpPost("students")]
        public async Task<IActionResult> StudentRegistration([FromBody] StudentDto studentDto)
        {
            _logger.LogInformation("Register student {@student}", studentDto);
            await _registrationService.StudentRegistrationAsync(studentDto);
            return NoContent();
        }

        [HttpPost("exams")]
        public async Task<IActionResult> ExamsRegistration([FromBody] ExamDto examDto)
        {
            _logger.LogInformation("Register exam {@exam}", examDto);
            await _registrationService.ExamRegistrationAsync(examDto);
            return NoContent();
        }
    }
}
