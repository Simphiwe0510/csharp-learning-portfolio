using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class CourseException:SystemException
    {
        private string department;
        private int courseNumber, credits;
        public CourseException(string department,int courseNumber,int credits):base("Invalid course: " + department + " " + courseNumber + ", credits: " + credits)
        {

        }
    }
}
