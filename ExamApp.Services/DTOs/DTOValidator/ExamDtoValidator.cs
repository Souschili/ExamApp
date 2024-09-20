using FluentValidation;

namespace ExamApp.Services.DTOs.DTOValidator
{
    public class ExamDtoValidator : AbstractValidator<ExamDto>
    {
        public ExamDtoValidator()
        {
            RuleFor(x => x.SubjectCode)
                .NotEmpty()
                .Length(3)
                .WithMessage("SubjectCode must be exactly 3 characters long.");

            RuleFor(x => x.StudentNumber)
                .Must(x => x > 1 && x < 100000)
                .WithMessage("StudentNumber must be between 1 and 99999.");

            RuleFor(x => x.Date)
                .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now)) // считаем что экзамен уже был
                .WithMessage("Date cannot be in the future.");

            RuleFor(x => x.Mark)
                .Must(x => x > 0 && x < 6) // возможно максимальная оценка 5
                .WithMessage("Mark must be between 1 and 5.");
        }
    }

}
