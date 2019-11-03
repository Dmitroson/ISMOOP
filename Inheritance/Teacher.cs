using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Student
    {
        protected string Position;
        protected string Department;
        protected new string Institution;

        public Teacher()
        {
            Position = "Teacher Of Programming";
            Department = "Informatics";
            Institution = "ZDU";
        }

        public Teacher(string Position, string Department, string Institution)
        {
            this.Position = Position;
            this.Department = Department;
            this.Institution = Institution;
        }

        public Teacher(string Position, string Department, string Faculty, string Institution) : base(Faculty)
        {
            this.Position = Position;
            this.Department = Department;
            this.Institution = Institution;
        }

        public Teacher(Teacher obj)
        {
            obj = new Teacher();
        }

        public string GetPosition()
        {
            return Position;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public void SetDepartment(string Department)
        {
            this.Department = Department;
        }

        public override string GetInstitution()
        {
            return this.Institution;
        }

        public override void SetInstitution(string Institution)
        {
            this.Institution = Institution;
        }
    }
}
