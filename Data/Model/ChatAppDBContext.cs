using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ChatAppDBContext : DbContext
    {
        public ChatAppDBContext(DbContextOptions<ChatAppDBContext> options) : base(options) 
        {
        }
        public virtual DbSet<tbUser> tbUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<tbDoctor>().Ignore(a => a.Image);

        }

    }
}
