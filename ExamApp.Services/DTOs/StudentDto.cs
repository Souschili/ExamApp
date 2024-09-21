namespace ExamApp.Services.DTOs
{
    public record class StudentDto
    {
        public required int StudentNumber { get; init; }
        public required string Firstname { get; init; } = string.Empty;
        public required string Lastname { get; init; } = string.Empty;
        public required int ClassNumber { get; init; }   // чтобы ловить негативные значения при валидации в сущности это поле байт
    }
}
