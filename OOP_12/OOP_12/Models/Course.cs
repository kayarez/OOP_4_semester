﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

        public Course(int number)
        {
            Number = number;
        }
    }


}
