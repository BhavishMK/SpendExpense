using Microsoft.EntityFrameworkCore;

namespace SpendExpense.Models
{
    public class SpendSmartDbContext : DbContext

    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext>options)
            : base(options)
        {
            
        }

    }
}
