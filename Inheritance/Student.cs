using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Entrant
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string Institution;

        public Student()
        {
            Course = 1;
            Group = "13BD-SOinf";
            Faculty = "Fiz-mat";
            Institution = "ZDU";
        }
        public Student(string Faculty) : this(Course: 2, Group: "d", Faculty, Institution: "ZDTU")
        {
            this.Faculty = Faculty;
        }

        public Student(int Course, string Group, string Faculty, string Institution)
        {
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.Institution = Institution;
        }

        public Student(string Name, string Surname, DateTime BirthDate, int Course, string Group, string Faculty, string Institution)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDate = BirthDate;
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.Institution = Institution;
        }

        public Student(Student obj)
        {
            obj = new Student();
        }

        public int GetCourse()
        {
            return Course;
        }

        public void SetCourse(int Course)
        {
            this.Course = Course;
        }

        public string GetGroup()
        {
            return Group;
        }

        public void SetGroup(string Group)
        {
            this.Group = Group;
        }

        public string GetFaculty()
        {
            return Faculty;
        }

        public void SetFaculty(string Faculty)
        {
            this.Faculty = Faculty;
        }

        public virtual string GetInstitution()
        {
            return Institution;
        }

        public virtual void SetInstitution(string Institution)
        {
            this.Institution = Institution;
        }
    }
}
