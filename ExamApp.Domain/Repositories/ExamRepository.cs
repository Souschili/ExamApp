using ExamApp.Domain.Context;
using ExamApp.Domain.Entities;
using ExamApp.Domain.Repositories.Contracts;


namespace ExamApp.Domain.Repositories
{
    public sealed class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(AppDbContext context) : base(context) { }
    }
}
