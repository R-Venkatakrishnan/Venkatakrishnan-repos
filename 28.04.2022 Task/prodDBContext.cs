using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFcore.Models
{
    public class prodDBContext:DbContext
    {
        public prodDBContext()
        {

        }
        public prodDBContext(DbContextOptions<prodDBContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6ROTE51;Initial Catalog=task;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<prod> Prods { get; set; }
    }
}
