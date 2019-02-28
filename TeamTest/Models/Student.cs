using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TeamTest.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key,ForeignKey("ApplicationUser")]
        public string StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}