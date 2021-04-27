using OOP_12.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12.Controller
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("ITConnection")
        {

        }
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(new MyDbInitialize());
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
