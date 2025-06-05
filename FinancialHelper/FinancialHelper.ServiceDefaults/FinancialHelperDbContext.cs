using Microsoft.EntityFrameworkCore;

namespace FinancialHelper.ServiceDefaults
{
    public class FinancialHelperDbContext : DbContext
    {
        public FinancialHelperDbContext(DbContextOptions<FinancialHelperDbContext> options)
            : base(options) { }
    }
}
