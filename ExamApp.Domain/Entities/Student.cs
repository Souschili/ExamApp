namespace ExamApp.Domain.Entities
{
    public sealed class Student : BaseEntity
    {
        public int StudentNumber { get; set; } // number(5,0) => int
        public string Firstname { get; set; } = string.Empty; // varchar(30)
        public string Lastname { get; set; } = string.Empty; // varchar(30)
        public byte ClassNumber { get; set; } // number(2,0) => tinyint
    }
}
