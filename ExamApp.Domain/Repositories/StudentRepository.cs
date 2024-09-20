using ExamApp.Domain.Context;
using ExamApp.Domain.Entities;
using ExamApp.Domain.Repositories.Contracts;


namespace ExamApp.Domain.Repositories
{
    public sealed class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }
    }
}
