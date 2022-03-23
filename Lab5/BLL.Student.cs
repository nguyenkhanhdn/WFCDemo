using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    namespace BLL
    {
        public class BLLStudent
        {
            private List<Student> students = new List<Student>();
            public List<Student> GetStudents()
            {
                return this.students;
            }

            public void AddStudent(Student obj)
            {
                students.Add(obj);
            }
            public void RemoveStudent(Student s)
            {
                this.students.Remove(s);
            }
            public void RemoveStudentAt(int idx)
            {
                this.students.RemoveAt(idx);
            }
        }
    }    
}
