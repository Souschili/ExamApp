using ExamApp_Domain.Configuration.EntitiesConfiguration;
using ExamApp_Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExamApp_Domain.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Exam> Exams => Set<Exam>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add all model config
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var changeTracker = base.ChangeTracker
                              .Entries<BaseEntity>()
                              .Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);
            foreach (var item in changeTracker)
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.CreatedAt = DateTime.UtcNow;
                }
                else
                {
                    item.Entity.UpdatetAt = DateTime.UtcNow;
                }

            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
