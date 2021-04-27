using OOP_12.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OOP_12.Controller
{
    class MyDbInitialize : DropCreateDatabaseIfModelChanges<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {

            //Course course = new Course
            //{
            //    Id = 1,
            //    Number = 1
            //};

            //Group group = new Group
            //{
            //    Id = 1,
            //    Specialty = "ИСиТ",
            //    CountStudents = 29,
            //    Course = course
            //};

            //Student student = new Student
            //{
            //    Id = 1,
            //    Surname = "Пупкин",
            //    Name = "Иван",
            //    Group = group,
            //    Course = course
            //};
            
            //context.Courses.Add(course);
            //context.Groups.Add(group);
            //context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
