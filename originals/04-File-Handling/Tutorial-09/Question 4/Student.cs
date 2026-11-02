using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Student
    {
        public string Name { get; set; }
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double Test3 { get; set; }

        public double computeFinalMark()
        {
            return (Test1 * 0.3) + (Test2 * 0.3) + (Test3 * 0.4);
        }
    }
}
