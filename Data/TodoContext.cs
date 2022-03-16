using Microsoft.EntityFrameworkCore;
using TodoApi.Model;

namespace Data
{
    public class TodoContext : DbContext
    {
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<Answer> Answers => Set<Answer>();
        public DbSet<Topic> Topics => Set<Topic>();

        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Et eksempel på at man selv kan styre hvad en tabel skal hedde.
            modelBuilder.Entity<Question>().ToTable("Spørgsmål");
        }
    }
}