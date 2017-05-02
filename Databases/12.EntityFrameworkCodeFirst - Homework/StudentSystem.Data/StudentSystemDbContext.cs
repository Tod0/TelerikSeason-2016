﻿using System.Data.Entity;

using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext() : base("StudentSystem")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<CourseMaterial> CourseMaterials { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }
    }
}
