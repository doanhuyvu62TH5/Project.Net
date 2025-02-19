
using Microsoft.EntityFrameworkCore;
namespace QuantaWebsite.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        // Map các bảng có sẵn trong cơ sở dữ liệu
        public DbSet<New> News { get; set; }

    }
}
