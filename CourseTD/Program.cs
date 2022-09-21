using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] course=        
                {
                new Course{Id=1,Name="BCS",Fees=26000},
                new Course{Id=2,Name="BCA",Fees=19000},
                new Course{Id=3,Name="BBA",Fees=25050},
                new Course{Id=4,Name="MCA",Fees=55000},
                new Course {Id=5,Name="Think Quotient", Fees=153400}

            };
            foreach (Course  c in course)
            {
                Console.WriteLine(c);
            }
        }

    }
}
