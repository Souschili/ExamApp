using ExamApp.Domain.Context;
using ExamApp.Domain.Entities;
using ExamApp.Domain.Repositories.Contracts;


namespace ExamApp.Domain.Repositories
{
    public sealed class SubjectRepository : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(AppDbContext context) : base(context) { }

    }
}
