using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_999
{
    internal class Group
    {
        public string No { get; set; }
        public Student[] Students { get; set; }
        public int StudentCount { get; set; }
        public int StudentLimit { get; set; }

        public Group(string no, int studentLimit)
        {
            No = no;
            Students = new Student[studentLimit];
            StudentCount = 0;
            StudentLimit = studentLimit;
        }

        public void AddStudent(Student student)
        {
            if (StudentCount < StudentLimit)
            {
                Students[StudentCount] = student;
                StudentCount++;
                Console.WriteLine($"{student.FullName} qrupa əlavə edildi.");
            }
            else
            {
                Console.WriteLine("Tələbənin limiti dolub. Əlavə edilə bilmədi.");
            }
        }
    }
}
