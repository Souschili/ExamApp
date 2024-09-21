namespace ExamApp.Services.DTOs
{
    public class StudentDto
    {
        public required int StudentNumber { get; init; } 
        public required string Firstname { get; init; } = string.Empty; 
        public required string Lastname { get; init; } = string.Empty; 
        public required byte ClassNumber { get; init; }  
    }
}
