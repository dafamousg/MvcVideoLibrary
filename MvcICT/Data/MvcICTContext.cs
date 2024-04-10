using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcICT.Models;

namespace MvcICT.Data
{
    public class MvcICTContext : DbContext
    {
        public MvcICTContext (DbContextOptions<MvcICTContext> options)
            : base(options)
        {
        }

        public DbSet<MvcICT.Models.Video> Video { get; set; } = default!;
    }
}
