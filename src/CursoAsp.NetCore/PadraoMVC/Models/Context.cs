using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using PadraoMVC.Models;

namespace PadraoMVC.Models
{
    public class Context : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=localhost\\SQLEXPRESS; Database=PadraoMVC; Trusted_Connection = True;");

        //}
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public object Categoria { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        public object Produto { get; internal set; }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

    }
}
