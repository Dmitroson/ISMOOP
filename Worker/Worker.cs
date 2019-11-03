using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int YearBegin;
        protected byte MonthBegin;
        protected Company WorkPlace;

        // Конструктор по умолчанию.
        public Worker()
        {
            Name = "Ivanov I.I.";
            YearBegin = 2015;
            MonthBegin = 10;
            WorkPlace = new Company();

        }

        // Параметрический конструктор.
        public Worker(string newName, int newYearBegin, byte newMonthBegin, string name_of_company, string position_in_company, double salary)
        {
            Name = newName;
            YearBegin = newYearBegin;
            MonthBegin = newMonthBegin;
            WorkPlace = new Company(name_of_company, position_in_company, salary);
        }

        // Конструктор this.
        public Worker(string newName, int newYearBegin, byte newMonthBegin) : 
            this(newName, newYearBegin, newMonthBegin, "ISM", "Back-End Developer", 800) { }

        // Конструктор копирования.
        public Worker(Worker obj)
        {
            obj = new Worker();
        }
        
        // Реализация Get-метода.
        public string GetName()
        {
            return Name;
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        public int GetYearBegin()
        {
            return YearBegin;
        }
        public void SetYearBegin(int newYearBegin)
        {
            YearBegin = newYearBegin;
        }

        public byte GetMonthBegin()
        {
            return MonthBegin;
        }
        public void SetMonthBegin(byte newMonthBegin)
        {
            MonthBegin = newMonthBegin;
        }
        // Get Company.
        public string GetNameOfCompany()
        {
            return WorkPlace.GetNameCompany();
        }

        public string GetPositionWorkers()
        {
            return WorkPlace.GetPosition();
        }

        public double GetSalaryWorkers()
        {
            return WorkPlace.GetSalary();
        }


        // 4 задание.
        public double GetWorkExperience()
        {
            int NowYear = DateTime.Now.Year;
            int NowMonth = DateTime.Now.Month;
            int begin_year = GetYearBegin();
            int begin_month = GetMonthBegin();
            double WorkExperience = ((NowYear * 12 + NowMonth) - (begin_year * 12 + begin_month));
            return WorkExperience;
        }

        public double GetTotalMoney()
        {
            double TotalMoney = GetWorkExperience() * WorkPlace.GetSalary();
            return TotalMoney;
        }

    }
}