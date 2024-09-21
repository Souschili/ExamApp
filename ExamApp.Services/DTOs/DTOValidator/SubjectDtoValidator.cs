using FluentValidation;

namespace ExamApp.Services.DTOs.DTOValidator
{
    // сами настроите правила если надо более конкретно
    public class SubjectDtoValidator : AbstractValidator<SubjectDto>
    {
        public SubjectDtoValidator()
        {
            // SubjectCode: exactly 3 characters
            RuleFor(x => x.SubjectCode)
                //.NotEmpty()
                .Length(3)
                .WithMessage("SubjectCode must consist of exactly 3 characters.");

            // SubjectName: required, max length 30 characters
            RuleFor(x => x.SubjectName)
                .NotEmpty()
                .MaximumLength(30)
                .WithMessage("SubjectName cannot be empty and must not exceed 30 characters.");

            // ClassNumber: byte (0-255), rule for valid range 1 to 12
            RuleFor(x => x.ClassNumber)
                .Must(x => x > 0 && x < 12) // если это не класс с 1 по 11 а номер кабинета то просто сбрось лимиты
                .WithMessage("ClassNumber must be between 1 and 11.");


            // TeacherFirstName: required, max length 20 characters
            RuleFor(x => x.TeacherFirstName)
                .NotEmpty()
                .MaximumLength(20)
                .WithMessage("TeacherFirstName cannot be empty and must not exceed 20 characters.");

            // TeacherLastName: required, max length 20 characters
            RuleFor(x => x.TeacherLastName)
                .NotEmpty()
                .MaximumLength(20)
                .WithMessage("TeacherLastName cannot be empty and must not exceed 20 characters.");

        }
    }
}
