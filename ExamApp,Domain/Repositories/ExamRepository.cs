using ExamApp_Domain.Context;
using ExamApp_Domain.Entities;
using ExamApp_Domain.Repositories.Contracts;


namespace ExamApp_Domain.Repositories
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(AppDbContext context) : base(context) { }
    }
}
