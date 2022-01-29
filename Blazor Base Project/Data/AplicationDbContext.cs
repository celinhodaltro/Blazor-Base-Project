using Microsoft.EntityFrameworkCore;
using Blazor_Base_Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Base_Project.Data
{
    public class AplicationDbContext : DbContext
    {

        public AplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }



    }
}
