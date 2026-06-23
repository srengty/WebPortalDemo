using Microsoft.EntityFrameworkCore;

namespace PortalApi.Models;

public class PortalContext : DbContext
{
    public PortalContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Exam> Exams => Set<Exam>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<Answer> Answers => Set<Answer>();
    public DbSet<Attempt> Attempts => Set<Attempt>();
}