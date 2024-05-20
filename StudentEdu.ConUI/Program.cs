using StudentEdu.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEdu.ConUI

{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentEduDbContext context = new StudentEduDbContext();

            List<Student> students = context.Students.ToList();
            List<Group> groups = context.Groups.ToList();
            List<Payment> payments = context.Payments.ToList();
                
        }
    }

}
