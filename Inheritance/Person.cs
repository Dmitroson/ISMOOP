using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        protected string Name;
        protected string Surname;
        protected DateTime BirthDate;

        public Person()
        {
            Name = "Ivan";
            Surname = "Ivanov";
            BirthDate = new DateTime(2000, 11, 1);
        }

        public Person(string name, string surname, DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
        }

        public Person(string name, string surname) : this(name, surname, new DateTime(2001, 12, 12)) { }

        public Person(Person obj)
        {
            obj = new Person();
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public DateTime GetBirthDate()
        {
            return BirthDate;
        }

        public void SetBirthDate(DateTime birthdate)
        {
            BirthDate = birthdate;
        }
    }
}
