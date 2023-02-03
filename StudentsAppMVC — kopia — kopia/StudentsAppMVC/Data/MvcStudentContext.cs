using Microsoft.EntityFrameworkCore;
using StudentsAppMVC.Models;

namespace StudentsAppMVC.Data
{
    public class MvcStudentsContext : DbContext
    {
        public MvcStudentsContext(DbContextOptions<MvcStudentsContext> options) : base(options)
        {
        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
