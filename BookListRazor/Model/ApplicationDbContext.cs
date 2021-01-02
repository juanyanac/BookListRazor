using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDbContext : DbContext // herda desde EntityFrameworkCore
    {
        ///contrutor para passar os paametros da conexao, 
        ///este es um construtor vacio mas os parametros sao necesarios para a injecao de depndencia
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
