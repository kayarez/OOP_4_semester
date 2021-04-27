using OOP_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_12.Controller
{
    class StudentController
    {
        public bool CheckIfStudentExists(Student student)
        {
            MyDbContext context = new MyDbContext();
            if (context.Students.FirstOrDefault(Student => Student.Surname == student.Surname) != null && context.Students.FirstOrDefault(Student => Student.Name == student.Name) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddStudent(Student student)
        {
            try
            {
                if (!CheckIfStudentExists(student))
                {
                    MyDbContext context = new MyDbContext();
                    context.Students.Add(student);
                    context.SaveChanges();
                    return true;

                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool RemoveStudent(Student student)
        {
            try
            {
                if (CheckIfStudentExists(student))
                {
                    MyDbContext context = new MyDbContext();
                    context.Students.Attach(student);
                    context.Students.Remove(student);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
