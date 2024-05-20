using System.Data.Entity;

namespace StudentEdu.Data

{
    public class StudentEduDbContext:DbContext
    {
        public StudentEduDbContext():base("name=StudentEduDbConnectionStrOld")
        {
            
        }

        public DbSet<Student>Students {  get; set; } // dbset ile biz class ve db arasında ilişki kurmus oluyıruz.

        public DbSet<Group> Groups { get; set; }  

        public DbSet<Payment> Payments { get; set; } 
       
    }

}
