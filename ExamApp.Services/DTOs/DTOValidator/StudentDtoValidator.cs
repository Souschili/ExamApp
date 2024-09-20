﻿using FluentValidation;

namespace ExamApp.Services.DTOs.DTOValidator
{
    public class StudentDtoValidator : AbstractValidator<StudentDto>
    {
        public StudentDtoValidator()
        {
            RuleFor(x => x.StudentNumber)
                .Must(x => x > 0 && x < 10000)
                .WithMessage("StudentNumber must be between 1 and 99999.");

            RuleFor(x => x.Firstname)
                .NotEmpty()
                .Length(3, 30) // Ali min length
                .WithMessage("Firstname cannot be empty and must be up to 30 characters long.");

            RuleFor(x => x.Lastname)
                .NotEmpty()
                .Length(5, 30)  // Aliyev min length
                .WithMessage("Lastname cannot be empty and must be up to 30 characters long.");

            RuleFor(x => x.ClassNumber)
                .Must(x => x > 0 && x <= 11)
                .WithMessage("ClassNumber must be between 1 and 11.");
        }
    }

}
