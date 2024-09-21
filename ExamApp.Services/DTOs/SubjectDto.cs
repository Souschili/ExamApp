namespace ExamApp.Services.DTOs
{
    public record class SubjectDto
    {
        public required string SubjectCode { get; init; } = string.Empty; 
        public required string SubjectName { get; init; } = string.Empty; 
        public required byte ClassNumber { get; init; }  
        public required string TeacherFirstName { get; init; } = string.Empty; 
        public required string TeacherLastName { get; init; } = string.Empty;  
    }
}
