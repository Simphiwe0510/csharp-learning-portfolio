using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Course
    {
        private string department;
        private int courseNumber, credits;
       
        public Course(string department, int courseNumber, int credits)
        {
           if (department.Length != 3)
           {
              throw new CourseException(department, courseNumber, credits);
           }
           if (courseNumber < 100 || courseNumber > 499)
           {
               throw new CourseException(department, courseNumber, credits);
           }
           if (credits < 1 || credits > 6)
           {
               throw new CourseException(department, courseNumber, credits);
           }
               this.department = department;
               this.courseNumber = courseNumber;
               this.credits = credits;
        }
        public override string ToString()
        {
           return department + " " + courseNumber + ", Credits: " + credits;
        }
        public Course()
        {
            this.department = "DEF";
            this.courseNumber = 100;
            this.credits = 3;
        }

    }
}
