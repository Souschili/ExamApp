namespace ExamApp.Domain.Entities
{
    public sealed class Exam : BaseEntity
    {
        public string SubjectCode { get; set; } = string.Empty; // char(3)
        public int StudentNumber { get; set; }  // number(5,0)
        public DateOnly Date { get; set; }      // date
        public byte Mark { get; set; }          // number(1,0)
    }
}
