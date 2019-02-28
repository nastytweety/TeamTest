namespace TeamTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostText = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        Login = c.String(),
                        Role = c.String(),
                        ProfilePic = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.PostStudents",
                c => new
                    {
                        Post_PostId = c.Int(nullable: false),
                        Student_StudentId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Post_PostId, t.Student_StudentId })
                .ForeignKey("dbo.Posts", t => t.Post_PostId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .Index(t => t.Post_PostId)
                .Index(t => t.Student_StudentId);
            
            CreateTable(
                "dbo.PostTeachers",
                c => new
                    {
                        Post_PostId = c.Int(nullable: false),
                        Teacher_TeacherId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Post_PostId, t.Teacher_TeacherId })
                .ForeignKey("dbo.Posts", t => t.Post_PostId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .Index(t => t.Post_PostId)
                .Index(t => t.Teacher_TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostTeachers", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.PostTeachers", "Post_PostId", "dbo.Posts");
            DropForeignKey("dbo.PostStudents", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.PostStudents", "Post_PostId", "dbo.Posts");
            DropIndex("dbo.PostTeachers", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.PostTeachers", new[] { "Post_PostId" });
            DropIndex("dbo.PostStudents", new[] { "Student_StudentId" });
            DropIndex("dbo.PostStudents", new[] { "Post_PostId" });
            DropTable("dbo.PostTeachers");
            DropTable("dbo.PostStudents");
            DropTable("dbo.Posts");
        }
    }
}
