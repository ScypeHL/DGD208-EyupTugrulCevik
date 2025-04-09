using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class DataOps
    {
        private List<StudentList> students;
        public DataOps()
        {

        }
        
        public void start()
        {
            generateList();
            // listStudents();
            // listStudentsWithLinQ();
            listStudentsWithLinQShorterEdition();
        }

        private void generateList()
        {
            students = new List<StudentList>
            {
                new StudentList(1, "Samet", "Computer Science", 2.7f),
                new StudentList(24, "Hasan", "Math", 3.9f),
                new StudentList(65, "Hüseyin", "Architecture", 3.1f),
                new StudentList(78, "Zeynep", "Medical", 3.5f),
                new StudentList(89, "Kaan", "Atlethe", 3.7f),
                new StudentList(112, "Merve", "Pilot", 3.2f),
                new StudentList(323, "Deniz", "Mechanic", 2.2f),
                new StudentList(1669, "Alara", "Teacher", 2.5f)
            };
        }

        private void listStudents()
        {
            List<StudentList> qualifiedStudents = new List<StudentList>();
            
            foreach (StudentList student in students)
            {
                if (student.GPA > 3)
                {
                    qualifiedStudents.Add(student);
                }
            }

            for (int i = 0; i < qualifiedStudents.Count - 1; i = i + 1)
            {
                for (int j = i + 1; j < qualifiedStudents.Count; j = j + 1)
                {
                    if (qualifiedStudents[i].GPA < qualifiedStudents[j].GPA)
                    {
                        StudentList temp = qualifiedStudents[i];
                        qualifiedStudents[i] = qualifiedStudents[j];
                        qualifiedStudents[j] = temp;
                    }
                }
            }

            printOut(qualifiedStudents);

        }

        private void listStudentsWithLinQ()
        {
            IEnumerable<StudentList> filteredStudent =
                from student in students
                where student.GPA > 3
                orderby student.GPA descending
                select student;

            printOut(filteredStudent.ToList());
        }

        private void listStudentsWithLinQShorterEdition()
        {
            // List<StudentList> sorted = students.Where(s => s.GPA > 3f).OrderByDescending(s => s.GPA).ToList();
            // printOut(sorted);

            string[] gpas = students.Where(a => a.GPA > 3f).OrderByDescending(s => s.GPA).ToList().Select(s => $"{s.Name} > {s.GPA}").ToArray();
            foreach (string gpa in gpas)
            {
                Console.WriteLine(gpa);
            }
        }

        private void printOut(List<StudentList> students)
        {
            for (int i = 0; i < students.Count; i = i + 1)
            {
                Console.WriteLine(students[i].Name);
            }
        }
    }
}
