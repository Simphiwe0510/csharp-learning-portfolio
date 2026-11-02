using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class StudentManager
    {
        private Student[] students = new Student[100];
        private int count = 0;
        public void addStudent(Student s)
        {
            if (count < students.Length)
            {
                students[count] = s;
                count++;
            }
        }
        public void saveToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(students[i].Name + "," + students[i].Test1 + "," + students[i].Test2 + "," + students[i].Test3);
            }
            writer.Close();
        }

        public void loadFromFile(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                count = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    Student s = new Student();
                    s.Name = parts[0];
                    s.Test1 = Convert.ToDouble(parts[1]);
                    s.Test2 = Convert.ToDouble(parts[2]);
                    s.Test3 = Convert.ToDouble(parts[3]);
                    addStudent(s);
                }
            }
        }

        public void displayStudents()
        {
            for (int i = 0; i < count; i++)
            {
                Student s = students[i];
                Console.WriteLine(s.Name + " - Final Mark: " + s.computeFinalMark());
            }
        }
    }
}
