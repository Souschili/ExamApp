using FluentValidation;
using System.Globalization;

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
                .Must(date =>
                {
                    if (string.IsNullOrWhiteSpace(date)) return false; // Проверка на пустоту
                    return DateOnly.TryParse(date, out var parsedDate) &&
                    parsedDate <= DateOnly.FromDateTime(DateTime.UtcNow);
                })
                .WithMessage("Date must be in the format yyyy-MM-dd or MM/dd/yyyy and must not be in the future.");

            RuleFor(x => x.Mark)
                .Must(x => x > 0 && x < 6) // возможно максимальная оценка 5
                .WithMessage("Mark must be between 1 and 5.");
        }

        //private bool IsValidDate(string dateString)
        //{
        //    var formats = new[] { "yyyy-MM-dd", "MM/dd/yyyy", "dd/MM/yyyy" }; // добавьте нужные форматы
        //    return DateTime.TryParseExact(dateString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        //}
    }

}
