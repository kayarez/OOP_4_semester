using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        public int CountStudents { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Group (string specialty)
        {
            Specialty = specialty;
        }
    }
}
