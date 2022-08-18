
using Microsoft.EntityFrameworkCore;
using TrackingApiApp.Models;

namespace TrackingApiApp.Data;

public class IssueDbContext : DbContext 
{
    public IssueDbContext(DbContextOptions<IssueDbContext> options)
        :base(options)
    {
    }
    public DbSet<Issue> Issues { get; set; }
}
