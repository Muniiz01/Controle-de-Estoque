using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//Classe de contexto do banco de dados, classe que representa o banco de dados

namespace ControleDeEstoque.DataBase
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EstoqueEPI;");
        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}

