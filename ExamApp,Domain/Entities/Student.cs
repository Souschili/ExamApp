namespace ExamApp_Domain.Entities
{
    public sealed class Student : BaseEntity
    {
        public ushort StudentNumber { get; set; } // number(5,0)
        public string Firstname { get; set; } = string.Empty; // varchar(30)
        public string Lastname { get; set; } = string.Empty; // varchar(30)
        public byte ClassNumber { get; set; } // number(2,0) 
    }
}
