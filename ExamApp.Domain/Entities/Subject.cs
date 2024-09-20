namespace ExamApp.Domain.Entities
{
    public sealed class Subject : BaseEntity
    {
        public string SubjectCode { get; set; } = string.Empty; // char (3)
        public string SubjectName { get; set; } = string.Empty; // varchar(30)
        public byte ClassNumber { get; set; }  // number(2,0) => tinyint
        public string TeacherFirstName { get; set; } = string.Empty; // varchar(20)
        public string TeacherLastName { get; set; } = string.Empty;  // varchar(20)
    }
}
