using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DailyBlogger_Alex_C.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogPost> blogPost { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
    }
}
