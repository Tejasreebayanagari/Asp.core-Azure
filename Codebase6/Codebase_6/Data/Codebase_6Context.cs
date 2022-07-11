using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codebase_6.Model;

namespace Codebase_6.Data
{
    public class Codebase_6Context : DbContext
    {
        public Codebase_6Context (DbContextOptions<Codebase_6Context> options)
            : base(options)
        {
        }

        public DbSet<Codebase_6.Model.Employee>? Employee { get; set; }
    }
}
