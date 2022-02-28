using Microsoft.EntityFrameworkCore;
using SessionScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Course> Course { get;set;}
        public DbSet<Session> SessionMaster { get;set;}
        public DbSet<SessionView> SessionView { get;set;} 
    }
}
