using EmprestimoDeLivros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EmprestimoDeLivros.Data
{
    public class ApplicationDbContext : DbContext
    {

        //construtor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }  

    }
}

