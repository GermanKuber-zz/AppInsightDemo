using Microsoft.EntityFrameworkCore;

namespace AppInsightDemo.Web.Data
{
    public class AppInsightDemoContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppInsightDemoContext(DbContextOptions options) : base(options)
        {
        }

    }
}