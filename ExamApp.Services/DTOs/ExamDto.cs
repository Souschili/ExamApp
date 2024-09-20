namespace ExamApp.Services.DTOs
{
    public class ExamDto
    {
        public required string SubjectCode { get; init; } = string.Empty; // char(3)
        public required int StudentNumber { get; init; }  // number(5,0)
        public required DateOnly Date { get; init; }      // date
        public required byte Mark { get; init; }          // number(1,0)
    }
}
