namespace ExamApp.Services.DTOs
{
    public class ExamDto
    {
        public required string SubjectCode { get; init; } = string.Empty;
        public required int StudentNumber { get; init; }
        public required string Date { get; init; }      // date as string иначе придется лепить правила для конвертации и мне лениво
        public required int Mark { get; init; }
    }
}
