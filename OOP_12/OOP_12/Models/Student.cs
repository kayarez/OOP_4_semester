using OOP_12.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OOP_12.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual Group Group { get; set; }
        public virtual Course Course { get; set; }

        public Student()
        { }

        public Student(string name, string surname, string specialty, int course_number)
        {
            Name = name;
            Surname = surname;

            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    Group groupFromDb = context.Groups.First(group => group.Specialty == specialty);
                    Course courseFromDb = context.Courses.First(course => course.Number == course_number);
                    Group.Id = groupFromDb.Id;
                    Course.Number = courseFromDb.Number;
                }
                catch (Exception)
                {
                    Group group = new Group(specialty);
                    this.Group = group;
                    Course course = new Course(course_number);
                    this.Course = course;

                }

            }
        }
    }
}
