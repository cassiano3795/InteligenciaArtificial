using System;
using System.Collections.Generic;
using System.Text;
using IADB.Model.BackPropagation;
using Microsoft.EntityFrameworkCore;

namespace IADB.Context
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("BaseIA");
            }
        }

        public virtual DbSet<Parametros> Parametros { get; set; }
    }
}
