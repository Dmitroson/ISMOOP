using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string Name;
        protected string Position;
        protected double Salary;

        // Конструктор по уолчанию.
        public Company()
        {
            Name = "ISM";
            Position = "Front-End Developer";
            Salary = 400;
        }
        
        // Параметрический конструктор.
        public Company(string newName, string newPosition, double newSalary)
        {
            Name = newName;
            Position = newPosition;
            Salary = newSalary;
        }
        
        // Конструктор this.
        public Company(string newName, string newPosition) : this(newName, newPosition, 300) { }

        // Конструктор копирования.
        public Company(Company obj)
        {
            obj = new Company();
        }

        // Get/Set-методы.
        public string GetNameCompany()
        {
            return Name;
        }

        public void SetNameCompany(string newName)
        {
            Name = newName;
        }


        public string GetPosition()
        {
            return Position;
        }
        public void SetPosition(string newPosition)
        {
            Position = newPosition;
        }

        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double newSalary)
        {
            Salary = newSalary;
        }
        
    }
}
