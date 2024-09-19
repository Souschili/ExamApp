using ExamApp_Domain.Context;
using ExamApp_Domain.Entities;
using ExamApp_Domain.Repositories.Contracts;


namespace ExamApp_Domain.Repositories
{
    public class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(AppDbContext context) : base(context) { }

    }
}
