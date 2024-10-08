﻿namespace ExamApp.Services.DTOs
{
    public record class ExamDto
    {
        public required string SubjectCode { get; init; } = string.Empty;
        public required int StudentNumber { get; init; }
        public required string Date { get; init; }      // date as string иначе придется лепить правила для конвертации и мне лениво
        public required int Mark { get; init; }         // чтобы ловить негативные значения при валидации в сущности это поле байт
    }
}
