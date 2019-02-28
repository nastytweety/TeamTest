using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamTest.Models
{
    public class Teacher
    {
        public Teacher()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key, ForeignKey("ApplicationUser")]
        public string TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}