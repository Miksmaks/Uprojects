using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQL_PROJECT1.SQLConnections
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){ }
        public DbSet<Employ> Employs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
