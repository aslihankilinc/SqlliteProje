using Microsoft.EntityFrameworkCore;
using Sqllite.Data.Table;

namespace Sqllite.Data
{
    public class Context:SqlliteDbContext
    {
        public Context() : base("sqlliteContext") { }

        public DbSet<Category> Category { get; set; }

    }
}
