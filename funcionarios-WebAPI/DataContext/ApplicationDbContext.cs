using funcionarios_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace funcionarios_WebAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
