using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим количество работников.
            Console.Write("Введите количество работников: ");
            int Number= int.Parse(Console.ReadLine());
            
            Worker[] Workers = ReadWorkersArray(Number);

            // PrintWorker-METHOD.
            Console.Write("Введите номер работника, информацию про которого следует вывести на экран: ");
            int N = int.Parse(Console.ReadLine());
            
            PrintWorker(Workers[N]);

            Console.WriteLine();
            Console.ReadKey();

            // PrintWorkers-METHOD.
            Console.WriteLine("Информация про всех работников");
            PrintWorkers(Workers);

            Console.WriteLine();
            Console.ReadKey();

            // Minimal and Maximal Salary.
            double MinimalSalary, MaximalSalary;
            GetWorkersInfo(Workers, out MinimalSalary, out MaximalSalary);

            Console.WriteLine($"Minimal Salary: {MinimalSalary}\n" +
                $"Maximal Salary: {MaximalSalary}");
            Console.WriteLine();
            Console.ReadKey();

            // SortWorkerBySalary.
            SortWorkerBySalary(Workers);
            PrintWorkers(Workers);

            Console.ReadKey();

            // SortWorkerBySalary.
            SortWorkerByExperience(Workers);
            PrintWorkers(Workers);

            Console.ReadKey();
        }

        static Worker[] ReadWorkersArray(int number_of_workers)
        {
            Worker[] Workers = new Worker[number_of_workers];
            for(var i = 0; i < Workers.Length; i++)
            {
                Console.Write($"Имя работника № {i}: ");
                string name = Console.ReadLine();

                Console.Write($"Год начала работы: ");
                int year_begin = int.Parse(Console.ReadLine());

                Console.Write($"Месяц начала работы: ");
                byte month_begin = byte.Parse(Console.ReadLine());

                Console.Write($"Название компании: ");
                string name_company = Console.ReadLine();

                Console.Write($"Должность: ");
                string position = Console.ReadLine();

                Console.Write($"Зарплата: ");
                double salary = double.Parse(Console.ReadLine());

                Workers[i] = new Worker(name, year_begin, month_begin, name_company, position, salary);
                Console.WriteLine();
            }
            return Workers;
        }

        static void PrintWorker(Worker workers)
        {
            string name = workers.GetName();
            int year_begin = workers.GetYearBegin();
            byte month_begin = workers.GetMonthBegin();
            string name_company = workers.GetNameOfCompany();
            string position = workers.GetPositionWorkers();
            double salary = workers.GetSalaryWorkers();

            Console.WriteLine(
                $"Имя: {name}\n" +
                $"Год начала работы: {year_begin}\n" + 
                $"Месяц начала работы: {month_begin}\n" +
                $"Название компании: {name_company}\n" +
                $"Должность: {position}\n" +
                $"Зарплата: {salary}");
        }

        static void PrintWorkers(Worker[] workers)
        {
            foreach(Worker worker in workers)
            {
                string name = worker.GetName();
                int year_begin = worker.GetYearBegin();
                byte month_begin = worker.GetMonthBegin();
                string name_company = worker.GetNameOfCompany();
                string position = worker.GetPositionWorkers();
                double salary = worker.GetSalaryWorkers();

                Console.WriteLine(
                    $"Работник: {name}\n" +
                    $"Год начала работы: {year_begin}\n" +
                    $"Месяц начала работы: {month_begin}\n" +
                    $"Название компании: {name_company}\n" +
                    $"Должность: {position}\n" +
                    $"Зарплата: {salary}");
                Console.WriteLine();
            }
        }

        static void GetWorkersInfo(Worker[] Workers, out double minimalSalary, out double maximalSalary)
        {
            minimalSalary = Workers[0].GetSalaryWorkers();
            maximalSalary = minimalSalary;
            foreach (Worker worker in Workers)
            {
                if (minimalSalary > worker.GetSalaryWorkers())
                {
                    minimalSalary = worker.GetSalaryWorkers();
                }


                if (maximalSalary < worker.GetSalaryWorkers())
                {
                    maximalSalary = worker.GetSalaryWorkers();
                }
            }
        }

        static Worker[] SortWorkerBySalary(Worker[] workers)
        {
            Array.Sort(workers, new WorkerComparerForSalary());
            return workers;
        }

        static Worker[] SortWorkerByExperience(Worker[] workers)
        {
            Array.Sort(workers, new WorkerComparerForExperience());
            return workers;
        }
    }
}