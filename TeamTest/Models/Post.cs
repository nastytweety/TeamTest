using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamTest.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostText { get; set; }
        public DateTime PostDate { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
        public string ProfilePic { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}