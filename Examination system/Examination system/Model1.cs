using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Examination_system
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Crs_Top> Crs_Top { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Std_Crs> Std_Crs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Choice>()
                .Property(e => e.Cho_Content)
                .IsUnicode(false);

            modelBuilder.Entity<Choice>()
                .Property(e => e.Cho_Char)
                .IsUnicode(false);

            modelBuilder.Entity<Choice>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Choice)
                .HasForeignKey(e => e.Model_Ans);

            modelBuilder.Entity<Course>()
                .Property(e => e.Crs_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Crs_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Crs_Top)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Std_Crs)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Instructors)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("Ins_Crs").MapLeftKey("Crs_Id").MapRightKey("Ins_Id"));

            modelBuilder.Entity<Crs_Top>()
                .Property(e => e.Crs_Top1)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Dept_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Dept_Loc)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.Dept_Id);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Questions)
                .WithMany(e => e.Exams)
                .Map(m => m.ToTable("Exm_Ques").MapLeftKey("Exm_Id").MapRightKey("Ques_Id"));

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Ins_Fname)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Ins_Lname)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Ins_Degree)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.Instructor)
                .HasForeignKey(e => e.Dept_ManagerId);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Exams)
                .WithOptional(e => e.Instructor)
                .HasForeignKey(e => e.Generator_Id);

            modelBuilder.Entity<Question>()
                .Property(e => e.Ques_Content)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Ques_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Choices)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.Ques_Id);

            modelBuilder.Entity<Student>()
                .Property(e => e.Std_Fname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Std_Lname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Std_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Std_Crs)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.U_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.U_Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.U_Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.U_Sex)
                .IsUnicode(false);
        }
    }
}
