namespace ExamApp.Services.DTOs
{
    public record class SubjectDto
    {
        public required string SubjectCode { get; init; } = string.Empty; // char (3)
        public required string SubjectName { get; init; } = string.Empty; // varchar(30)
        public required byte ClassNumber { get; init; }  // number(2,0)
        public required string TeacherFirstName { get; init; } = string.Empty; // varchar(20)
        public required string TeacherLastName { get; init; } = string.Empty;  // varchar(20)
    }
}
