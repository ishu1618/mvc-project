using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
    }
}
