﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codebase5.Controllers;

namespace Codebase5.Data
{
    public class Codebase5Context : DbContext
    {
        public Codebase5Context (DbContextOptions<Codebase5Context> options)
            : base(options)
        {
        }

        public DbSet<Codebase5.Controllers.Student>? Student { get; set; }
    }
}
