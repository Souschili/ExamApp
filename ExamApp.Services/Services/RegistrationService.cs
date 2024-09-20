using AutoMapper;
using ExamApp.Domain.Entities;
using ExamApp.Domain.Repositories.Contracts;
using ExamApp.Services.DTOs;
using ExamApp.Services.Services.Contract;

namespace ExamApp.Services.Services
{
    // один сервис для 3 операций ,если усложнить бизнес логику то надо пилить 3 сервиса
    // или захреначить один дженерик сервис при условии что все методы одинаковые :-)
    // по хорошему если бы это была полноценая раюота то можно было бы использовать unit of work
    // но мне лениво и это овер хеад в данном случае. И на инглише я устал коменты писать....
    // Все эти ДТО валидируются на уровне контроллера, и AutoMapper настроен на корректное преобразование в обе стороны, 
    // поэтому проверка на null в методах до и после маппинга не требуется.

    public class RegistrationService : IRegistrationService
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public RegistrationService(ISubjectRepository subjectRepository,
                                   IStudentRepository studentRepository,
                                   IExamRepository examRepository,
                                   IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _studentRepository = studentRepository;
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task ExamRegistrationAsync(ExamDto examDto)
        {
            var exam = _mapper.Map<Exam>(examDto);
            await _examRepository.CreateAsync(exam);
        }

        public async Task StudentRegistrationAsync(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);
            await _studentRepository.CreateAsync(student);
        }

        public async Task SubjectRegistrationAsync(SubjectDto subjectDto)
        {
            var subject = _mapper.Map<Subject>(subjectDto);
            await _subjectRepository.CreateAsync(subject);
        }
    }
}
