using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public struct StudentList
    {
        public int Id;
        public string Name;
        public string Mayor;
        public float GPA;

        public StudentList(int id, string name, string mayor, float gpa)
        {
            Id = id;
            Name = name;
            Mayor = mayor;
            GPA = gpa;
        }
    }
}
