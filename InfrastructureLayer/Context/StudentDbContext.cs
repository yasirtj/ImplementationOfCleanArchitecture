using EntitiesLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer.Context
{
    public interface IStudentDbContext
    {
        public DbSet<EntitiesLayer.Student> Students { get; set; }
        public DbSet<T> Set<T>() where T : class;
         void Save();
       
    }
 
    public class StudentDbContext : DbContext, IStudentDbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options){}
        public DbSet<EntitiesLayer.Student> Students { get; set; }
        public DbSet<EntitiesLayer.Subject> Subjects { get; set; }

        public void Save()
        {
            SaveChanges();
        }

    }
}
