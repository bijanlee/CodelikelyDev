using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodelikelyAPI.Models;

namespace CodelikelyAPI.Data
{
    public class CodelikelyAPIContext : DbContext
    {
        public CodelikelyAPIContext (DbContextOptions<CodelikelyAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }
    }
}
