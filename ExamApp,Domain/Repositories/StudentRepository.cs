using ExamApp_Domain.Context;
using ExamApp_Domain.Entities;
using ExamApp_Domain.Repositories.Contracts;


namespace ExamApp_Domain.Repositories
{
    public sealed class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }
    }
}
