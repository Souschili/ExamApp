namespace ExamApp.Services.DTOs
{
    public record class SubjectDto
    {
        public required string SubjectCode { get; init; } = string.Empty;
        public required string SubjectName { get; init; } = string.Empty;
        public required int ClassNumber { get; init; }   // чтобы ловить негативные значения при валидации в сущности это поле байт
        public required string TeacherFirstName { get; init; } = string.Empty;
        public required string TeacherLastName { get; init; } = string.Empty;
    }
}
