using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using app_web_backend.Models;

namespace CondInteligente1.Data
{
    public class CondInteligente1Context : DbContext
    {
        public CondInteligente1Context (DbContextOptions<CondInteligente1Context> options)
            : base(options)
        {
        }

        public DbSet<app_web_backend.Models.Usuario> Usuario { get; set; } = default!;
    }
}
