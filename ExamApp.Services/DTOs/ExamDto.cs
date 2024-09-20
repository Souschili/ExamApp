namespace ExamApp.Services.DTOs
{
    public class ExamDto
    {
        public required string SubjectCode { get; init; } = string.Empty; // char(3)
        public required int StudentNumber { get; init; }  // number(5,0)
        public required string Date { get; init; }      // date as string иначе придется лепить правила для конвертации и мне лениво
        public required byte Mark { get; init; }          // number(1,0)
    }
}
