namespace ExamApp.Services.DTOs
{
    public class StudentDto
    {
        public required ushort StudentNumber { get; init; } // number(5,0)
        public required string Firstname { get; init; } = string.Empty; // varchar(30)
        public required string Lastname { get; init; } = string.Empty; // varchar(30)
        public required byte ClassNumber { get; init; } // number(2,0) 
    }
}
