namespace ExamApp_Domain.Entities
{
    public class Student : BaseEntity
    {
        public uint StudentNumber { get; set; } // number(5,0)
        public string Firstname { get; set; } = string.Empty; // varchar(30)
        public string Lastname { get; set; } = string.Empty; // varchar(30)
        public byte ClassNumber { get; set; } // number(2,0) 
    }
}
